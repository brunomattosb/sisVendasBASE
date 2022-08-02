using NFe.Classes.Servicos.Recepcao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    class NFeDB
    {
        private Banco db = null;
        public NFeDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Models.NFe))
            {
                Models.NFe nf = (Models.NFe)Objeto;

                string SQL;

                SQL = @"INSERT INTO NF (nf_chnf, nf_nprot, nf_cstat, nf_xmotivo, nf_nrec, nf_xml,nf_dir, nf_num, nf_lote)
                        values (@nf_chnf, @nf_nprot, @nf_cstat, @nf_xmotivo, @nf_nrec, convert(varbinary, @nf_xml),@nf_dir, @nf_num, @nf_lote)";

                res = db.ExecuteNonQuery(SQL, "nf_nprot", nf.Nprot,
                                                "@nf_cstat", nf.Cstat,
                                                "@nf_xmotivo", nf.Xmotivo,
                                                "@nf_nrec", nf.Nrec,
                                                "@nf_chnf", nf.Chnf,
                                                "@nf_dir", nf.Dir,
                                                "@nf_num", nf.Num,
                                                "@nf_lote", nf.Lote,
                                                "@nf_xml", nf.Xml);
            }
            return (res);
        }
        public string buscarNumeroUltimaNFCe()
        {
            bool res = false;
            DataTable dt = new DataTable();
            string SQL;

            SQL = @"select max(nf_num) as nf_num from NF";
            db.ExecuteQuery(SQL, out dt);

            var retorno = dt.Rows[0]["nf_num"].ToString();
            return retorno;
        }

    }
}
