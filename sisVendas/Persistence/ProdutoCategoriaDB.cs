using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    class ProdutoCategoriaDB
    {
        private Banco db = null;
        public ProdutoCategoriaDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(ProdutoCategoria))
            {
                ProdutoCategoria prodCat = (ProdutoCategoria)Objeto;

                string SQL;

                SQL = @"INSERT INTO ProdutoCategoria(prod_categoria_nome)
                        VALUES (@prod_categoria_nome)";

                res = db.ExecuteNonQuery(SQL, "@prod_categoria_nome", prodCat.Nome);


            }
            return (res);
        }

        public List<object> buscar(string filtro)
        {

            DataTable dt = new DataTable();
            List<object> prodCategoria = new List<object>();


            string SQL = @"SELECT * FROM ProdutoCategoria WHERE prod_categoria_nome like @filtro order by prod_categoria_nome";
            filtro = "%" + filtro + "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProdutoCategoria cat = new ProdutoCategoria();


                    cat.Id = Convert.ToInt32(dt.Rows[i]["prod_categoria_id"]);
                    cat.Nome = dt.Rows[i]["prod_categoria_nome"].ToString();
                    cat.Criado_em = Convert.ToDateTime(dt.Rows[i]["prod_categoria_criado_em"].ToString());


                    prodCategoria.Add(cat);
                }
            }
            return (prodCategoria);

        }


        public bool Atualizar(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(ProdutoCategoria))
            {
                ProdutoCategoria exp = (ProdutoCategoria)Objeto;

                string SQL = @"UPDATE ProdutoCategoria SET prod_categoria_nome = @prod_categoria_nome
                            WHERE prod_categoria_id = @prod_categoria_id";

                res = db.ExecuteNonQuery(SQL, "@prod_categoria_nome", exp.Nome,
                                                "@prod_categoria_id", exp.Id);
            }
            return res;
        }
        public bool remover(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM ProdutoCategoria WHERE prod_categoria_id= @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
    }
}
