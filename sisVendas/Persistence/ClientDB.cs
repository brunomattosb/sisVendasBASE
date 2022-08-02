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
        public List<object> BuscarParaDGV(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> clients = new List<object>();


            string SQL = @"SELECT cli_id, cli_nome, cli_telefone, cli_saldo, cli_cpf_cnpj FROM Cliente
		WHERE cli_nome like @filtro OR cli_cpf_cnpj like @filtro order by cli_nome";
            filtro = "%" + filtro + "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Cliente cli = new Cliente();


                    cli.Id = Convert.ToInt32(dt.Rows[i]["cli_id"]);
                    cli.Nome = dt.Rows[i]["cli_nome"].ToString();
                    cli.Cpf_cnpj = dt.Rows[i]["cli_cpf_cnpj"].ToString();
                    if(long.TryParse(dt.Rows[i]["cli_telefone"].ToString(), out long fone))
                        cli.Endereco.fone = fone;
                    cli.Saldo = Convert.ToDouble(dt.Rows[i]["cli_saldo"].ToString());

                    

                    clients.Add(cli);
                }
            }
            return (clients);

        }
        
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Cliente))
            {
                Cliente cli = (Cliente)Objeto;

                string SQL;

                SQL = @"INSERT INTO Cliente (cli_nome,cli_nome_fansasia,cli_cpf_cnpj,cli_cep,cli_logradouro,cli_numero,cli_bairro,cli_cod_municipio,cli_telefone,cli_rg_ie,cli_uf,
                                                            cli_dt_aniversario,cli_sexo,cli_saldo,cli_email,cli_complemento)
                        values (@cli_nome,@cli_nome_fansasia,@cli_cpf_cnpj,@cli_cep,@cli_logradouro,@cli_numero,@cli_bairro,@cli_cod_municipio,@cli_telefone,@cli_rg_ie,@cli_uf,
                                                            NULLIF (@cli_dt_aniversario, ''),@cli_sexo,@cli_saldo,@cli_email,@cli_complemento)";

                res = db.ExecuteNonQuery(SQL, "@cli_nome", cli.Nome,
                                                "@cli_nome_fansasia", cli.Nome_fantasia,
                                                "@cli_cpf_cnpj", cli.Cpf_cnpj,
                                                "@cli_cep", cli.Endereco.CEP,
                                                "@cli_logradouro", cli.Endereco.xLgr,
                                                "@cli_numero", cli.Endereco.nro,
                                                "@cli_bairro", cli.Endereco.xBairro,
                                                "@cli_cod_municipio", cli.Endereco.cMun,
                                                "@cli_telefone", cli.Endereco.fone,
                                                "@cli_rg_ie", cli.Rg_ie,
                                                "@cli_uf", cli.Endereco.UF,
                                                "@cli_dt_aniversario", cli.DtNascimento,
                                                "@cli_sexo", cli.Sexo,
                                                "@cli_saldo", cli.Saldo,
                                                "@cli_email", cli.Email,
                                                "@cli_complemento", cli.Endereco.xCpl);
            }
            return (res);
        }
        public bool GravarClienteEmBranco(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Cliente))
            {
                Cliente cli = (Cliente)Objeto;

                string SQL;

                SQL = @"INSERT INTO Cliente (cli_nome,cli_nome_fansasia,cli_cpf_cnpj,cli_cep,cli_logradouro,cli_numero,cli_bairro,cli_cod_municipio,cli_telefone,cli_rg_ie,cli_uf,
                                                            cli_dt_aniversario,cli_sexo,cli_saldo,cli_email,cli_complemento)
                        values (@cli_nome,@cli_nome_fansasia,@cli_cpf_cnpj,@cli_cep,@cli_logradouro,@cli_numero,@cli_bairro,@cli_cod_municipio,@cli_telefone,@cli_rg_ie,@cli_uf,
                                                            NULLIF (@cli_dt_aniversario, ''),@cli_sexo,@cli_saldo,@cli_email,@cli_complemento)";

                res = db.ExecuteNonQuery(SQL, "@cli_nome", cli.Nome,
                                                "@cli_nome_fansasia", "",
                                                "@cli_cpf_cnpj", cli.Cpf_cnpj,
                                                "@cli_cep", "",
                                                "@cli_logradouro", "",
                                                "@cli_numero", "",
                                                "@cli_bairro", "",
                                                "@cli_municipio", "",
                                                "@cli_telefone", "",
                                                "@cli_rg_ie", "",
                                                "@cli_uf", "SP",
                                                "@cli_dt_aniversario", "",
                                                "@cli_sexo", "",
                                                "@cli_saldo", 0,
                                                "@cli_email", "",
                                                "@cli_complemento", "");
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
                                                cli_cpf_cnpj = @cli_cpf_cnpj,
                                                cli_cep = @cli_cep,
                                                cli_logradouro = @cli_logradouro,
                                                cli_numero = @cli_numero,
                                                cli_bairro = @cli_bairro,
                                                cli_cod_municipio = @cli_cod_municipio,
                                                cli_telefone = @cli_telefone,
                                                cli_rg_ie = @cli_rg_ie,
                                                cli_uf = @cli_uf,
                                                cli_sexo = @cli_sexo,
                                                cli_saldo = @cli_saldo,
                                                cli_email = @cli_email,
                                                cli_complemento = @cli_complemento,
                                                cli_dt_aniversario = NULLIF (@cli_dt_aniversario, '')
                            WHERE cli_id = @cli_id";

                res = db.ExecuteNonQuery(SQL, "@cli_id", cli.Id,
                                                "@cli_nome", cli.Nome,
                                                "@cli_nome_fansasia", cli.Nome_fantasia,
                                                "@cli_cpf_cnpj", cli.Cpf_cnpj,
                                                "@cli_cep", cli.Endereco.CEP,
                                                "@cli_logradouro", cli.Endereco.xLgr,
                                                "@cli_numero", cli.Endereco.nro,
                                                "@cli_bairro", cli.Endereco.xBairro,
                                                "@cli_cod_municipio", cli.Endereco.cMun,
                                                "@cli_telefone", cli.Endereco.fone,
                                                "@cli_rg_ie", cli.Rg_ie,
                                                "@cli_uf", cli.Endereco.UF,
                                                "@cli_dt_aniversario", cli.DtNascimento,
                                                "@cli_sexo", cli.Sexo,
                                                "@cli_saldo", cli.Saldo,
                                                "@cli_email", cli.Email,
                                                "@cli_complemento", cli.Endereco.xCpl);
            }
            return res;
        }
        public bool removerSaldo(int idCliente, double valor)
        {

            bool res = false;

            string SQL = @"UPDATE Cliente SET cli_saldo = (cli_saldo - @cli_saldo)
                        WHERE cli_id = @cli_id";

            res = db.ExecuteNonQuery(SQL, "@cli_id", idCliente,
                                            "@cli_saldo", valor);


            return res;
        }
        /*
        public bool adicionarSaldo(int idCliente, double valor)
        {

            bool res = false;


            string SQL = @"UPDATE Cliente SET cli_saldo = (cli_saldo + @cli_saldo)
                        WHERE cli_id = @cli_id;";

            res = db.ExecuteNonQuery(SQL, "@cli_id", idCliente,
                                            "@cli_saldo", valor);


            return res;
        }
       
        
        public DataTable BuscarCpfNome()
        {
            DataTable dt = new DataTable();
            List<object> clients = new List<object>();


            string SQL = @"SELECT cli_cpf_cnpj as 'CPF/CNPJ', cli_nome as Nome FROM Cliente order by Nome";

            db.ExecuteQuery(SQL, out dt);

            
            return (dt);

        }
        */
        public Cliente buscarPorID(int filtro)
        {

            DataTable dt = new DataTable();

            string SQL = @"select cli_email,cli_id, cli_nome,cli_nome_fansasia,cli_cpf_cnpj,cli_cep,cli_logradouro,cli_numero,cli_bairro,cli_telefone,cli_rg_ie,cli_uf,cli_dt_aniversario,cli_saldo,
            cli_created_at, cli_complemento,cli_cod_municipio, muni_nome, cli_sexo from Cliente
            left join Municipio on Cliente.cli_cod_municipio = Municipio.muni_cod where cli_id = @filtro";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            Cliente cli = new Cliente();


            if (dt.Rows.Count > 0)
            {
                cli.Id = Convert.ToInt32(dt.Rows[0]["cli_id"]);
                cli.Nome = dt.Rows[0]["cli_nome"].ToString();
                cli.Email = dt.Rows[0]["cli_email"].ToString();
                cli.Rg_ie = dt.Rows[0]["cli_rg_ie"].ToString();
                cli.Nome_fantasia = dt.Rows[0]["cli_nome_fansasia"].ToString();
                cli.Cpf_cnpj = dt.Rows[0]["cli_cpf_cnpj"].ToString();
                cli.Criado_em = Convert.ToDateTime(dt.Rows[0]["cli_created_at"].ToString());
                cli.Sexo = Convert.ToChar(dt.Rows[0]["cli_sexo"].ToString()[0]);
                cli.Saldo = Convert.ToDouble(dt.Rows[0]["cli_saldo"].ToString());

                if (!DateTime.TryParse(dt.Rows[0]["cli_dt_aniversario"].ToString(), out DateTime result))
                    cli.DtNascimento = null;
                else
                    cli.DtNascimento = result;

                //ENDEREÇO
                cli.Endereco.CEP = dt.Rows[0]["cli_cep"].ToString().PadLeft(8, '0');
                cli.Endereco.xLgr = dt.Rows[0]["cli_logradouro"].ToString();
                cli.Endereco.nro = dt.Rows[0]["cli_numero"].ToString();
                cli.Endereco.xCpl = dt.Rows[0]["cli_complemento"].ToString();
                cli.Endereco.xBairro = dt.Rows[0]["cli_bairro"].ToString();
                cli.Endereco.xMun = dt.Rows[0]["muni_nome"].ToString();
                cli.Endereco.cMun = long.Parse(dt.Rows[0]["cli_cod_municipio"].ToString());
                if (long.TryParse(dt.Rows[0]["cli_telefone"].ToString(), out long fone))
                    cli.Endereco.fone = fone;
                cli.Endereco.UF = dt.Rows[0]["cli_uf"].ToString();

            }
            else
            {
                return null;
            }
            return (cli);

        }
        public Cliente BuscarPorCPF(string filtro)
        {

            DataTable dt = new DataTable();

            string SQL = @"select cli_email,cli_id, cli_nome,cli_nome_fansasia,cli_cpf_cnpj,cli_cep,cli_logradouro,cli_numero,cli_bairro,cli_telefone,cli_rg_ie,cli_uf,cli_dt_aniversario,cli_saldo,cli_sexo
            ,cli_created_at, cli_complemento,cli_cod_municipio, muni_nome from Cliente
            left join Municipio on Cliente.cli_cod_municipio = Municipio.muni_cod WHERE cli_cpf_cnpj = @filtro";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            Cliente cli = new Cliente();


            if (dt.Rows.Count > 0)
            {
                cli.Id = Convert.ToInt32(dt.Rows[0]["cli_id"]);
                cli.Nome = dt.Rows[0]["cli_nome"].ToString();
                cli.Email = dt.Rows[0]["cli_email"].ToString();
                cli.Rg_ie = dt.Rows[0]["cli_rg_ie"].ToString();
                cli.Nome_fantasia = dt.Rows[0]["cli_nome_fansasia"].ToString();
                cli.Cpf_cnpj = dt.Rows[0]["cli_cpf_cnpj"].ToString();
                cli.Criado_em = Convert.ToDateTime(dt.Rows[0]["cli_created_at"].ToString());
                cli.Sexo = Convert.ToChar(dt.Rows[0]["cli_sexo"].ToString()[0]);
                cli.Saldo = Convert.ToDouble(dt.Rows[0]["cli_saldo"].ToString());

                if (!DateTime.TryParse(dt.Rows[0]["cli_dt_aniversario"].ToString(), out DateTime result))
                    cli.DtNascimento = null;
                else
                    cli.DtNascimento = result;

                //ENDEREÇO
                cli.Endereco.CEP = dt.Rows[0]["cli_cep"].ToString().PadLeft(8, '0');
                cli.Endereco.xLgr = dt.Rows[0]["cli_logradouro"].ToString();
                cli.Endereco.nro = dt.Rows[0]["cli_numero"].ToString();
                cli.Endereco.xCpl = dt.Rows[0]["cli_complemento"].ToString();
                cli.Endereco.xBairro = dt.Rows[0]["cli_bairro"].ToString();
                cli.Endereco.xMun = dt.Rows[0]["muni_nome"].ToString();
                cli.Endereco.cMun = long.Parse(dt.Rows[0]["cli_cod_municipio"].ToString());
                if (long.TryParse(dt.Rows[0]["cli_telefone"].ToString(), out long fone))
                    cli.Endereco.fone = fone;
                cli.Endereco.UF = dt.Rows[0]["cli_uf"].ToString();
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
