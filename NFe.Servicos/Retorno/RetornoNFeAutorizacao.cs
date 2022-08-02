
using NFe.Classes.Servicos.Recepcao;

namespace NFe.Servicos.Retorno
{
    public class RetornoNFeAutorizacao : RetornoBasico
    {
        public RetornoNFeAutorizacao(string envioStr, string retornoStr, string retornoCompletaStr, retEnviNFe retorno, string xmlProc = "", string dir_xml = "")
            : base(envioStr, retornoStr, retornoCompletaStr, retorno)
        {
            Retorno = retorno;
            XmlProc = xmlProc;
            Dir_xml = dir_xml;
        }

        public new retEnviNFe Retorno { get; set; }
        public new string XmlProc { get; set; }
        public new string Dir_xml { get; set; }
    }
}