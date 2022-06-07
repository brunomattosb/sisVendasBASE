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
    class ItensVendaDB
    {
        private Banco db = null;
        public ItensVendaDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(ItenVenda))
            {
                ItenVenda itensVenda = (ItenVenda)Objeto;

                string SQL;

                SQL = @"INSERT INTO ItenVenda (iten_quantidade,iten_idVenda,iten_idProduto, iten_valor)
                        values (@iten_quantidade,@iten_idVenda,@iten_idProduto, @iten_valor)";


                res = db.ExecuteNonQuery(SQL, "@iten_quantidade", itensVenda.Quantidade,
                                                "@iten_idVenda", itensVenda.Id_venda,
                                                "@iten_idProduto", itensVenda.Id_produto,
                                                "@iten_valor", itensVenda.Valor);



            }
            return (res);
        }
        public DataTable buscarPorIdVenda(int filtro)
        {
            DataTable dt = new DataTable();

            string SQL = @"select iten_quantidade, iten_idProduto, iten_valor, prod_nome, prod_un from ItenVenda
left join produto on produto.prod_id = ItenVenda.iten_idProduto
 where iten_idVenda = @filtro";


            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            
            return (dt);

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
        public bool removerItensVenda(int id)
        {
            bool res = false;
            string SQL = @"DELETE FROM ItenVenda WHERE iten_idVenda = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
    }
}
