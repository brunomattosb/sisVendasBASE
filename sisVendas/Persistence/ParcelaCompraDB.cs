using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    internal class ParcelaCompraDB
    {
        private Banco db = null;
        public ParcelaCompraDB(Banco db)
        {
            this.db = db;
        }

        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(ParcelaCompra))
            {
                ParcelaCompra parcela = (ParcelaCompra)Objeto;

                string SQL;

                SQL = @"INSERT INTO ParcelaCompra (parcela_idCompra, parcela_valor, parcela_tipo,parcela_dataPagamento,parcela_idcaixa, parcela_dataVencimento)
                        values (@parcela_idCompra, @parcela_valor, @parcela_tipo,NULLIF (@parcela_dataPagamento, ''),@parcela_idcaixa, @parcela_dataVencimento)";


                res = db.ExecuteNonQuery(SQL, "@parcela_idCompra", parcela.IdCompra,
                                                "@parcela_valor", parcela.Valor,
                                                "@parcela_idcaixa", parcela.IdCaixa,
                                                "@parcela_tipo", parcela.Tipo_pagamento,
                                                "@parcela_dataPagamento", parcela.DataPagamento,
                                                "@parcela_dataVencimento", parcela.DataVencimento);



            }
            return (res);
        }
        public List<object> buscarParcelasPorIdCaixa(int idCaixa)
        {
            DataTable dt = new DataTable();
            List<object> parcelas = new List<object>();


            string SQL = @"select parcela_id, parcela_idCompra, parcela_valor, parcela_tipo, parcela_dataPagamento, parcela_dataVencimento, parcela_idcaixa, compra_cancelada from ParcelaCompra
    inner join Compra on compra.compra_id = ParcelaCompra.parcela_idCompra
    where parcela_idcaixa = @filtro AND parcela_dataPagamento is not null AND compra_cancelada = 0";

            db.ExecuteQuery(SQL, out dt, "@filtro", idCaixa);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ParcelaCompra parcela = new ParcelaCompra();
                    parcela.Id = Convert.ToInt32(dt.Rows[i]["parcela_id"]);
                    parcela.IdCompra = Convert.ToInt32(dt.Rows[i]["parcela_idCompra"]);
                    parcela.Valor = Convert.ToDouble(dt.Rows[i]["parcela_valor"]);
                    parcela.Tipo_pagamento = Convert.ToChar(dt.Rows[i]["parcela_tipo"]);
                    parcela.DataPagamento = Convert.ToDateTime(dt.Rows[i]["parcela_dataPagamento"].ToString());
                    parcela.IdCaixa = Convert.ToInt32(dt.Rows[i]["parcela_idcaixa"]);


                    parcelas.Add(parcela);
                }
            }
            return (parcelas);

        }
        public bool estornarParcela(int idParcela)
        {

            bool res = false;
            string SQL = @"UPDATE ParcelaCompra SET parcela_dataPagamento = null, parcela_tipo = 'F'
                        WHERE parcela_id = @parcela_id";

            res = db.ExecuteNonQuery(SQL, "@parcela_id", idParcela);

            return res;
        }
        public List<object> buscarParcelasPorIdCompra(int codVenda)
        {
            DataTable dt = new DataTable();
            List<object> parcelas = new List<object>();


            string SQL = @"select * from ParcelaCompra
                                where parcela_idCompra = @filtro";

            db.ExecuteQuery(SQL, out dt, "@filtro", codVenda);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ParcelaCompra parcela = new ParcelaCompra();
                    parcela.Id = Convert.ToInt32(dt.Rows[i]["parcela_id"]);
                    parcela.IdCompra = Convert.ToInt32(dt.Rows[i]["parcela_idCompra"]);
                    parcela.Valor = Convert.ToDouble(dt.Rows[i]["parcela_valor"]);
                    parcela.Tipo_pagamento = Convert.ToChar(dt.Rows[i]["parcela_tipo"]);
                    
                    parcela.DataVencimento = Convert.ToDateTime(dt.Rows[i]["parcela_dataVencimento"].ToString());
                    parcela.IdCaixa = Convert.ToInt32(dt.Rows[i]["parcela_idcaixa"]);

                    if (DateTime.TryParse(dt.Rows[i]["parcela_dataPagamento"].ToString(), out DateTime dtPagamento))
                    {
                        parcela.DataPagamento = dtPagamento;
                    }
                    else
                    {
                        parcela.DataPagamento = null;
                    }

                    parcelas.Add(parcela);
                }
            }
            return (parcelas);

        }
        public List<object> BuscarParcelasAPagar(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> parcelas = new List<object>();


            string SQL = @"select parcela_id, parcela_idCompra,parcela_valor,parcela_tipo,parcela_dataPagamento,parcela_dataVencimento,parcela_idcaixa, compra.compra_cancelada
                                                                                                                from ParcelaCompra
    inner join Compra on compra.compra_id = ParcelaCompra.parcela_idCompra
        where compra.compra_cancelada = 0";

            if (filtro != "")
            {
                SQL = SQL  + " AND "+ filtro;
            }

            db.ExecuteQuery(SQL, out dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ParcelaCompra parcela = new ParcelaCompra();
                    parcela.Id = Convert.ToInt32(dt.Rows[i]["parcela_id"]);
                    parcela.IdCompra = Convert.ToInt32(dt.Rows[i]["parcela_idCompra"]);
                    parcela.Valor = Convert.ToDouble(dt.Rows[i]["parcela_valor"]);
                    parcela.Tipo_pagamento = Convert.ToChar(dt.Rows[i]["parcela_tipo"]);
                    parcela.IdCaixa = Convert.ToInt32(dt.Rows[i]["parcela_idcaixa"]);
                    parcela.DataVencimento = Convert.ToDateTime(dt.Rows[i]["parcela_dataVencimento"].ToString());

                    
                    if(DateTime.TryParse(dt.Rows[i]["parcela_dataPagamento"].ToString(), out DateTime dtPagamento))
                    {
                        parcela.DataPagamento = dtPagamento;
                    }
                    else
                    {
                        parcela.DataPagamento = null;
                    }

                    parcelas.Add(parcela);
                }
            }
            return (parcelas);

        }
        public DataTable buscarParcelasAPagarParaRelatorio(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> parcelas = new List<object>();


            string SQL = @"select compra.compra_criado_em as 'Referência', parcela_valor as 'Valor',parcela_dataPagamento as 'Dt Pagamento', parcela_dataVencimento as 'Dt Vencimento'
                                                                                                                from ParcelaCompra
    inner join Compra on compra.compra_id = ParcelaCompra.parcela_idCompra
        where compra.compra_cancelada = 0";

            if (filtro != "")
            {
                SQL = SQL + " AND " + filtro;
            }

            db.ExecuteQuery(SQL, out dt);

           
            return (dt);

        }
        public bool quitarParcela(int idParcela, char tipoPagamento, int idCaixa)
        {

            bool res = false;
            string SQL = @"UPDATE ParcelaCompra SET parcela_tipo = @parcela_tipo,
                                                    parcela_dataPagamento = @parcela_dataPagamento,
                                                    parcela_idcaixa = @parcela_idcaixa
                        WHERE parcela_id = @parcela_id";

            res = db.ExecuteNonQuery(SQL, "@parcela_tipo", tipoPagamento,
                                            "@parcela_dataPagamento", DateTime.Now,
                                            "@parcela_id", idParcela,
                                            "@parcela_idcaixa", idCaixa);

            return res;
        }
        public bool quitarParcelaParcial(int idParcela, double valorParcela, double valorPago, int idCaixa)
        {

            bool res = false;

            string SQL = @"UPDATE ParcelaCompra SET parcela_idcaixa = @parcela_idcaixa,
                                                    parcela_valor = @parcela_valor
                        WHERE parcela_id = @parcela_id";

            res = db.ExecuteNonQuery(SQL, "@parcela_idcaixa", idCaixa,
                                            "@parcela_valor", valorParcela - valorPago,
                                            "@parcela_id", idParcela);

            return res;
        }
        /*
       
        public bool onerarParcela(int idParcela)
        {

            bool res = false;
            string SQL = @"UPDATE ParcelasVenda SET parcela_status = 'DEVE',
                                                    parcela_idcaixa = 0
                        WHERE parcela_id = @parcela_id";

            res = db.ExecuteNonQuery(SQL, "@parcela_id", idParcela);

            return res;
        }
        
        public DataTable buscarParcelasEmAberto(string filtro)
        {
            DataTable dtParcelas = new DataTable();
            dtParcelas.Columns.Add("id", typeof(int));
            dtParcelas.Columns.Add("idCaixa", typeof(int));
            dtParcelas.Columns.Add("idVenda", typeof(int));
            dtParcelas.Columns.Add("valor", typeof(double));
            dtParcelas.Columns.Add("dataVenda", typeof(DateTime));
            dtParcelas.Columns.Add("dataPagamento", typeof(DateTime));
            dtParcelas.Columns.Add("cpf_cnpj");
            dtParcelas.Columns.Add("nome");
            dtParcelas.Columns.Add("status");


            DataTable dt = new DataTable();

            string SQL = @"select parcela_id, parcela_idcaixa, parcela_idVenda, parcela_valor, parcela_dataPagamento,venda_criado_em, cli_name, cli_cpf_cnpj, parcela_status
                                                                                                            from ParcelasVenda
                            inner join Venda on venda_id = parcela_idVenda
                            inner join Client on Venda.venda_idCliente = Client.cli_id";

            if (filtro.Length > 0)
            {
                SQL = SQL + filtro;
            }
            Console.WriteLine(SQL);

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow line = dtParcelas.NewRow();
                    line["id"] = Convert.ToInt32(dt.Rows[i]["parcela_id"]);
                    line["idCaixa"] = Convert.ToInt32(dt.Rows[i]["parcela_idcaixa"]);
                    line["idVenda"] = Convert.ToInt32(dt.Rows[i]["parcela_idVenda"]);
                    line["valor"] = Convert.ToDouble(dt.Rows[i]["parcela_valor"]);
                    line["dataVenda"] = Convert.ToDateTime(dt.Rows[i]["venda_criado_em"].ToString());
                    line["dataPagamento"] = Convert.ToDateTime(dt.Rows[i]["parcela_dataPagamento"].ToString());
                    line["cpf_cnpj"] = dt.Rows[i]["cli_cpf_cnpj"].ToString();
                    line["nome"] = dt.Rows[i]["cli_name"].ToString();
                    line["status"] = dt.Rows[i]["parcela_status"].ToString();

                    dtParcelas.Rows.Add(line);
                }
            }
            return (dtParcelas);

        }

        public List<object> buscarParcelasPorIdCaixa(int idCaixa)
        {
            DataTable dt = new DataTable();
            List<object> parcelas = new List<object>();


            string SQL = @"select * from ParcelasVenda
                                where parcela_idcaixa = @filtro";

            db.ExecuteQuery(SQL, out dt, "@filtro", idCaixa);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ParcelaVenda parcela = new ParcelaVenda();
                    parcela.Id = Convert.ToInt32(dt.Rows[i]["parcela_id"]);
                    parcela.Cod_venda = Convert.ToInt32(dt.Rows[i]["parcela_idVenda"]);
                    parcela.Valor = Convert.ToDouble(dt.Rows[i]["parcela_valor"]);
                    parcela.Status = dt.Rows[i]["parcela_status"].ToString();
                    parcela.Tipo_pagamento = Convert.ToChar(dt.Rows[i]["parcela_tipo"]);
                    parcela.Data = Convert.ToDateTime(dt.Rows[i]["parcela_dataPagamento"].ToString());
                    parcela.IdCaixa = Convert.ToInt32(dt.Rows[i]["parcela_idcaixa"]);


                    parcelas.Add(parcela);
                }
            }
            return (parcelas);

        }*/
        /*
        public Cliente buscarCpf(string filtro)
        {

            DataTable dtBusca = new DataTable();

            string SQL = @"SELECT * FROM Client WHERE cli_cpf_cnpj = @filtro";

            db.ExecuteQuery(SQL, out dtBusca, "@filtro", filtro);

            Cliente cli = new Cliente();


            if (dtBusca.Rows.Count > 0)
            {

                cli.Id = Convert.ToInt32(dtBusca.Rows[0]["cli_id"]);
                cli.Name = dtBusca.Rows[0]["cli_name"].ToString();
                cli.Fantasy_name = dtBusca.Rows[0]["cli_fantasy_name"].ToString();
                cli.Cpf_cnpj = dtBusca.Rows[0]["cli_cpf_cnpj"].ToString();
                cli.Zip_code = dtBusca.Rows[0]["cli_zip_code"].ToString();
                cli.Address = dtBusca.Rows[0]["cli_addres"].ToString();
                cli.District = dtBusca.Rows[0]["cli_district"].ToString();
                cli.City = dtBusca.Rows[0]["cli_city"].ToString();
                cli.Telephone = dtBusca.Rows[0]["cli_telephone"].ToString();
                cli.Rg_ie = dtBusca.Rows[0]["cli_rg_ie"].ToString();
                cli.Uf = dtBusca.Rows[0]["cli_uf"].ToString();
                cli.Birth_at = Convert.ToDateTime(dtBusca.Rows[0]["cli_birth_at"].ToString());
                cli.Created_at = Convert.ToDateTime(dtBusca.Rows[0]["cli_created_at"].ToString());
                cli.Sex = Convert.ToChar(dtBusca.Rows[0]["cli_sex"].ToString()[0]);
                cli.Balance = Convert.ToDouble(dtBusca.Rows[0]["cli_balance"].ToString());
                cli.Email = dtBusca.Rows[0]["cli_email"].ToString();
                
            }
            else
            {
                return null;
            }
            return (cli);

        }
       

        public bool update(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(Cliente))
            {
                Cliente cli = (Cliente)Objeto;

                string SQL = @"UPDATE Client SET cli_name = @name,
                                            cli_fantasy_name = @fantasy,
                                            cli_zip_code = @cep,
                                            cli_addres = @addres,
                                            cli_district = @district,
                                            cli_city = @city,
                                            cli_telephone = @telephone,
                                            cli_rg_ie = @rg,
                                            cli_uf = @uf,
                                            cli_birth_at = @birth,
                                            cli_sex = @sex,
                                            cli_balance = @balance,
                                            cli_email = @email
                            WHERE cli_id = @id";

                res = db.ExecuteNonQuery(SQL,   "@id", cli.Id,
                                                "@name", cli.Name,
                                                "@fantasy", cli.Fantasy_name,
                                                "@cep", cli.Zip_code,
                                                "@addres", cli.Address,
                                                "@district", cli.District,
                                                "@city", cli.City,
                                                "@telephone", cli.Telephone,
                                                "@rg", cli.Rg_ie,
                                                "@uf", cli.Uf,
                                                "@birth", cli.Birth_at,
                                                "@sex", cli.Sex,
                                                "@balance", cli.Balance,
                                                "@email", cli.Email);


            }
            return res;
        }*/
        public bool removerParcelas(int id)
        {
            bool res = false;
            string SQL = @"DELETE FROM ParcelaVenda WHERE parcela_idVenda = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
    }
}
