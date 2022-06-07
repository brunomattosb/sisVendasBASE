using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    internal class PromocaoDB
    {
        private Banco db = null;
        public PromocaoDB(Banco db)
        {
            this.db = db;
        }
        
        public int Gravar(object Objeto)
        {
            bool res = false;
            int retorno = 0;

            if (Objeto.GetType() == typeof(Promocao))
            {
                Promocao promo = (Promocao)Objeto;

                string SQL;

                SQL = @"INSERT INTO Promocao (promo_idFunc, promo_nome, promo_inicio, promo_fim)
                        values (@promo_idFunc, @promo_nome, @promo_inicio, @promo_fim)";

                res = db.ExecuteNonQuery(SQL, "@promo_idFunc", promo.IdFunc,
                                                "@promo_nome", promo.Nome,
                                                "@promo_inicio", promo.DtInicio,
                                                "@promo_fim", promo.DtFim);

                if (res)
                {
                    retorno = db.GetIdentity();
                }
            }
            return (retorno);
        }
        
        public bool finalizar(int id)
        {

            bool res = false;

            string SQL = @"UPDATE Promocao SET promo_fim = GETDATE()
                        WHERE promo_id = @promo_id";

            res = db.ExecuteNonQuery(SQL, "promo_id", id);
            
            return res;
        }
        
        public List<object> Buscar(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> promocao = new List<object>();


            string SQL = @"SELECT * FROM Promocao order by promo_inicio";
            filtro = "%" + filtro + "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Promocao promo = new Promocao();


                    promo.Id = Convert.ToInt32(dt.Rows[i]["promo_id"]);
                    promo.IdFunc = Convert.ToInt32(dt.Rows[i]["promo_idFunc"]);
                    promo.Nome = dt.Rows[i]["promo_nome"].ToString();
                    promo.DtInicio = Convert.ToDateTime(dt.Rows[i]["promo_inicio"].ToString());
                    promo.DtFim = Convert.ToDateTime(dt.Rows[i]["promo_fim"].ToString());
                    promo.Criado_em = Convert.ToDateTime(dt.Rows[i]["promo_criado_em"].ToString());

                    promocao.Add(promo);
                }
            }
            return (promocao);

        }
        /*
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
                cli.DtNascimento = Convert.ToDateTime(dt.Rows[0]["cli_dt_aniversario"].ToString());
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

        }*/
        /*
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
                cli.DtNascimento = Convert.ToDateTime(dt.Rows[0]["cli_dt_aniversario"].ToString());
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

        }*/
        /*
        public bool Excluir(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Cliente WHERE cli_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }*/
    }
}
