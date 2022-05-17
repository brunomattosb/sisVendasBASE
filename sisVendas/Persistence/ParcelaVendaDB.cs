using sisVendas.Models;
using sisVendas.Models.Venda;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Persistence
{
    class ParcelaVendaDB
    {
        private Banco db = null;
        public ParcelaVendaDB(Banco db)
        {
            this.db = db;
        }

        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(ParcelaVenda))
            {
                ParcelaVenda parcelaVenda = (ParcelaVenda)Objeto;

                string SQL;

                SQL = @"INSERT INTO ParcelaVenda (parcela_idVenda, parcela_valor, parcela_status, parcela_tipo,parcela_dataPagamento,parcela_idcaixa)
                        values (@parcela_idVenda, @parcela_valor, @parcela_status, @parcela_tipo, @parcela_dataPagamento, @parcela_idcaixa)";


                res = db.ExecuteNonQuery(SQL, "@parcela_idVenda", parcelaVenda.Cod_venda,
                                                "@parcela_valor", parcelaVenda.Valor,
                                                "@parcela_status", parcelaVenda.Status,
                                                "@parcela_idcaixa", parcelaVenda.IdCaixa,
                                                "@parcela_tipo", parcelaVenda.Tipo_pagamento,
                                                "@parcela_dataPagamento", parcelaVenda.Data);



            }
            return (res);
        }
        public List<object> buscarParcelasPorVenda(int codVenda)
        {
            DataTable dt = new DataTable();
            List<object> parcelas = new List<object>();


            string SQL = @"select * from ParcelaVenda
                                where parcela_idVenda = @filtro";

            db.ExecuteQuery(SQL, out dt, "@filtro", codVenda);

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

        }
        public bool quitarParcela(int idParcela, char tipoPagamento, int idCaixa)
        {

            bool res = false;
            string SQL = @"UPDATE ParcelaVenda SET parcela_status = 'PAGO',
                                                    parcela_tipo = @tipoPagamento,
                                                    parcela_dataPagamento = @parcela_dataPagamento,
                                                    parcela_idcaixa = @parcela_idcaixa
                        WHERE parcela_id = @parcela_id";

            res = db.ExecuteNonQuery(SQL, "@tipoPagamento", tipoPagamento,
                                            "@parcela_dataPagamento", DateTime.Now,
                                            "@parcela_id", idParcela,
                                            "@parcela_idcaixa", idCaixa);

            return res;
        }
        public bool onerarParcela(int idParcela)
        {

            bool res = false;
            string SQL = @"UPDATE ParcelaVenda SET parcela_status = 'DEVE'
                        WHERE parcela_id = @parcela_id";

            MessageBox.Show("IDDDD" + idParcela);
            res = db.ExecuteNonQuery(SQL,"@parcela_id", idParcela);

            return res;
        }
        public bool quitarParcelaParcial(int idParcela, double valorParcela, double valorPago, int idCaixa)
        {

            bool res = false;

            string SQL = @"UPDATE ParcelaVenda SET parcela_idcaixa = @parcela_idcaixa,
                                                    parcela_valor = @parcela_valor
                        WHERE parcela_id = @parcela_id";

            res = db.ExecuteNonQuery(SQL, "@parcela_idcaixa", idCaixa,
                                            "@parcela_valor", valorParcela - valorPago,
                                            "@parcela_id", idParcela);

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

            string SQL = @"select parcela_id, parcela_idcaixa, parcela_idVenda, parcela_valor, parcela_dataPagamento,venda_criado_em, cli_nome, cli_cpf_cnpj, parcela_status, venda_cancelada
                                                                                                            from ParcelaVenda
                            inner join Venda on venda_id = parcela_idVenda
                            inner join Cliente on Venda.venda_idCliente = Cliente.cli_id where venda_cancelada = 0";

            if(filtro.Length > 0)
            {
                SQL = SQL +" AND " +filtro;
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
                    line["nome"] = dt.Rows[i]["cli_nome"].ToString();
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


            string SQL = @"select * from ParcelaVenda
                                where parcela_idcaixa = @filtro AND parcela_status = 'PAGO'";

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

        }
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
