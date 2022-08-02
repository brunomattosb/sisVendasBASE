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
    class TransacaoCaixaDB
    {
        private Banco db = null;
        public TransacaoCaixaDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(TransacaoCaixa))
            {
                TransacaoCaixa transacao = (TransacaoCaixa)Objeto;

                string SQL;

                SQL = @"INSERT INTO TransacaoCaixa (transacao_idcaixa, transacao_tipo, transacao_descricao, transacao_valor)
                        values (@transacao_idcaixa, @transacao_tipo, @transacao_descricao, @transacao_valor)";


                res = db.ExecuteNonQuery(SQL, "@transacao_idcaixa", transacao.IdCaixa,
                                                "@transacao_tipo", transacao.Tipo,
                                                "@transacao_descricao", transacao.Descricao,
                                                "@transacao_valor", transacao.Valor
                                                );



            }
            return (res);
        }
        public List<object> BuscarTransacoes(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> transacoes = new List<object>();


            string SQL = @"SELECT transacao_criado_em,transacao_id,transacao_idcaixa,transacao_tipo,
                                    transacao_descricao,transacao_valor FROM TransacaoCaixa " + filtro;

            db.ExecuteQuery(SQL, out dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TransacaoCaixa transacao = new TransacaoCaixa();


                    transacao.Id = Convert.ToInt32(dt.Rows[i]["transacao_id"]);
                    transacao.IdCaixa = Convert.ToInt32(dt.Rows[i]["transacao_idcaixa"]);
                    transacao.Hora = Convert.ToDateTime(dt.Rows[i]["transacao_criado_em"].ToString());
                    transacao.Tipo = char.Parse(dt.Rows[i]["transacao_tipo"].ToString());
                    transacao.Valor = Convert.ToDouble(dt.Rows[i]["transacao_valor"].ToString());
                    transacao.Descricao = dt.Rows[i]["transacao_descricao"].ToString();



                    transacoes.Add(transacao);
                }
            }
            return (transacoes);

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
        public bool remove(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Client WHERE cli_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
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
    }
}
