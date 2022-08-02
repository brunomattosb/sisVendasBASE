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

                SQL = @"INSERT INTO ParcelaVenda (parcela_idVenda, parcela_valor, parcela_dataPagamento, parcela_tipo,parcela_idcaixa,parcela_dataVencimento)
                        values (@parcela_idVenda, @parcela_valor, NULLIF (@parcela_dataPagamento, ''), @parcela_tipo, @parcela_idcaixa,@parcela_dataVencimento)";


                res = db.ExecuteNonQuery(SQL, "@parcela_idVenda", parcelaVenda.Cod_venda,
                                                "@parcela_valor", parcelaVenda.Valor,
                                                "@parcela_idcaixa", parcelaVenda.IdCaixa,
                                                "@parcela_tipo", parcelaVenda.Tipo_pagamento,
                                                "@parcela_dataPagamento", parcelaVenda.DataPagamento,
                                                "@parcela_dataVencimento", parcelaVenda.DataVencimento);
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
                    parcela.Tipo_pagamento = Convert.ToChar(dt.Rows[i]["parcela_tipo"]);
                    parcela.DataVencimento = Convert.ToDateTime(dt.Rows[i]["parcela_dataVencimento"].ToString());
                    parcela.IdCaixa = Convert.ToInt32(dt.Rows[i]["parcela_idcaixa"]);
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
        public bool quitarParcela(int idParcela, char tipoPagamento, int idCaixa)
        {

            bool res = false;
            string SQL = @"UPDATE ParcelaVenda SET parcela_tipo = @tipoPagamento,
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
            string SQL = @"UPDATE ParcelaVenda SET parcela_dataPagamento = null, parcela_tipo = 'F'
                        WHERE parcela_id = @parcela_id";

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
            dtParcelas.Columns.Add("parcela_id", typeof(int));
            dtParcelas.Columns.Add("parcela_idcaixa", typeof(int));
            dtParcelas.Columns.Add("parcela_idVenda", typeof(int));
            dtParcelas.Columns.Add("parcela_valor", typeof(double));
            dtParcelas.Columns.Add("parcela_dataPagamento", typeof(DateTime));
            dtParcelas.Columns.Add("venda_criado_em", typeof(DateTime));
            dtParcelas.Columns.Add("cli_nome");
            dtParcelas.Columns.Add("cli_cpf_cnpj");
            dtParcelas.Columns.Add("venda_cancelada", typeof(int));
            dtParcelas.Columns.Add("parcela_dataVencimento", typeof(DateTime));
            dtParcelas.Columns.Add("parcela_tipo");
            

            DataTable dt = new DataTable();

            string SQL = @"select parcela_id, parcela_idcaixa, parcela_idVenda, parcela_valor, parcela_dataPagamento,venda_criado_em,
                                                                                        cli_nome, cli_cpf_cnpj, venda_cancelada, parcela_dataVencimento, parcela_tipo
                                                                                                            from ParcelaVenda
                            inner join Venda on venda_id = parcela_idVenda
                            left join Cliente on Venda.venda_idCliente = Cliente.cli_id where venda_cancelada = 0";

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
                    line["parcela_id"] = Convert.ToInt32(dt.Rows[i]["parcela_id"]);
                    line["parcela_idcaixa"] = Convert.ToInt32(dt.Rows[i]["parcela_idcaixa"]);
                    line["parcela_idVenda"] = Convert.ToInt32(dt.Rows[i]["parcela_idVenda"]);
                    line["parcela_valor"] = Convert.ToDouble(dt.Rows[i]["parcela_valor"]);
                    
                    line["venda_criado_em"] = Convert.ToDateTime(dt.Rows[i]["venda_criado_em"].ToString());
                    line["cli_nome"] = dt.Rows[i]["cli_nome"].ToString();
                    line["cli_cpf_cnpj"] = dt.Rows[i]["cli_cpf_cnpj"].ToString();
                    line["venda_cancelada"] = Convert.ToInt32(dt.Rows[i]["venda_cancelada"]);
                    line["parcela_dataVencimento"] = Convert.ToDateTime(dt.Rows[i]["parcela_dataVencimento"].ToString());
                    

                    char parcelaTipo = char.Parse(dt.Rows[i]["parcela_tipo"].ToString());
                    if (parcelaTipo == 'D')
                    {
                        line["parcela_tipo"] = "Débito";
                    }
                    else if(parcelaTipo == 'C')
                    {
                        line["parcela_tipo"] = "Crédito";
                    }
                    else if(parcelaTipo == 'M')
                    {
                        line["parcela_tipo"] = "Dinheiro";
                    }else
                    if (parcelaTipo == 'S')
                    {
                        line["parcela_tipo"] = "Saldo";
                    }

                    if ( DateTime.TryParse(dt.Rows[i]["parcela_dataPagamento"].ToString(), out DateTime dtVenda))
                    {

                        line["parcela_dataPagamento"] = dtVenda;
                    }
                    else
                    {

                        line["parcela_dataPagamento"] = DBNull.Value;
                    }

                    dtParcelas.Rows.Add(line);
                }
            }
            return (dtParcelas);

        }
        public DataTable buscarParcelasFormulario(string filtro)
        {

            DataTable dt = new DataTable();

            string SQL = @"
select cli_nome as 'Ciente', cli_cpf_cnpj as 'CPF/CNPJ',
    parcela_valor as 'Valor',  venda_criado_em as 'Dt Venda',parcela_dataPagamento as 'Pagamento',
    parcela_dataVencimento as 'Vencimento'
                                                                    from ParcelaVenda
    inner join Venda on venda_id = parcela_idVenda
    left join Cliente on Venda.venda_idCliente = Cliente.cli_id where venda_cancelada = 0";

            if (filtro.Length > 0)
            {
                SQL = SQL + " AND " + filtro;
            }
            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);


            return (dt);

        }
        public List<object> BuscarParcelas(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> parcelas = new List<object>();
            string SQL = @"select parcela_id, parcela_idVenda, parcela_valor, parcela_tipo, parcela_dataPagamento, parcela_dataVencimento, parcela_idcaixa, venda_cancelada from ParcelaVenda
                            inner join venda on venda.venda_id = parcelaVenda.parcela_idVenda " + filtro;

            db.ExecuteQuery(SQL, out dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ParcelaVenda parcela = new ParcelaVenda();
                    parcela.Id = Convert.ToInt32(dt.Rows[i]["parcela_id"]);
                    parcela.Cod_venda = Convert.ToInt32(dt.Rows[i]["parcela_idVenda"]);
                    parcela.Valor = Convert.ToDouble(dt.Rows[i]["parcela_valor"]);
                    parcela.Tipo_pagamento = Convert.ToChar(dt.Rows[i]["parcela_tipo"]);
                    parcela.DataPagamento = Convert.ToDateTime(dt.Rows[i]["parcela_dataPagamento"].ToString());
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
