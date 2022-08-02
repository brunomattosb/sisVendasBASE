using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    class MunicipioDB
    {
        private Banco db = null;
        public MunicipioDB(Banco db)
        {
            this.db = db;
        }

        public List<object> buscar(int codigo)
        {

            DataTable dt = new DataTable();
            List<object> lMunicipio = new List<object>();


            string SQL = @"SELECT muni_nome, muni_cod FROM Municipio WHERE muni_cod_uf = @codigo order by muni_nome";

            db.ExecuteQuery(SQL, out dt, "@codigo", codigo);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Municipio muni = new Municipio();


                    muni.Cod = Convert.ToInt32(dt.Rows[i]["muni_cod"]);
                    muni.Nome = dt.Rows[i]["muni_nome"].ToString();


                    lMunicipio.Add(muni);
                }
            }
            return (lMunicipio);

        }
    }
}
