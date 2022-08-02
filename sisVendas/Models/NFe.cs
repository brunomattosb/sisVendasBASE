using System;

namespace sisVendas.Models
{
    public class NFe
    {
        private long nprot;
        private int cstat;
        private string xmotivo;
        private long nrec;
        private string xml;
        private string chnf;
        private string dir;
        private long num;
        private int lote;


        public NFe()
        {
        }

        public long Nprot { get => nprot; set => nprot = value; }
        public int Cstat { get => cstat; set => cstat = value; }
        public string Xmotivo { get => xmotivo; set => xmotivo = value; }
        public long Nrec { get => nrec; set => nrec = value; }
        public string Xml { get => xml; set => xml = value; }
        public string Chnf { get => chnf; set => chnf = value; }
        public string Dir { get => dir; set => dir = value; }
        public long Num { get => num; set => num = value; }
        public int Lote { get => lote; set => lote = value; }
    }
}
