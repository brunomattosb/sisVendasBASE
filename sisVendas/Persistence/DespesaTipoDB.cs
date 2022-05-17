using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    class DespesaTipoDB
    {
        private Banco db = null;
        public DespesaTipoDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(DespesaTipo))
            {
                DespesaTipo despTipo = (DespesaTipo)Objeto;

                string SQL;

                SQL = @"INSERT INTO DespesaTipo(desp_tipo_nome)
                        VALUES (@desp_tipo_nome)";

                res = db.ExecuteNonQuery(SQL, "@desp_tipo_nome", despTipo.Nome);


            }
            return (res);
        }

        public List<object> Buscar(string filtro)
        {

            DataTable dt = new DataTable();
            List<object> expenseType = new List<object>();


            string SQL = @"SELECT * FROM DespesaTipo WHERE desp_tipo_nome like @filtro order by desp_tipo_nome";
            filtro = "%" + filtro + "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DespesaTipo despTipo = new DespesaTipo();


                    despTipo.Id = Convert.ToInt32(dt.Rows[i]["desp_tipo_id"]);
                    despTipo.Nome = dt.Rows[i]["desp_tipo_nome"].ToString();
                    despTipo.Created_at = Convert.ToDateTime(dt.Rows[i]["desp_tipo_criado_em"].ToString());


                    expenseType.Add(despTipo);
                }
            }
            return (expenseType);

        }
         

        public bool Atualizar(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(DespesaTipo))
            {
                DespesaTipo despTipo = (DespesaTipo)Objeto;

                string SQL = @"UPDATE DespesaTipo SET desp_tipo_nome = @desp_tipo_nome
                            WHERE desp_tipo_id = @desp_tipo_id";

                res = db.ExecuteNonQuery(SQL, "@desp_tipo_nome", despTipo.Nome,
                                                "@desp_tipo_id", despTipo.Id);
            }
            return res;
        }
        public bool Remover(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM DespesaTipo WHERE desp_tipo_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
    }
}
