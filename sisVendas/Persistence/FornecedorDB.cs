using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    class FornecedorDB
    {
        private Banco db = null;
        public FornecedorDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Fornecedor))
            {
                Fornecedor prov = (Fornecedor)Objeto;

                string SQL;

                SQL = @"INSERT INTO Fornecedor (forn_cpf_cnpj,forn_rg_ie,forn_nome,forn_nome_fantasia,forn_endereco,forn_cidade,forn_bairro, forn_uf,forn_cep,forn_telefone,forn_email)
                        values (@forn_cpf_cnpj,@forn_rg_ie,@forn_nome,@forn_nome_fantasia,@forn_endereco,@forn_cidade,@forn_bairro, @forn_uf,@forn_cep,@forn_telefone,@forn_email)";


                res = db.ExecuteNonQuery(SQL, "@forn_rg_ie", prov.Rg_ie,
                                                "@forn_cpf_cnpj", prov.Cpf_cnpj,
                                                "@forn_nome", prov.Nome,
                                                "@forn_nome_fantasia", prov.Nome_fantasia,
                                                "@forn_endereco", prov.Endereco,
                                                "@forn_cidade", prov.Cidade,
                                                "@forn_bairro", prov.Bairro,
                                                "@forn_uf", prov.Uf,
                                                "@forn_cep", prov.Cep,
                                                "@forn_telefone", prov.Telefone,
                                                "@forn_email", prov.Email);
            }
            return (res);
        }
        public Fornecedor buscarPorCpfCnpj(string filtro)
        {
            DataTable dt = new DataTable();

            string SQL = @"SELECT * FROM Fornecedor WHERE forn_cpf_cnpj like @filtro";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);
            Fornecedor forn = new Fornecedor();

            if (dt.Rows.Count > 0)
            {
                forn.Id = Convert.ToInt32(dt.Rows[0]["forn_id"]);
                forn.Nome = dt.Rows[0]["forn_nome"].ToString();
                forn.Nome_fantasia = dt.Rows[0]["forn_nome_fantasia"].ToString();
                forn.Cpf_cnpj = dt.Rows[0]["forn_cpf_cnpj"].ToString();
                forn.Rg_ie = dt.Rows[0]["forn_rg_ie"].ToString();
                forn.Endereco = dt.Rows[0]["forn_endereco"].ToString();
                forn.Cidade = dt.Rows[0]["forn_cidade"].ToString();
                forn.Bairro = dt.Rows[0]["forn_bairro"].ToString();
                forn.Cep = dt.Rows[0]["forn_cep"].ToString();
                forn.Uf = dt.Rows[0]["forn_uf"].ToString();
                forn.Telefone = dt.Rows[0]["forn_telefone"].ToString();
                forn.Email = dt.Rows[0]["forn_email"].ToString();
                forn.Criado_em = Convert.ToDateTime(dt.Rows[0]["forn_criado_em"].ToString());
            }
            else
            {
                return null;
            }
            return (forn);

        }
        public Fornecedor buscarPorCod(int filtro)
        {
            DataTable dt = new DataTable();

            string SQL = @"SELECT * FROM Fornecedor WHERE forn_id like @filtro";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);
            Fornecedor forn = new Fornecedor();

            if (dt.Rows.Count > 0)
            {
                forn.Id = Convert.ToInt32(dt.Rows[0]["forn_id"]);
                forn.Nome = dt.Rows[0]["forn_nome"].ToString();
                forn.Nome_fantasia = dt.Rows[0]["forn_nome_fantasia"].ToString();
                forn.Cpf_cnpj = dt.Rows[0]["forn_cpf_cnpj"].ToString();
                forn.Rg_ie = dt.Rows[0]["forn_rg_ie"].ToString();
                forn.Endereco = dt.Rows[0]["forn_endereco"].ToString();
                forn.Cidade = dt.Rows[0]["forn_cidade"].ToString();
                forn.Bairro = dt.Rows[0]["forn_bairro"].ToString();
                forn.Cep = dt.Rows[0]["forn_cep"].ToString();
                forn.Uf = dt.Rows[0]["forn_uf"].ToString();
                forn.Telefone = dt.Rows[0]["forn_telefone"].ToString();
                forn.Email = dt.Rows[0]["forn_email"].ToString();
                forn.Criado_em = Convert.ToDateTime(dt.Rows[0]["forn_criado_em"].ToString());
            }
            else
            {
                return null;
            }
            return (forn);

        }
        public List<object> buscar(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> providers = new List<object>();


            string SQL = @"SELECT * FROM Fornecedor WHERE forn_nome like @filtro OR forn_cpf_cnpj like @filtro order by forn_nome";
            filtro = "%" + filtro + "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Fornecedor forn = new Fornecedor();


                    forn.Id = Convert.ToInt32(dt.Rows[i]["forn_id"]);
                    forn.Nome = dt.Rows[i]["forn_nome"].ToString();
                    forn.Nome_fantasia = dt.Rows[i]["forn_nome_fantasia"].ToString();
                    forn.Cpf_cnpj = dt.Rows[i]["forn_cpf_cnpj"].ToString();
                    forn.Rg_ie = dt.Rows[i]["forn_rg_ie"].ToString();
                    forn.Endereco = dt.Rows[i]["forn_endereco"].ToString();
                    forn.Cidade = dt.Rows[i]["forn_cidade"].ToString();
                    forn.Bairro = dt.Rows[i]["forn_bairro"].ToString();
                    forn.Cep = dt.Rows[i]["forn_cep"].ToString();
                    forn.Uf = dt.Rows[i]["forn_uf"].ToString();
                    forn.Telefone = dt.Rows[i]["forn_telefone"].ToString();
                    forn.Email = dt.Rows[i]["forn_email"].ToString();
                    forn.Criado_em = Convert.ToDateTime(dt.Rows[i]["forn_criado_em"].ToString());

                    providers.Add(forn);
                }
            }
            return (providers);

        }
        public List<object> buscarResumido(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> providers = new List<object>();


            string SQL = @"SELECT forn_id, forn_nome, forn_nome_fantasia, forn_cpf_cnpj FROM Fornecedor WHERE forn_nome like @filtro OR forn_cpf_cnpj like @filtro order by forn_nome";
            filtro += "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Fornecedor prov = new Fornecedor();


                    prov.Id = Convert.ToInt32(dt.Rows[i]["forn_id"]);
                    prov.Nome = dt.Rows[i]["forn_nome"].ToString();
                    prov.Nome_fantasia = dt.Rows[i]["forn_nome_fantasia"].ToString();
                    prov.Cpf_cnpj = dt.Rows[i]["forn_cpf_cnpj"].ToString();

                    providers.Add(prov);
                }
            }
            return (providers);

        }
        public bool remover(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Fornecedor WHERE forn_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }

        public bool Atualizar(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(Fornecedor))
            {
                Fornecedor prov = (Fornecedor)Objeto;

                string SQL = @"UPDATE Fornecedor SET forn_rg_ie = @forn_rg_ie,
                                                    forn_nome = @forn_nome,
                                                    forn_nome_fantasia = @forn_nome_fantasia,
                                                    forn_endereco = @forn_endereco,
                                                    forn_cidade = @forn_cidade,
                                                    forn_bairro = @forn_bairro,
                                                    forn_uf = @forn_uf,
                                                    forn_cep = @forn_cep,
                                                    forn_telefone = @forn_telefone,
                                                    forn_email = @forn_email
                            WHERE forn_id = @id";

                res = db.ExecuteNonQuery(SQL, "@id", prov.Id,
                                                "@forn_rg_ie", prov.Rg_ie,
                                                "@forn_nome", prov.Nome,
                                                "@forn_nome_fantasia", prov.Nome_fantasia,
                                                "@forn_endereco", prov.Endereco,
                                                "@forn_cidade", prov.Cidade,
                                                "@forn_bairro", prov.Bairro,
                                                "@forn_uf", prov.Uf,
                                                "@forn_cep", prov.Cep,
                                                "@forn_telefone", prov.Telefone,
                                                "@forn_email", prov.Email);


            }
            return res;
        }
    }
}
