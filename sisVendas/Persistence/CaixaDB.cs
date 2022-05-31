using sisVendas.Models;
using System;
using System.Data;

namespace sisVendas.Persistence
{
    class CaixaDB
    {
        private Banco db = null;
        public CaixaDB(Banco db)
        {
            this.db = db;
        }

        public bool GravarAbrirCaixa(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Caixa))
            {
                Caixa caixa = (Caixa)Objeto;

                string SQL;
                SQL = @"INSERT INTO Caixa (caixa_idFunc, caixa_saldoAnterior, caixa_dtFechamento)
                        values (@caixa_idFunc, @caixa_saldoAnterior, null)";


                res = db.ExecuteNonQuery(SQL, "@caixa_idFunc", caixa.IdFunc,
                                                "@caixa_saldoAnterior", caixa.SaldoAnterior);

            }

            return (res);
        }
        public bool GravarFecharCaixa(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Caixa))
            {
                Caixa caixa = (Caixa)Objeto;

                string SQL;

                SQL = @"UPDATE Caixa set caixa_dtFechamento = @caixa_dtFechamento, caixa_entradas = @caixa_entradas, caixa_saidas = @caixa_saidas
                        where caixa_id = @caixa_id";

                res = db.ExecuteNonQuery(SQL, "@caixa_dtFechamento", DateTime.Now,
                                                "@caixa_entradas", caixa.Entradas,
                                                "@caixa_saidas", caixa.Saidas,
                                                "@caixa_id", caixa.Id);

            }
            return (res);
        } 
        
        public DataTable Buscar(string filtro)
        {
            DataTable dt = new DataTable();

            string SQL = @"SELECT caixa_id, caixa_idFunc,caixa_dtAbertura, caixa_dtFechamento, caixa_saldoAnterior, caixa_entradas, caixa_saidas, func_nome FROM caixa
            inner join Funcionario on Funcionario.func_id = caixa.caixa_idFunc";

            if(filtro != "")
            {
                SQL = SQL + " WHERE " + filtro;
            }
            SQL = SQL + " order by caixa_dtAbertura desc";
            db.ExecuteQuery(SQL, out dt);

            return (dt);

        }

        public Caixa buscarCaixaAberto(int filtro)
        {

            DataTable dt = new DataTable();
            string SQL = @"select * from caixa where caixa_idFunc = @filtro order by caixa_id DESC";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            Caixa caixa = new Caixa();


            if (dt.Rows.Count > 0)
            {
                if (caixa.Dtfechamento != null)
                    caixa.Dtfechamento = Convert.ToDateTime(dt.Rows[0]["caixa_dtFechamento"].ToString());
                else
                    caixa.Dtfechamento = null;

                caixa.Id = Convert.ToInt32(dt.Rows[0]["caixa_id"]);
                caixa.IdFunc = Convert.ToInt32(dt.Rows[0]["caixa_idFunc"]);
                caixa.DtAbertura = Convert.ToDateTime(dt.Rows[0]["caixa_dtAbertura"].ToString());
                
                caixa.SaldoAnterior = Convert.ToDouble(dt.Rows[0]["caixa_saldoAnterior"].ToString());
                caixa.Entradas = Convert.ToDouble(dt.Rows[0]["caixa_entradas"].ToString());
                caixa.Saidas = Convert.ToDouble(dt.Rows[0]["caixa_saidas"].ToString());


                if (dt.Rows[0]["caixa_dtFechamento"].ToString() == "")
                {
                    // caixa aberto
                    caixa.Dtfechamento = null;
                }
                else
                {
                    
                    caixa.Dtfechamento = Convert.ToDateTime(dt.Rows[0]["caixa_dtFechamento"].ToString());
                }
            }
            else
            {
                return null;
            }
            return (caixa);

        }
        public double buscarSaldoCaixaAnterior(int filtro)
        {

            DataTable dt = new DataTable();

            string SQL = @"select * from caixa where caixa_idFunc = @filtro order by caixa_id DESC";
            double saldo = 0;
            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                double SaldoAnterior = Convert.ToDouble(dt.Rows[0]["caixa_saldoAnterior"].ToString());
                double Entradas = Convert.ToDouble(dt.Rows[0]["caixa_entradas"].ToString());
                double Saidas = Convert.ToDouble(dt.Rows[0]["caixa_saidas"].ToString());
                double Suprimento = Convert.ToDouble(dt.Rows[0]["caixa_suprimento"].ToString());
                double Sangria = Convert.ToDouble(dt.Rows[0]["caixa_sangria"].ToString());

                saldo = SaldoAnterior + Entradas - Saidas + Suprimento - Sangria;
            }
            else
            {
                return 0;
            }
            return (saldo);

        }
        /*public Cliente buscarCpf(string filtro)
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
