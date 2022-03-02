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

            if (Objeto.GetType() == typeof(Client))
            {
                Client cli = (Client)Objeto;

                string SQL;

                SQL = @"INSERT INTO Client (cli_name,cli_fantasy_name,cli_cpf_cnpj,cli_zip_code,cli_addres,cli_district, cli_city,cli_telephone,cli_rg_ie,cli_uf,
                                                                                                          cli_birth_at,cli_sex,cli_balance,cli_email)
                        values (@name,@fantasy,@cpf,@cep,@addres,@district,@city,@telephone,@rg,@uf,@birth,@sex,@balance,@email)";


                res = db.ExecuteNonQuery(SQL,   "@name",cli.Name,
                                                "@fantasy", cli.Fantasy_name,
                                                "@cpf", cli.Cpf_cnpj,
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
            return (res);
        }
        public List<object> searthClient(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> clients = new List<object>();


            string SQL = @"SELECT * FROM Client WHERE cli_name like @filtro OR cli_cpf_cnpj like @filtro order by cli_name";
            filtro += "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Client cli = new Client();


                    cli.Id = Convert.ToInt32(dt.Rows[i]["cli_id"]);
                    cli.Name = dt.Rows[i]["cli_name"].ToString();
                    cli.Fantasy_name = dt.Rows[i]["cli_fantasy_name"].ToString();
                    cli.Cpf_cnpj = dt.Rows[i]["cli_cpf_cnpj"].ToString();
                    cli.Zip_code = dt.Rows[i]["cli_zip_code"].ToString();
                    cli.Address = dt.Rows[i]["cli_addres"].ToString();
                    cli.District = dt.Rows[i]["cli_district"].ToString();
                    cli.City = dt.Rows[i]["cli_city"].ToString();
                    cli.Telephone = dt.Rows[i]["cli_telephone"].ToString();
                    cli.Rg_ie = dt.Rows[i]["cli_rg_ie"].ToString();
                    cli.Uf = dt.Rows[i]["cli_uf"].ToString();
                    cli.Birth_at = Convert.ToDateTime(dt.Rows[i]["cli_birth_at"].ToString());
                    cli.Created_at = Convert.ToDateTime(dt.Rows[i]["cli_created_at"].ToString());
                    cli.Sex = Convert.ToChar(dt.Rows[i]["cli_sex"].ToString()[0]);
                    cli.Balance = Convert.ToDouble(dt.Rows[i]["cli_balance"].ToString());
                    cli.Email = dt.Rows[i]["cli_email"].ToString();


                    clients.Add(cli);
                }
            }
            return (clients);

        }
        public bool removeClient(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Client WHERE cli_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }

        public bool updateClient(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(Client))
            {
                Client cli = (Client)Objeto;

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
        }
    }
}
