
namespace sisVendas.Models
{
    public class ConfiguracaoCsc
    {
        private static string cIdToken;
        private static string csc;

        /// <summary>
        /// Identificador do CSC – Código de Segurança do Contribuinte no Banco de Dados da SEFAZ
        /// </summary>
        public string CIdToken { get => cIdToken; set => cIdToken = value; }
        /// <summary>
        /// Código de Segurança do Contribuinte(antigo Token)
        /// </summary>
        public string Csc { get => csc; set => csc = value; }

        public ConfiguracaoCsc(string cIdToken, string csc)
        {
            CIdToken = cIdToken;
            Csc = csc;
        }

        /// <summary>
        /// Construtor sem parâmetros para serialização
        /// </summary>
        public ConfiguracaoCsc()
        { //35586973-1cea-4f34-9c83-3a7760ff365f
        }

        


       

    }
}
