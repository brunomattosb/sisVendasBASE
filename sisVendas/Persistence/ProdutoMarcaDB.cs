
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sisVendas.Models;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace sisVendas.Persistence
{
    class ProdutoMarcaDB
    {
        private Banco db = null;
        public ProdutoMarcaDB(Banco db)
        {
            this.db = db;
        }
        public bool gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(ProdutoMarca))
            {
                ProdutoMarca prodMarca = (ProdutoMarca)Objeto;

                string SQL;

                SQL = @"INSERT INTO ProdutoMarca(prod_marca_nome)
                        VALUES (@prod_marca_nome)";

                res = db.ExecuteNonQuery(SQL, "@prod_marca_nome", prodMarca.Nome);


            }
            return (res);
        }

        public List<object> buscar(string filtro)
        {

            DataTable dt = new DataTable();
            List<object> ProductBrand = new List<object>();


            string SQL = @"SELECT * FROM ProdutoMarca WHERE prod_marca_nome like @filtro order by prod_marca_nome";
            filtro = "%" + filtro + "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProdutoMarca prodMarca = new ProdutoMarca();

                    prodMarca.Id = Convert.ToInt32(dt.Rows[i]["prod_marca_id"]);
                    prodMarca.Nome = dt.Rows[i]["prod_marca_nome"].ToString();
                    prodMarca.Criado_em = Convert.ToDateTime(dt.Rows[i]["prod_marca_criado_em"].ToString());


                    ProductBrand.Add(prodMarca);
                }
            }
            return (ProductBrand);
        }


        public bool atualizar(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(ProdutoMarca))
            {
                ProdutoMarca marca = (ProdutoMarca)Objeto;

                string SQL = @"UPDATE ProdutoMarca SET prod_marca_nome = @prod_marca_nome
                            WHERE prod_marca_id = @prod_marca_id";

                res = db.ExecuteNonQuery(SQL, "@prod_marca_nome", marca.Nome,
                                                "@prod_marca_id", marca.Id);
            }
            return res;
        }
        public bool remover(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM ProdutoMarca WHERE prod_marca_id = @id";

            res = db.ExecuteNonQuery(SQL, "@id", id);
            
            return res;
        }
    }
}
