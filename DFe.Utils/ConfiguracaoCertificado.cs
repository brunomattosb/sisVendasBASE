
using System;
using System.ComponentModel;

namespace DFe.Utils
{
    public enum enumTipoCertificado
    {
        [Description("Certificado A1")]
        A1Repositorio = 0,

        [Description("Certificado A1 em arquivo")]
        A1Arquivo = 1,

        [Description("Certificado A3")]
        A3 = 2,

        [Description("Certificado A1 em byte array")]
        A1ByteArray = 3
    }

    public class ConfiguracaoCertificado
    {
        private static string serial;
        private static enumTipoCertificado tipoCertificado;
        private static string arquivo;
        private static string cacheId;
        private static string senha;
        private static byte[] arrayBytesArquivo;
        private static bool manterDadosEmCache;
        private static string signatureMethodSignedXml;
        private static string digestMethodReference;
        private static DateTime dt_vencimento;

        /// <summary>
        ///     Manter/Não manter os dados do certificado em Cache, enquanto a aplicação que consome a biblioteca estiver aberta
        /// <para>Manter os dados do certificado em cache, aumentará o desempenho no consumo dos serviços, especialmente para certificados A3</para>
        /// </summary>
        public bool ManterDadosEmCache { get => manterDadosEmCache; set => manterDadosEmCache = value; }
        /// <summary>
        /// Tipo de certificado a ser usado
        /// </summary>
        public string Serial { get => serial; set => serial = value; }
        public ConfiguracaoCertificado()
        {
            SignatureMethodSignedXml = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
            DigestMethodReference = "http://www.w3.org/2000/09/xmldsig#sha1";
        }
        public enumTipoCertificado TipoCertificado
        {
            get { return tipoCertificado; }
            set
            {
                //Serial = null;
                //Arquivo = null;
                //Senha = null;
                //ArrayBytesArquivo = null;
                tipoCertificado = value;
            }
        }
        /// <summary>
        ///     Arquivo do certificado digital
        /// </summary>
        public string Arquivo
        {
            get { return arquivo; }
            set
            { arquivo = value; }
        }
        /// <summary>
        /// Id do certificado no cache do SisVendas
        /// </summary>
        public string CacheId
        {
            get { return cacheId; }
            set
            {
                if (value == cacheId) return;
                cacheId = value;
            }
        }


        /// <summary>
        ///     Senha do certificado digital
        /// <para>Informe a senha se desejar que o usuário não precise digitá-la toda vez que for iniciada uma nova instância da aplicação.
        /// Não informe a senha para certificado A1, exceto se configurar para usar o arquivo .pfx usando o atributo <see cref="Arquivo"/></para>
        /// </summary>
        public string Senha
        {
            get { return senha; }
            set
            {
                if (string.IsNullOrEmpty(value) && TipoCertificado != enumTipoCertificado.A1Repositorio)
                    if (value == senha) return;
                senha = value;
            }
        }

        /// <summary>
        /// Array de bytes do certificado
        /// </summary>
        public byte[] ArrayBytesArquivo
        {
            get { return arrayBytesArquivo; }
            set
            {
                if (value == arrayBytesArquivo) return;
                arrayBytesArquivo = value;
            }
        }

        /// <summary>
        ///     Algoritmo de Assinatura (Padrao: http://www.w3.org/2000/09/xmldsig#rsa-sha1)
        /// </summary>
        public string SignatureMethodSignedXml { get => signatureMethodSignedXml; set => signatureMethodSignedXml = value; }

        /// <summary>
        ///     URI para DigestMethod na Classe Reference para auxiliar para a assinatura (Padrao: http://www.w3.org/2000/09/xmldsig#sha1)
        /// </summary>
        public string DigestMethodReference { get => digestMethodReference; set => digestMethodReference = value; }
        public DateTime Dt_vencimento { get => dt_vencimento; set => dt_vencimento = value; }
    }
}
