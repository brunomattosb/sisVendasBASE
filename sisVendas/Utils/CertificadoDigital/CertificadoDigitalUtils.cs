using System;
using System.Security.Cryptography.X509Certificates;
using System.Security;
using System.IO;

namespace sisVendas.Utils
{
    public class CertificadoDigitalUtils
    {
        // Exibe a lista de certificados instalados no PC e devolve o certificado selecionado
        public static X509Certificate2 ListarEObterDoRepositorio()
        {
            
            var store = ObterX509Store(OpenFlags.OpenExistingOnly | OpenFlags.ReadOnly);
            var collection = store.Certificates;
            var fcollection = collection.Find(X509FindType.FindByTimeValid, DateTime.Now, true);
            var scollection = X509Certificate2UI.SelectFromCollection(fcollection, "Certificados válidos:", "Selecione o certificado que deseja usar",
                X509SelectionFlag.SingleSelection);

            if (scollection.Count == 0)
            {
                throw new Exception("Nenhum certificado foi selecionado!");
            }

            store.Close();
            return scollection[0];
        }

        // Cria e devolve um objeto <see cref="X509Store"/>
        public static X509Store ObterX509Store(OpenFlags openFlags)
        {
            var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(openFlags);
            return store;
        }

    }
}
