/********************************************************************************/
/* Projeto: Biblioteca ZeusNFe                                                  */
/* Biblioteca C# para emissão de Nota Fiscal Eletrônica - NFe e Nota Fiscal de  */
/* Consumidor Eletrônica - NFC-e (http://www.nfe.fazenda.gov.br)                */
/*                                                                              */
/* Direitos Autorais Reservados (c) 2014 Adenilton Batista da Silva             */
/*                                       Zeusdev Tecnologia LTDA ME             */
/*                                                                              */
/*  Você pode obter a última versão desse arquivo no GitHub                     */
/* localizado em https://github.com/adeniltonbs/Zeus.Net.NFe.NFCe               */
/*                                                                              */

using NFe.Classes.Servicos.AdmCsc;

namespace NFe.Servicos.Retorno
{
    public class RetornoAdmCscNFCe : RetornoBasico
    {
        public RetornoAdmCscNFCe(string envioStr, string retornoStr, string retornoCompletaStr, retAdmCscNFCe retorno)
            : base(envioStr, retornoStr, retornoCompletaStr, retorno)
        {
            Retorno = retorno;
        }

        public new retAdmCscNFCe Retorno { get; set; }
    }
}
