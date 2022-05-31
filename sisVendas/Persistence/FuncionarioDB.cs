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
    class FuncionarioDB
    {
        private Banco db = null;
        public FuncionarioDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Funcionario))
            {
                Funcionario emp = (Funcionario)Objeto;

                string SQL;

                SQL = @"INSERT INTO Funcionario(func_nome,func_cpf,func_cep,func_endereco,func_bairro,func_cidade,func_telefone,func_rg,func_uf,func_dt_aniversario,
                        func_sexo,func_email,func_salario_base,func_usuario,func_senha,func_licenca, func_admissao, func_demissao, func_ativo)
                        VALUES (@func_nome,@func_cpf,@func_cep,@func_endereco,@func_bairro,@func_cidade,@func_telefone,@func_rg,@func_uf,@func_dt_aniversario,
                        @func_sexo,@func_email,@func_salario_base,@func_usuario,@func_senha,@func_licenca, @func_admissao, @func_demissao, @func_ativo)";

                res = db.ExecuteNonQuery(SQL, "@func_nome", emp.Nome,
                                                "@func_cpf", emp.Cpf,
                                                "@func_cep", emp.Cep,
                                                "@func_endereco", emp.Endereco,
                                                "@func_bairro", emp.Bairro,
                                                "@func_cidade", emp.Cidade,
                                                "@func_telefone", emp.Telefone,
                                                "@func_rg", emp.Rg,
                                                "@func_uf", emp.Uf,
                                                "@func_dt_aniversario", emp.DtNascimento,
                                                "@func_sexo", emp.Sexo,
                                                "@func_email", emp.Email,
                                                "@func_salario_base", emp.Base_salario,
                                                "@func_usuario", emp.Usuario,
                                                "@func_senha", emp.Senha,
                                                "@func_licenca", emp.Licenca,
                                                "@func_admissao", emp.Admissao,
                                                "@func_demissao", emp.Demissao,
                                                "@func_ativo", emp.Ativo);
            }
            return (res);
        }
        
        public List<object> Buscar(string filtro)
        {
            
            DataTable dt = new DataTable();
            List<object> employees = new List<object>();


            string SQL = @"SELECT * FROM Funcionario WHERE func_nome like @filtro OR func_cpf like @filtro order by func_nome";
            filtro = "%" + filtro + "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Funcionario emp = new Funcionario();

                    emp.Id = Convert.ToInt32(dt.Rows[i]["func_id"]);
                    emp.Nome = dt.Rows[i]["func_nome"].ToString();
                    emp.Cpf = dt.Rows[i]["func_cpf"].ToString();
                    emp.Cep = dt.Rows[i]["func_cep"].ToString();
                    emp.Endereco = dt.Rows[i]["func_endereco"].ToString();
                    emp.Bairro = dt.Rows[i]["func_bairro"].ToString();
                    emp.Cidade = dt.Rows[i]["func_cidade"].ToString();
                    emp.Telefone = dt.Rows[i]["func_telefone"].ToString();
                    emp.Rg = dt.Rows[i]["func_rg"].ToString();
                    emp.Uf = dt.Rows[i]["func_uf"].ToString();
                    emp.DtNascimento = Convert.ToDateTime(dt.Rows[i]["func_dt_aniversario"].ToString());
                    emp.Criado_em = Convert.ToDateTime(dt.Rows[i]["func_criado_em"].ToString());
                    emp.Email = dt.Rows[i]["func_email"].ToString();
                    emp.Sexo = Convert.ToChar(dt.Rows[i]["func_sexo"].ToString()[0]);
                    emp.Base_salario = Convert.ToDouble(dt.Rows[i]["func_salario_base"].ToString());
                    emp.Usuario = dt.Rows[i]["func_usuario"].ToString();
                    emp.Senha = dt.Rows[i]["func_senha"].ToString();
                    emp.Licenca = dt.Rows[i]["func_licenca"].ToString();
                    emp.Admissao = Convert.ToDateTime(dt.Rows[i]["func_admissao"].ToString());
                    emp.Demissao = Convert.ToDateTime(dt.Rows[i]["func_demissao"].ToString());
                    emp.Ativo = Convert.ToBoolean(dt.Rows[i]["func_ativo"].ToString());

                    employees.Add(emp);
                }
            }
            return (employees);

        }
        public DataTable BuscarCpfNome()
        {

            DataTable dt = new DataTable();

            string SQL = @"SELECT func_cpf as Cpf, func_nome as Nome FROM Funcionario order by Nome";

            db.ExecuteQuery(SQL, out dt);

            
            return (dt);

        }
        public List<object> BuscarParaComboBox()
        {

            DataTable dt = new DataTable();
            List<object> employees = new List<object>();


            string SQL = @"SELECT func_id, func_nome FROM Funcionario";

            db.ExecuteQuery(SQL, out dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Funcionario emp = new Funcionario();

                    emp.Id = Convert.ToInt32(dt.Rows[i]["func_id"]);
                    emp.Nome = dt.Rows[i]["func_nome"].ToString();

                    employees.Add(emp);
                }
            }
            return (employees);

        }

        public Funcionario buscarPorUsername(string filtro)
        {

            DataTable dt = new DataTable();

            string SQL = @"SELECT * FROM Funcionario where func_usuario like @filtro and func_ativo = 1";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);
            Funcionario emp = new Funcionario();

            if (dt.Rows.Count > 0)
            {
                emp.Id = Convert.ToInt32(dt.Rows[0]["func_id"]);
                emp.Nome = dt.Rows[0]["func_nome"].ToString();
                emp.Cpf = dt.Rows[0]["func_cpf"].ToString();
                emp.Cep = dt.Rows[0]["func_cep"].ToString();
                emp.Endereco = dt.Rows[0]["func_endereco"].ToString();
                emp.Bairro = dt.Rows[0]["func_bairro"].ToString();
                emp.Cidade = dt.Rows[0]["func_cidade"].ToString();
                emp.Telefone = dt.Rows[0]["func_telefone"].ToString();
                emp.Rg = dt.Rows[0]["func_rg"].ToString();
                emp.Uf = dt.Rows[0]["func_uf"].ToString();
                emp.DtNascimento = Convert.ToDateTime(dt.Rows[0]["func_dt_aniversario"].ToString());
                emp.Criado_em = Convert.ToDateTime(dt.Rows[0]["func_criado_em"].ToString());
                emp.Email = dt.Rows[0]["func_email"].ToString();
                emp.Sexo = Convert.ToChar(dt.Rows[0]["func_sexo"].ToString()[0]);
                emp.Base_salario = Convert.ToDouble(dt.Rows[0]["func_salario_base"].ToString());
                emp.Usuario = dt.Rows[0]["func_usuario"].ToString();
                emp.Senha = dt.Rows[0]["func_senha"].ToString();
                emp.Licenca = dt.Rows[0]["func_licenca"].ToString();
                emp.Admissao = Convert.ToDateTime(dt.Rows[0]["func_admissao"].ToString());
                emp.Demissao = Convert.ToDateTime(dt.Rows[0]["func_demissao"].ToString());
                emp.Ativo = bool.Parse( dt.Rows[0]["func_ativo"].ToString());
            }
            else
            {
                return null;
            }
            return (emp);

        }
        public Funcionario buscarPorCPF(string filtro)
        {

            DataTable dt = new DataTable();

            string SQL = @"SELECT * FROM Funcionario where func_cpf like @filtro";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);
            Funcionario emp = new Funcionario();

            if (dt.Rows.Count > 0)
            {
                emp.Id = Convert.ToInt32(dt.Rows[0]["func_id"]);
                emp.Nome = dt.Rows[0]["func_nome"].ToString();
                emp.Cpf = dt.Rows[0]["func_cpf"].ToString();
                emp.Cep = dt.Rows[0]["func_cep"].ToString();
                emp.Endereco = dt.Rows[0]["func_endereco"].ToString();
                emp.Bairro = dt.Rows[0]["func_bairro"].ToString();
                emp.Cidade = dt.Rows[0]["func_cidade"].ToString();
                emp.Telefone = dt.Rows[0]["func_telefone"].ToString();
                emp.Rg = dt.Rows[0]["func_rg"].ToString();
                emp.Uf = dt.Rows[0]["func_uf"].ToString();
                emp.DtNascimento = Convert.ToDateTime(dt.Rows[0]["func_dt_aniversario"].ToString());
                emp.Criado_em = Convert.ToDateTime(dt.Rows[0]["func_criado_em"].ToString());
                emp.Email = dt.Rows[0]["func_email"].ToString();
                emp.Sexo = Convert.ToChar(dt.Rows[0]["func_sexo"].ToString()[0]);
                emp.Base_salario = Convert.ToDouble(dt.Rows[0]["func_salario_base"].ToString());
                emp.Usuario = dt.Rows[0]["func_usuario"].ToString();
                emp.Senha = dt.Rows[0]["func_senha"].ToString();
                emp.Licenca = dt.Rows[0]["func_licenca"].ToString();
                emp.Admissao = Convert.ToDateTime(dt.Rows[0]["func_admissao"].ToString());
                emp.Demissao = Convert.ToDateTime(dt.Rows[0]["func_demissao"].ToString());
                emp.Ativo = bool.Parse(dt.Rows[0]["func_ativo"].ToString());
            }
            else
            {
                return null;
            }
            return (emp);

        }
        public bool Atualizar(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(Funcionario))
            {
                Funcionario emp = (Funcionario)Objeto;

                string SQL = @"UPDATE Funcionario SET func_nome = @func_nome,
                                            func_cep = @func_cep,
                                            func_endereco = @func_endereco,
                                            func_bairro = @func_bairro,
                                            func_cidade = @func_cidade,
                                            func_telefone = @func_telefone,
                                            func_rg = @func_rg,
                                            func_uf = @func_uf,
                                            func_dt_aniversario = @func_dt_aniversario,
                                            func_sexo = @func_sexo,
                                            func_email = @func_email,
                                            func_salario_base = @func_salario_base,
                                            func_usuario = @func_usuario,
                                            func_senha = @func_senha,
                                            func_licenca = @func_licenca,
                                            func_admissao = @func_admissao,
                                            func_demissao = @func_demissao,
                                            func_ativo = @func_ativo ,
                                            func_cpf = @func_cpf
                            WHERE func_id = @func_id";
                
                res = db.ExecuteNonQuery(SQL, "@func_nome", emp.Nome,
                                                "@func_id", emp.Id,
                                                "@func_cep", emp.Cep,
                                                "@func_endereco", emp.Endereco,
                                                "@func_bairro", emp.Bairro,
                                                "@func_cidade", emp.Cidade,
                                                "@func_telefone", emp.Telefone,
                                                "@func_rg", emp.Rg,
                                                "@func_uf", emp.Uf,
                                                "@func_dt_aniversario", emp.DtNascimento,
                                                "@func_sexo", emp.Sexo,
                                                "@func_email", emp.Email,
                                                "@func_salario_base", emp.Base_salario,
                                                "@func_usuario", emp.Usuario,
                                                "@func_senha", emp.Senha,
                                                "@func_licenca", emp.Licenca,
                                                "@func_admissao", emp.Admissao,
                                                "@func_demissao", emp.Demissao,
                                                "@func_cpf", emp.Cpf,
                                                "@func_ativo", emp.Ativo);
            }
            return res;
        }
        public bool remove(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Funcionario WHERE func_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
        public int buscarSePrimeiroAcesso()
        {
            DataTable res = new DataTable();

            string SQL = @"select count(func_id) as qtdeReg from funcionario;";
            db.ExecuteQuery(SQL, out res);

            return int.Parse(res.Rows[0]["qtdeReg"].ToString());
        }
    }
}
