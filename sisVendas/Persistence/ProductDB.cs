using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Persistence
{
    class ProductDB
    {
        private Banco db = null;
        public ProductDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Produto))
            {
                Produto prod = (Produto)Objeto;

                string SQL;

                SQL = @"INSERT INTO Produto (prod_id,prod_nome,prod_complemento,prod_estoque,prod_categoria,prod_marca,prod_valor, prod_un)
                        values (@prod_id,@prod_nome,@prod_complemento,@prod_estoque,@prod_categoria,@prod_marca,@prod_valor,@prod_un)";

                res = db.ExecuteNonQuery(SQL, "@prod_nome", prod.Nome,
                                                "@prod_id", prod.Id,
                                                "@prod_un", prod.Un,
                                                "@prod_complemento", prod.Descricao,
                                                "@prod_estoque", prod.Estoque,
                                                "@prod_categoria", prod.Prod_Categoria,
                                                "@prod_marca", prod.Prod_Marca,
                                                "@prod_valor", prod.Valor);
            }
            return (res);
        }
        public List<object> Buscar(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> produtos = new List<object>();


            string SQL = @"SELECT * FROM Produto WHERE prod_nome like @filtro order by prod_nome";
            filtro = "%" + filtro + "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Produto prod = new Produto();


                    prod.Id = dt.Rows[i]["prod_id"].ToString();
                    prod.Nome = dt.Rows[i]["prod_nome"].ToString();
                    prod.Descricao = dt.Rows[i]["prod_complemento"].ToString();
                    prod.Estoque = Convert.ToInt32(dt.Rows[i]["prod_estoque"]);
                    prod.Prod_Categoria = Convert.ToInt32(dt.Rows[i]["prod_categoria"]);
                    prod.Prod_Marca = Convert.ToInt32(dt.Rows[i]["prod_marca"]);
                    prod.Valor = Convert.ToDouble(dt.Rows[i]["prod_valor"].ToString());
                    prod.Un = dt.Rows[i]["prod_un"].ToString();
                    prod.Criado_em = Convert.ToDateTime(dt.Rows[i]["prod_criado_em"].ToString());

                    produtos.Add(prod);
                }
            }
            return (produtos);

        }
        public DataTable buscarParaRelatorio()
        {
            DataTable dt = new DataTable();
            List<object> produtos = new List<object>();


            string SQL = @"select prod_nome as 'Nome', prod_estoque as 'Estoque', prod_un as 'UN', prod_valor as 'V. Venda',
									 valor_base as 'V. Base' , valor_base * prod_estoque as 'Total Base'
				from (	select ItenCompra.iten_idProduto,max (compra.compra_data) as 'Data' from ItenCompra
					inner join Compra on compra.compra_id = ItenCompra.iten_idCompra
					group by ItenCompra.iten_idProduto
				) as tab_ultima_data
				inner join (
							select compra_data, iten_valor as valor_base, ItenCompra.iten_idProduto from ItenCompra
								inner join Compra on Compra.compra_id = ItenCompra.iten_idCompra
				) as tab_ultimo_valor on tab_ultimo_valor.compra_data = tab_ultima_data.Data AND tab_ultimo_valor.iten_idProduto = tab_ultima_data.iten_idProduto
				inner join Produto on Produto.prod_id = tab_ultima_data.iten_idProduto";
;

            db.ExecuteQuery(SQL, out dt);

            
            return (dt);

        }

        public Produto BuscarPorCod(string filtro)
        {
            DataTable dt = new DataTable();

            string SQL = @"SELECT * FROM Produto WHERE prod_id like @filtro";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);
            Produto prod = new Produto();

            if (dt.Rows.Count > 0)
            {
                prod.Id = dt.Rows[0]["prod_id"].ToString();
                prod.Nome = dt.Rows[0]["prod_nome"].ToString();
                prod.Descricao = dt.Rows[0]["prod_complemento"].ToString();
                prod.Estoque = Convert.ToInt32(dt.Rows[0]["prod_estoque"]);
                prod.Prod_Categoria = Convert.ToInt32(dt.Rows[0]["prod_categoria"]);
                prod.Prod_Marca = Convert.ToInt32(dt.Rows[0]["prod_marca"]);
                prod.Valor = Convert.ToDouble(dt.Rows[0]["prod_valor"].ToString());
                prod.Un = dt.Rows[0]["prod_un"].ToString();
                prod.Criado_em = Convert.ToDateTime(dt.Rows[0]["prod_criado_em"].ToString());
            }
            else
            {
                return null;
            }
            return (prod);
        }

        public bool Remover(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Produto WHERE prod_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
        
        public bool subtraitEstoque(string idProd, double quantidade)
        {
            bool res = false;
            string SQL = @"update produto set prod_estoque = produto.prod_estoque - @quantidade
                        where prod_id = @idProd;";
            res = db.ExecuteNonQuery(SQL, "@idProd", idProd, "@quantidade", quantidade);
            return res;
        }
        public bool incrementarEstoque(string idProd, double quantidade)
        {
            bool res = false;
            string SQL = @"update produto set prod_estoque = produto.prod_estoque + @quantidade
                        where prod_id = @idProd;";
            res = db.ExecuteNonQuery(SQL, "@idProd", idProd, "@quantidade", quantidade);
            return res;
        }

        public bool Atualizar(object Objeto)
        {
            
            bool res = false;
            if (Objeto.GetType() == typeof(Produto))
            {
                Produto prod = (Produto)Objeto;
                string SQL = @"UPDATE Produto SET prod_nome = @prod_nome,
                                            prod_complemento = @prod_complemento,
                                            prod_estoque = @prod_estoque,
                                            prod_categoria = @prod_categoria,
                                            prod_marca = @prod_marca,
                                            prod_valor = @prod_valor,
                                            prod_un = @prod_un
                            WHERE prod_id = @id";

                res = db.ExecuteNonQuery(SQL, "@id", prod.Id,
                                                "@prod_nome", prod.Nome,
                                                "@prod_un", prod.Un,
                                                "@prod_complemento", prod.Descricao,
                                                "@prod_estoque", prod.Estoque,
                                                "@prod_categoria", prod.Prod_Categoria,
                                                "@prod_marca", prod.Prod_Marca,
                                                "@prod_valor", prod.Valor);


            }
            return res;
        }
    }

}
