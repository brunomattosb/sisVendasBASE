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
    class ClientDB
    {
        private Banco db = null;
        public ClientDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Cliente))
            {
                Cliente cli = (Cliente)Objeto;

                string SQL;
                
                SQL = @"INSERT INTO Cliente (cli_nome,cli_nome_fansasia,cli_cpf_cnpj,cli_cep,cli_endereco,cli_bairro,
                                        cli_cidade,cli_telefone,cli_rg_ie,cli_uf,cli_dt_aniversario,cli_sexo,cli_saldo,cli_email)
                        values (@cli_nome,@cli_nome_fansasia,@cli_cpf_cnpj,@cli_cep,@cli_endereco,@cli_bairro,
                                        @cli_cidade,@cli_telefone,@cli_rg_ie,@cli_uf, NULLIF (@cli_dt_aniversario, ''),@cli_sexo,@cli_saldo,@cli_email)";

                res = db.ExecuteNonQuery(SQL, "@cli_nome", cli.Nome,
                                                "@cli_nome_fansasia", cli.Nome_fantasia,
                                                "@cli_cpf_cnpj", cli.Cpf_cnpj,
                                                "@cli_cep", cli.Cep,
                                                "@cli_endereco", cli.Endereco,
                                                "@cli_bairro", cli.Bairro,
                                                "@cli_cidade", cli.Cidade,
                                                "@cli_telefone", cli.Telefone,
                                                "@cli_rg_ie", cli.Rg_ie,
                                                "@cli_uf", cli.Uf,
                                                "@cli_dt_aniversario", cli.DtNascimento,
                                                "@cli_sexo", cli.Sexo,
                                                "@cli_saldo", cli.Saldo,
                                                "@cli_email", cli.Email);



            }
            return (res);
        }
        public bool Atualizar(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(Cliente))
            {
                Cliente cli = (Cliente)Objeto;

                string SQL = @"UPDATE Cliente SET cli_nome = @cli_nome,
                                            cli_nome_fansasia = @cli_nome_fansasia,
                                            cli_cep = @cli_cep,
                                            cli_endereco = @cli_endereco,
                                            cli_bairro = @cli_bairro,
                                            cli_cidade = @cli_cidade,
                                            cli_telefone = @cli_telefone,
                                            cli_rg_ie = @cli_rg_ie,
                                            cli_uf = @cli_uf,
                                            cli_dt_aniversario = NULLIF (@cli_dt_aniversario, ''),
                                            cli_sexo = @cli_sexo,
                                            cli_saldo = @cli_saldo,
                                            cli_email = @cli_email
                            WHERE cli_id = @cli_id";

                res = db.ExecuteNonQuery(SQL, "@cli_id", cli.Id,
                                                "@cli_nome", cli.Nome,
                                                "@cli_nome_fansasia", cli.Nome_fantasia,
                                                "@cli_cep", cli.Cep,
                                                "@cli_endereco", cli.Endereco,
                                                "@cli_bairro", cli.Bairro,
                                                "@cli_cidade", cli.Cidade,
                                                "@cli_telefone", cli.Telefone,
                                                "@cli_rg_ie", cli.Rg_ie,
                                                "@cli_uf", cli.Uf,
                                                "@cli_dt_aniversario", cli.DtNascimento,
                                                "@cli_sexo", cli.Sexo,
                                                "@cli_saldo", cli.Saldo,
                                                "@cli_email", cli.Email);


            }
            return res;
        }
        public bool adicionarSaldo(int idCliente, double valor)
        {

            bool res = false;


            string SQL = @"UPDATE Cliente SET cli_saldo = (cli_saldo + @cli_saldo)
                        WHERE cli_id = @cli_id;";

            res = db.ExecuteNonQuery(SQL, "@cli_id", idCliente,
                                            "@cli_saldo", valor);


            return res;
        }
        public bool removerSaldo(int idCliente, double valor)
        {

            bool res = false;

            MessageBox.Show(valor + "");
            MessageBox.Show(idCliente + "");
            string SQL = @"UPDATE Cliente SET cli_saldo = (cli_saldo - @cli_saldo)
                        WHERE cli_id = @cli_id";

            res = db.ExecuteNonQuery(SQL, "@cli_id", idCliente,
                                            "@cli_saldo", valor);


            return res;
        }
        public List<object> Buscar(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> clients = new List<object>();


            string SQL = @"SELECT * FROM Cliente WHERE cli_nome like @filtro OR cli_cpf_cnpj like @filtro order by cli_nome";
            filtro = "%" + filtro + "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Cliente cli = new Cliente();


                    cli.Id = Convert.ToInt32(dt.Rows[i]["cli_id"]);
                    cli.Nome = dt.Rows[i]["cli_nome"].ToString();
                    cli.Nome_fantasia = dt.Rows[i]["cli_nome_fansasia"].ToString();
                    cli.Cpf_cnpj = dt.Rows[i]["cli_cpf_cnpj"].ToString();
                    cli.Cep = dt.Rows[i]["cli_cep"].ToString();
                    cli.Endereco = dt.Rows[i]["cli_endereco"].ToString();
                    cli.Bairro = dt.Rows[i]["cli_bairro"].ToString();
                    cli.Cidade = dt.Rows[i]["cli_cidade"].ToString();
                    cli.Telefone = dt.Rows[i]["cli_telefone"].ToString();
                    cli.Rg_ie = dt.Rows[i]["cli_rg_ie"].ToString();
                    cli.Uf = dt.Rows[i]["cli_uf"].ToString();
                    cli.Criado_em = Convert.ToDateTime(dt.Rows[i]["cli_created_at"].ToString());
                    cli.Sexo = Convert.ToChar(dt.Rows[i]["cli_sexo"].ToString()[0]);
                    cli.Saldo = Convert.ToDouble(dt.Rows[i]["cli_saldo"].ToString());
                    cli.Email = dt.Rows[i]["cli_email"].ToString();

                    if (!DateTime.TryParse(dt.Rows[i]["cli_dt_aniversario"].ToString(), out DateTime result))
                        cli.DtNascimento = null;
                    else
                        cli.DtNascimento = result;

                    clients.Add(cli);
                }
            }
            return (clients);

        }
        public DataTable BuscarCpfNome()
        {
            DataTable dt = new DataTable();
            List<object> clients = new List<object>();


            string SQL = @"SELECT cli_cpf_cnpj as 'CPF/CNPJ', cli_nome as Nome FROM Cliente order by Nome";

            db.ExecuteQuery(SQL, out dt);

            
            return (dt);

        }
        public Cliente BuscarPorCPF(string filtro)
        {

            DataTable dt = new DataTable();

            string SQL = @"SELECT * FROM Cliente WHERE cli_cpf_cnpj = @filtro";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            Cliente cli = new Cliente();


            if (dt.Rows.Count > 0)
            {

                cli.Id = Convert.ToInt32(dt.Rows[0]["cli_id"]);
                cli.Nome = dt.Rows[0]["cli_nome"].ToString();
                cli.Nome_fantasia = dt.Rows[0]["cli_nome_fansasia"].ToString();
                cli.Cpf_cnpj = dt.Rows[0]["cli_cpf_cnpj"].ToString();
                cli.Cep = dt.Rows[0]["cli_cep"].ToString();
                cli.Endereco = dt.Rows[0]["cli_endereco"].ToString();
                cli.Bairro = dt.Rows[0]["cli_bairro"].ToString();
                cli.Cidade = dt.Rows[0]["cli_cidade"].ToString();
                cli.Telefone = dt.Rows[0]["cli_telefone"].ToString();
                cli.Rg_ie = dt.Rows[0]["cli_rg_ie"].ToString();
                cli.Uf = dt.Rows[0]["cli_uf"].ToString();
                cli.Criado_em = Convert.ToDateTime(dt.Rows[0]["cli_created_at"].ToString());
                cli.Sexo = Convert.ToChar(dt.Rows[0]["cli_sexo"].ToString()[0]);
                cli.Saldo = Convert.ToDouble(dt.Rows[0]["cli_saldo"].ToString());
                cli.Email = dt.Rows[0]["cli_email"].ToString();

                if (!DateTime.TryParse(dt.Rows[0]["cli_dt_aniversario"].ToString(), out DateTime result))
                    cli.DtNascimento = null;
                else
                    cli.DtNascimento = result;

            }
            else
            {
                return null;
            }
            return (cli);

        }
        public Cliente buscarPorID(int filtro)
        {

            DataTable dt = new DataTable();

            string SQL = @"SELECT * FROM Cliente WHERE cli_id = @filtro";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            Cliente cli = new Cliente();


            if (dt.Rows.Count > 0)
            {
                cli.Id = Convert.ToInt32(dt.Rows[0]["cli_id"]);
                cli.Nome = dt.Rows[0]["cli_nome"].ToString();
                cli.Nome_fantasia = dt.Rows[0]["cli_nome_fansasia"].ToString();
                cli.Cpf_cnpj = dt.Rows[0]["cli_cpf_cnpj"].ToString();
                cli.Cep = dt.Rows[0]["cli_cep"].ToString();
                cli.Endereco = dt.Rows[0]["cli_endereco"].ToString();
                cli.Bairro = dt.Rows[0]["cli_bairro"].ToString();
                cli.Cidade = dt.Rows[0]["cli_cidade"].ToString();
                cli.Telefone = dt.Rows[0]["cli_telefone"].ToString();
                cli.Rg_ie = dt.Rows[0]["cli_rg_ie"].ToString();
                cli.Uf = dt.Rows[0]["cli_uf"].ToString();

                if(DateTime.TryParse(dt.Rows[0]["cli_dt_aniversario"].ToString(), out DateTime dtAniversario))
                {
                    cli.DtNascimento = dtAniversario;
                }
                else
                {
                    cli.DtNascimento = null;
                }

                cli.Criado_em = Convert.ToDateTime(dt.Rows[0]["cli_created_at"].ToString());
                cli.Sexo = Convert.ToChar(dt.Rows[0]["cli_sexo"].ToString()[0]);
                cli.Saldo = Convert.ToDouble(dt.Rows[0]["cli_saldo"].ToString());
                cli.Email = dt.Rows[0]["cli_email"].ToString();

            }
            else
            {
                return null;
            }
            return (cli);

        }
        public bool Excluir(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Cliente WHERE cli_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }

        
    }
}
