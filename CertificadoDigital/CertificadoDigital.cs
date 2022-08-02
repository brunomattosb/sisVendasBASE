using DFe.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CertificadoDigital
{
    public class CertificadoDigital
    {
        private static readonly Dictionary<string, X509Certificate2> CacheCertificado = new Dictionary<string, X509Certificate2>();
        /// <summary>
        /// Cria e devolve um objeto <see cref="X509Store"/>
        /// </summary>
        /// <param name="openFlags"></param>
        /// <returns></returns>
        public static X509Store ObterX509Store(OpenFlags openFlags)
        {
            var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(openFlags);
            return store;
        }
        /// <summary>
        /// Define o PIN para chave privada de um objeto <see cref="X509Certificate2"/> passado no parâmetro
        /// </summary>

        /// <summary>
        /// Obtém um objeto <see cref="X509Certificate2"/> pelo serial passado no parâmetro e com opção de definir o PIN
        /// </summary>
        /// <param name="serial"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        private static X509Certificate2 ObterDoRepositorioPassandoPin(string serial, string senha = null)
        {
            var certificado = ObterDoRepositorio(serial, OpenFlags.ReadOnly);
            if (string.IsNullOrEmpty(senha))
                return certificado;

            if (certificado == null) throw new ArgumentNullException("certificado");
            var key = (RSACryptoServiceProvider)certificado.PrivateKey;

            var providerHandle = IntPtr.Zero;
            var pinBuffer = Encoding.ASCII.GetBytes(serial);

            MetodosNativos.Executar(() => MetodosNativos.CryptAcquireContext(ref providerHandle,
                key.CspKeyContainerInfo.KeyContainerName,
                key.CspKeyContainerInfo.ProviderName,
                key.CspKeyContainerInfo.ProviderType,
                MetodosNativos.CryptContextFlags.Silent));
            MetodosNativos.Executar(() => MetodosNativos.CryptSetProvParam(providerHandle,
                MetodosNativos.CryptParameter.KeyExchangePin,
                pinBuffer, 0));
            MetodosNativos.Executar(() => MetodosNativos.CertSetCertificateContextProperty(
                certificado.Handle,
                MetodosNativos.CertificateProperty.CryptoProviderHandle,
                0, providerHandle));
            
            return certificado;
        }
        
        /// <summary>
        /// Busca o certificado de acordo com o <see cref="ConfiguracaoCertificado.TipoCertificado"/>
        /// </summary>
        /// <returns></returns>
        private static X509Certificate2 ObterDadosCertificado(ConfiguracaoCertificado configuracaoCertificado)
        {
            switch (configuracaoCertificado.TipoCertificado)
            {
                case enumTipoCertificado.A1Repositorio:
                    return ObterDoRepositorio(configuracaoCertificado.Serial, OpenFlags.MaxAllowed);
                case enumTipoCertificado.A1ByteArray:
                    return ObterDoArrayBytes(configuracaoCertificado.ArrayBytesArquivo, configuracaoCertificado.Senha);
                case enumTipoCertificado.A1Arquivo:
                    return ObterDeArquivo(configuracaoCertificado.Arquivo, configuracaoCertificado.Senha);
                case enumTipoCertificado.A3:
                    return ObterDoRepositorioPassandoPin(configuracaoCertificado.Serial, configuracaoCertificado.Senha);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        /// <summary>
        /// Obtém um certificado a partir do arquivo e da senha passados nos parâmetros
        /// </summary>
        /// <param name="arquivo">Arquivo do certificado digital</param>
        /// <param name="senha">Senha do certificado digital</param>
        /// <returns></returns>
        private static X509Certificate2 ObterDeArquivo(string arquivo, string senha)
        {
            if (!File.Exists(arquivo))
            {
                throw new Exception(string.Format("Certificado digital {0} não encontrado!", arquivo));
            }

            var certificado = new X509Certificate2(arquivo, senha, X509KeyStorageFlags.MachineKeySet);
            return certificado;
        }


        /// <summary>
        /// Obtém um certificado a partir do arquivo e da senha passados nos parâmetros
        /// </summary>
        /// <param name="arrayBytes">Array de bytes do certificado digital</param>
        /// <param name="senha">Senha do certificado digital</param>
        /// <returns></returns>
        private static X509Certificate2 ObterDoArrayBytes(byte[] arrayBytes, string senha)
        {
            try
            {
                var certificado = new X509Certificate2(arrayBytes, senha, X509KeyStorageFlags.MachineKeySet);
                return certificado;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel converter o stream para o certificado.", ex);
            }
        }
        /// <summary>
        /// Obtém um objeto <see cref="X509Certificate2"/> pelo serial passado no parÂmetro
        /// </summary>
        /// <returns></returns>
        private static X509Certificate2 ObterDoRepositorio(string serial, OpenFlags opcoesDeAbertura)
        {
            if (string.IsNullOrEmpty(serial))
                throw new ArgumentException("O número de série do certificado digital não foi informado!");
            X509Certificate2 certificado = null;
            var store = ObterX509Store(opcoesDeAbertura);
            try
            {
                foreach (var item in store.Certificates)
                {
                    if (item.SerialNumber != null && item.SerialNumber.ToUpper().Equals(serial.ToUpper(), StringComparison.InvariantCultureIgnoreCase))
                        certificado = item;
                }

                if (certificado == null)
                    throw new Exception(string.Format("Certificado digital nº {0} não encontrado!", serial.ToUpper()));
            }
            finally
            {
                store.Close();
            }

            return certificado;
        }
        public static X509Certificate2 ValidarCertificado(ConfiguracaoCertificado configuracaoCertificado)
        {

            if (!configuracaoCertificado.ManterDadosEmCache)  // FALSE
                return ObterDadosCertificado(configuracaoCertificado);

            //CASO TENHA IDCACHE
            if (!string.IsNullOrEmpty(configuracaoCertificado.CacheId) && CacheCertificado.ContainsKey(configuracaoCertificado.CacheId))
                return CacheCertificado[configuracaoCertificado.CacheId];
            
            var certificado = ObterDadosCertificado(configuracaoCertificado);

            var keyCertificado = string.IsNullOrEmpty(configuracaoCertificado.CacheId)
                ? certificado.SerialNumber
                : configuracaoCertificado.CacheId;

            configuracaoCertificado.CacheId = keyCertificado;

            CacheCertificado.Add(keyCertificado, certificado);

            return CacheCertificado[keyCertificado];

        }

        internal static class MetodosNativos
        {
            internal enum CryptContextFlags
            {
                None = 0,
                Silent = 0x40
            }

            internal enum CertificateProperty
            {
                None = 0,
                CryptoProviderHandle = 0x1
            }

            internal enum CryptParameter
            {
                None = 0,
                KeyExchangePin = 0x20
            }

            [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool CryptAcquireContext(
                ref IntPtr hProv,
                string containerName,
                string providerName,
                int providerType,
                CryptContextFlags flags
                );

            [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern bool CryptSetProvParam(
                IntPtr hProv,
                CryptParameter dwParam,
                [In] byte[] pbData,
                uint dwFlags);

            [DllImport("CRYPT32.DLL", SetLastError = true)]
            internal static extern bool CertSetCertificateContextProperty(
                IntPtr pCertContext,
                CertificateProperty propertyId,
                uint dwFlags,
                IntPtr pvData
                );

            public static void Executar(Func<bool> action)
            {
                if (!action())
                {
                    throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());
                }
            }
        }
    }

}