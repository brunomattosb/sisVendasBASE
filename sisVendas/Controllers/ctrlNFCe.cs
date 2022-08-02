using sisVendas.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Controllers
{
    class ctrlNFCe
    {
        private Banco dataBase = new Banco();
        private Models.NFe nfcSelecionada = new Models.NFe();

        public bool SalvarNFCe(string chnf, string cstat, string nprot, string nrec, string xmotivo, int numero, int lote, string xml, string dir_xml)
        {

            //NFCe
            nfcSelecionada.Chnf = chnf;
            nfcSelecionada.Xml = xml;
            nfcSelecionada.Dir = dir_xml;
            nfcSelecionada.Nrec = nrec != "" ? long.Parse(nrec) : 0;
            nfcSelecionada.Xmotivo = xmotivo;
            nfcSelecionada.Cstat = int.Parse(cstat);
            nfcSelecionada.Nprot = nprot != "" ? long.Parse(nprot) : 0;
            nfcSelecionada.Lote = lote;
            nfcSelecionada.Num = numero;

            dataBase.Conecta();

            bool res = false;

            NFeDB cli = new NFeDB(dataBase);
            res = cli.Gravar(nfcSelecionada);

            dataBase.Desconecta();
            return (res);
        }
        public string buscarNumeroUltimaNFCe()
        {

            dataBase.Conecta();

            NFeDB nfeDB = new NFeDB(dataBase);

            string numNFCe = nfeDB.buscarNumeroUltimaNFCe();
            if (numNFCe == "")
                numNFCe = "1";
            dataBase.Desconecta();

            return (numNFCe);
        }
    }
}
