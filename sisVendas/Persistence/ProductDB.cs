using DFe.Utils;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
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
        public Produto BuscarProduto(string filtro)
        {
            DataTable dt = new DataTable();

            string SQL = @"select prod_id,prod_codigo_barras,prod_nome,prod_valor, prod_un,prod_complemento,prod_estoque,prod_estoque_min, prod_localizacao,
                prod_ativo,prod_balanca,prod_ncm,prod_cest,prod_origem,prod_grupo_tributacao,prod_situacao_tributaria,prod_aliq_icms,prod_cfop_venda_dentro_estado,
                prod_cfop_venda_fora_estado,prod_cfop_compra_dentro_estado,prod_cfop_compra_fora_estado,prod_criado_em, m.prod_marca_id, m.prod_marca_nome,
                c.prod_categoria_id, c.prod_categoria_nome
                from produto
                inner join ProdutoMarca m on m.prod_marca_id = Produto.prod_id_marca 
                inner join ProdutoCategoria c on c.prod_categoria_id = Produto.prod_id_categoria ";

            if (filtro != "")
                SQL = SQL + filtro;
            db.ExecuteQuery(SQL, out dt);
            Produto prod = new Produto();
            
            if (dt.Rows.Count > 0)
            {
                prod.Id = int.Parse(dt.Rows[0]["prod_id"].ToString());
                prod.Codigo_barras = dt.Rows[0]["prod_codigo_barras"].ToString();
                prod.Nome = dt.Rows[0]["prod_nome"].ToString();
                prod.Valor = double.Parse(dt.Rows[0]["prod_valor"].ToString());
                prod.Un = dt.Rows[0]["prod_un"].ToString();
                prod.Complemento = dt.Rows[0]["prod_complemento"].ToString();
                prod.Estoque = double.Parse(dt.Rows[0]["prod_estoque"].ToString());
                prod.Estoque_min = double.Parse(dt.Rows[0]["prod_estoque_min"].ToString());
                prod.Localizacao = dt.Rows[0]["prod_localizacao"].ToString();
                prod.Ativo = bool.Parse(dt.Rows[0]["prod_ativo"].ToString());
                prod.Balanca = bool.Parse(dt.Rows[0]["prod_balanca"].ToString());
                prod.Ncm = dt.Rows[0]["prod_ncm"].ToString();
                prod.Cest = dt.Rows[0]["prod_cest"].ToString();
                prod.Origem = (OrigemMercadoria)Enum.Parse(typeof(OrigemMercadoria), dt.Rows[0]["prod_origem"].ToString());
                prod.Situacao_tributaria = (Csticms)Enum.Parse(typeof(OrigemMercadoria), dt.Rows[0]["prod_situacao_tributaria"].ToString());
                prod.Grupo_tributacao = (Csosnicms)Enum.Parse(typeof(OrigemMercadoria), dt.Rows[0]["prod_grupo_tributacao"].ToString());                
                prod.Aliq_icms = double.Parse(dt.Rows[0]["prod_aliq_icms"].ToString());
                prod.Cfop_venda_dentro_estado = int.Parse(dt.Rows[0]["prod_cfop_venda_dentro_estado"].ToString());
                prod.Cfop_venda_fora_estado = int.Parse(dt.Rows[0]["prod_cfop_venda_fora_estado"].ToString());
                prod.Cfop_compra_dentro_estado = int.Parse(dt.Rows[0]["prod_cfop_compra_dentro_estado"].ToString());
                prod.Cfop_compra_fora_estado = int.Parse(dt.Rows[0]["prod_cfop_compra_fora_estado"].ToString());
                prod.Criado_em = DateTime.Parse(dt.Rows[0]["prod_criado_em"].ToString());
                prod.Marca = new ProdutoMarca(int.Parse(dt.Rows[0]["prod_marca_id"].ToString()), dt.Rows[0]["prod_marca_nome"].ToString());
                prod.Categoria = new ProdutoCategoria(int.Parse(dt.Rows[0]["prod_categoria_id"].ToString()), dt.Rows[0]["prod_categoria_nome"].ToString());
                prod.Un = dt.Rows[0]["prod_un"].ToString();
                prod.Criado_em = Convert.ToDateTime(dt.Rows[0]["prod_criado_em"].ToString());


            }
            else
            {
                return null;
            }
            return prod;
        }
        
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Produto))
            {
                Produto prod = (Produto)Objeto;

                string SQL;

                SQL = @"INSERT INTO Produto (prod_codigo_barras,prod_nome,prod_valor, prod_un,prod_complemento,prod_estoque,prod_estoque_min, prod_localizacao,
                            prod_ativo,prod_balanca,prod_ncm,prod_cest,prod_origem,prod_grupo_tributacao,prod_situacao_tributaria,prod_aliq_icms,prod_cfop_venda_dentro_estado,
                            prod_cfop_venda_fora_estado,prod_cfop_compra_dentro_estado,prod_cfop_compra_fora_estado, prod_id_marca, prod_id_categoria)
                        values (@prod_codigo_barras,@prod_nome,@prod_valor, @prod_un,@prod_complemento,@prod_estoque,@prod_estoque_min, @prod_localizacao,
                @prod_ativo,@prod_balanca,@prod_ncm,@prod_cest,@prod_origem,@prod_grupo_tributacao,@prod_situacao_tributaria,@prod_aliq_icms,@prod_cfop_venda_dentro_estado,
                @prod_cfop_venda_fora_estado,@prod_cfop_compra_dentro_estado,@prod_cfop_compra_fora_estado, @prod_id_marca, @prod_id_categoria)";

                res = db.ExecuteNonQuery(SQL,"@prod_codigo_barras", prod.Codigo_barras,
                                            "@prod_nome", prod.Nome ,
                                            "@prod_valor", prod.Valor,
                                            "@prod_un", prod.Un,
                                            "@prod_complemento", prod.Complemento,
                                            "@prod_estoque", prod.Estoque,
                                            "@prod_estoque_min", prod.Estoque_min,
                                            "@prod_localizacao", prod.Localizacao,
                                            "@prod_ativo", prod.Ativo,
                                            "@prod_balanca", prod.Balanca,
                                            "@prod_ncm", prod.Ncm,
                                            "@prod_cest", prod.Cest,
                                            "@prod_origem", (int)prod.Origem,
                                            "@prod_grupo_tributacao", (int)prod.Grupo_tributacao,
                                            "@prod_situacao_tributaria", (int)prod.Situacao_tributaria,
                                            "@prod_aliq_icms", prod.Aliq_icms,
                                            "@prod_cfop_venda_dentro_estado", prod.Cfop_venda_dentro_estado,
                                            "@prod_cfop_venda_fora_estado", prod.Cfop_venda_fora_estado,
                                            "@prod_cfop_compra_dentro_estado", prod.Cfop_compra_dentro_estado,
                                            "@prod_cfop_compra_fora_estado", prod.Cfop_compra_fora_estado,
                                            "@prod_id_marca", prod.Marca.Id,
                                            "@prod_id_categoria", prod.Categoria.Id);
            }
            return (res);
        }
        public DataTable BuscarParaDGV(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> produtos = new List<object>();


            string SQL = @"select prod_codigo_barras, prod_id, prod_nome, prod_estoque, prod_un, prod_valor, prod_marca_nome, prod_categoria_nome from Produto
                        inner join ProdutoMarca m on m.prod_marca_id = Produto.prod_id_marca 
                        inner join ProdutoCategoria c on c.prod_categoria_id = Produto.prod_id_categoria
                        WHERE Produto.prod_nome like @filtro order by prod_nome";
            filtro = "%" + filtro + "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            
            return (dt);

        }
        /*
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
        public DataTable buscarParaPromocao()
        {
            DataTable dt = new DataTable();
            
            string SQL = @"select Produto.prod_id, Produto.prod_estoque, Produto.prod_nome, Produto.prod_valor from Produto  
right join (
SELECT prod_id FROM Produto WHERE prod_id not in (
						select ItensPromocao.iten_idProduto from ItensPromocao
						inner join Promocao on Promocao.promo_id = ItensPromocao.iten_idPromocao
						where GETDATE() BETWEEN promo_inicio and promo_fim)) as tabela_itens_sem_promocao
						on tabela_itens_sem_promocao.prod_id = Produto.prod_id
order by prod_nome";
            

            db.ExecuteQuery(SQL, out dt);

            
            return (dt);

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
				right join Produto on Produto.prod_id = tab_ultima_data.iten_idProduto";
;

            db.ExecuteQuery(SQL, out dt);

            
            return (dt);

        }

        public Produto BuscarPorCod(string filtro)
        {
            DataTable dt = new DataTable();

            string SQL = @"SELECT prod_id, prod_nome, prod_complemento, prod_estoque, prod_un, prod_marca,prod_categoria, prod_valor, prod_criado_em, iten_valor as valor_com_desconto FROM Produto 
left join ( select iten_valor,iten_idProduto  from Promocao
				inner join ItensPromocao on ItensPromocao.iten_idPromocao = Promocao.promo_id
				where GETDATE() BETWEEN Promocao.promo_inicio and Promocao.promo_fim) as tabela_valores_promocao on tabela_valores_promocao.iten_idProduto = Produto.prod_id

WHERE prod_id like @filtro";

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
                
                prod.Un = dt.Rows[0]["prod_un"].ToString();
                prod.Criado_em = Convert.ToDateTime(dt.Rows[0]["prod_criado_em"].ToString());

                double.TryParse(dt.Rows[0]["valor_com_desconto"].ToString(), out double valor);
                if(valor > 0)
                {
                    prod.Valor = valor;
                }
                else
                {
                    prod.Valor = Convert.ToDouble(dt.Rows[0]["prod_valor"].ToString());
                }
            }
            else
            {
                return null;
            }
            return (prod);
        }

        
        
        */
        public bool incrementarEstoque(string idProd, double quantidade)
        {
            bool res = false;
            string SQL = @"update produto set prod_estoque = produto.prod_estoque + @quantidade
                        where prod_id = @idProd;";
            res = db.ExecuteNonQuery(SQL, "@idProd", idProd, "@quantidade", quantidade);
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
        public bool Atualizar(object Objeto)
        {
            
            bool res = false;
            if (Objeto.GetType() == typeof(Produto))
            {
                Produto prod = (Produto)Objeto;
                string SQL = @"UPDATE Produto SET prod_codigo_barras = @prod_codigo_barras,
                                                    prod_nome = @prod_nome,
                                                    prod_valor = @prod_valor,
                                                    prod_un = @prod_un,
                                                    prod_complemento = @prod_complemento,
                                                    prod_estoque = @prod_estoque,
                                                    prod_estoque_min = @prod_estoque_min,
                                                    prod_localizacao = @prod_localizacao,
                                                    prod_ativo = @prod_ativo,
                                                    prod_balanca = @prod_balanca,
                                                    prod_ncm = @prod_ncm,
                                                    prod_cest = @prod_cest,
                                                    prod_origem = @prod_origem,
                                                    prod_grupo_tributacao = @prod_grupo_tributacao,
                                                    prod_situacao_tributaria = @prod_situacao_tributaria,
                                                    prod_aliq_icms = @prod_aliq_icms,
                                                    prod_cfop_venda_dentro_estado = @prod_cfop_venda_dentro_estado,
                                                    prod_cfop_venda_fora_estado = @prod_cfop_venda_fora_estado,
                                                    prod_cfop_compra_dentro_estado = @prod_cfop_compra_dentro_estado,
                                                    prod_cfop_compra_fora_estado = @prod_cfop_compra_fora_estado,
                                                    prod_id_marca = @prod_id_marca,
                                                    prod_id_categoria = @prod_id_categoria
                                            WHERE prod_id = @prod_id";

                res = db.ExecuteNonQuery(SQL, "@prod_id", prod.Id,
                                            "@prod_codigo_barras", prod.Codigo_barras,
                                            "@prod_nome", prod.Nome,
                                            "@prod_valor", prod.Valor,
                                            "@prod_un", prod.Un,
                                            "@prod_complemento", prod.Complemento,
                                            "@prod_estoque", prod.Estoque,
                                            "@prod_estoque_min", prod.Estoque_min,
                                            "@prod_localizacao", prod.Localizacao,
                                            "@prod_ativo", prod.Ativo,
                                            "@prod_balanca", prod.Balanca,
                                            "@prod_ncm", prod.Ncm,
                                            "@prod_cest", prod.Cest,
                                            "@prod_origem", (int)prod.Origem,
                                            "@prod_grupo_tributacao", (int)prod.Grupo_tributacao,
                                            "@prod_situacao_tributaria", (int)prod.Situacao_tributaria,
                                            "@prod_aliq_icms", prod.Aliq_icms,
                                            "@prod_cfop_venda_dentro_estado", prod.Cfop_venda_dentro_estado,
                                            "@prod_cfop_venda_fora_estado", prod.Cfop_venda_fora_estado,
                                            "@prod_cfop_compra_dentro_estado", prod.Cfop_compra_dentro_estado,
                                            "@prod_cfop_compra_fora_estado", prod.Cfop_compra_fora_estado,
                                            "@prod_id_marca", prod.Marca.Id,
                                            "@prod_id_categoria", prod.Categoria.Id);

            }
            return res;
        }
        public bool Remover(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Produto WHERE prod_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
    }

}
