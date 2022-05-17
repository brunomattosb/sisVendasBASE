using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    internal class CompraDB
    {
        private Banco db = null;
        public CompraDB(Banco db)
        {
            this.db = db;
        }
        
        public int Gravar(object Objeto)
        {
            bool res;
            int retorno = 0;

            if (Objeto.GetType() == typeof(Compra))
            {
                Compra compra = (Compra)Objeto;

                string SQL;

                SQL = @"INSERT INTO Compra (compra_idFornecedor, compra_desconto, compra_chave, compra_data, compra_idCaixa)
                        values (@compra_idFornecedor, @compra_desconto, @compra_chave, @compra_data, @compra_idCaixa)";

                res = db.ExecuteNonQuery(SQL, "@compra_idFornecedor", compra.Id_fornecedor,
                                                    "@compra_desconto", compra.Desconto,
                                                    "@compra_chave", compra.Chave,
                                                    "@compra_data", compra.Data,
                                                    "@compra_idCaixa", compra.Id_caixa);
                if (res)
                {
                    retorno = db.GetIdentity();
                }

            }
            return (retorno);
        }
        
        public DataTable buscar(string filtro)
        {
            DataTable dttCompra = new DataTable();

            dttCompra.Columns.Add("id", typeof(int));
            dttCompra.Columns.Add("desconto", typeof(double));
            dttCompra.Columns.Add("cpf_cnpj");
            dttCompra.Columns.Add("total", typeof(double));
            dttCompra.Columns.Add("criado_em", typeof(DateTime));
            dttCompra.Columns.Add("venda_cancelada", typeof(bool));
            dttCompra.Columns.Add("nome");
            dttCompra.Columns.Add("idCaixa", typeof(int));

            string SQL = @"select * from (      
    select compra_id, compra_desconto,compra_desconto + soma as total_compra, compra_criado_em, forn_nome, forn_cpf_cnpj, compra_cancelada, compra_idCaixa
                                                                                                            from Compra 
    left join Fornecedor on Compra.compra_idFornecedor = Fornecedor.forn_id
    inner join (
                    select parcela_idCompra, sum(parcela_valor) as soma from ParcelaCompra 
                                                    group by parcela_idCompra) as parcelas 
				    on compra.compra_id = parcela_idCompra
) as compras ";

            Console.WriteLine(SQL);
            if (filtro != "")
            {
                SQL = SQL + "where " + filtro;
                Console.WriteLine(SQL);
            }

            DataTable dt = new DataTable();

            db.ExecuteQuery(SQL, out dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow linha = dttCompra.NewRow();

                    linha["id"] = Convert.ToInt32(dt.Rows[i]["compra_id"]);
                    linha["desconto"] = Convert.ToDouble(dt.Rows[i]["compra_desconto"].ToString());
                    linha["cpf_cnpj"] = dt.Rows[i]["forn_cpf_cnpj"].ToString();
                    linha["total"] = Convert.ToDouble(dt.Rows[i]["total_compra"].ToString());
                    linha["nome"] = dt.Rows[i]["forn_nome"].ToString();
                    linha["criado_em"] = Convert.ToDateTime(dt.Rows[i]["compra_criado_em"].ToString());
                    linha["venda_cancelada"] = Convert.ToBoolean(dt.Rows[i]["compra_cancelada"].ToString());
                    linha["idCaixa"] = Convert.ToInt32(dt.Rows[i]["compra_idCaixa"]);

                    dttCompra.Rows.Add(linha);

                }
            }
            return (dttCompra);

        }
        public bool remover(int id)
        {
            bool res = false;
            string SQL = @"update compra set compra_cancelada = 1 WHERE compra_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
        public bool restabelecer(int id)
        {
            bool res = false;
            string SQL = @"update compra set compra_cancelada = 0 WHERE compra_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
        /*
        public bool remover(int id)
        {
            bool res = false;
            string SQL = @"update venda set venda_cancelada = 1 WHERE venda_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
        public bool restabelecer(int id)
        {
            bool res = false;
            string SQL = @"update venda set venda_cancelada = 0 WHERE venda_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
        */
        public Compra buscarCompraPorCod(int idCompra)
        {
            DataTable dt = new DataTable();

            string SQL = @"SELECT * FROM Compra WHERE compra_id = @idCompra";

            db.ExecuteQuery(SQL, out dt, "@idCompra", idCompra);
            Compra compra = new Compra();

            if (dt.Rows.Count > 0)
            {
                compra.Id = Convert.ToInt32(dt.Rows[0]["compra_id"]);
                compra.Id_fornecedor = Convert.ToInt32(dt.Rows[0]["compra_idFornecedor"].ToString());
                compra.Desconto = Convert.ToDouble(dt.Rows[0]["compra_desconto"].ToString());
                compra.Chave = dt.Rows[0]["compra_chave"].ToString();
                compra.Data = Convert.ToDateTime(dt.Rows[0]["compra_data"].ToString());
                compra.Created_at = Convert.ToDateTime(dt.Rows[0]["compra_criado_em"].ToString());
                compra.Cancelada = Convert.ToBoolean(dt.Rows[0]["compra_cancelada"].ToString());
                compra.Id_caixa = Convert.ToInt32(dt.Rows[0]["compra_idCaixa"]);
            }
            else
            {
                return null;
            }
            return (compra);
        }
    }
}
