using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    class ProviderDB
    {
        private Banco db = null;
        public ProviderDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Provider))
            {
                Provider prov = (Provider)Objeto;

                string SQL;

                SQL = @"INSERT INTO Provider (prov_cpf_cnpj,prov_rg_ie,prov_name,prov_fantazy_name,prov_addres,prov_city,prov_district, prov_uf,prov_zip_code,prov_telephone,prov_email)
                        values (@prov_cpf_cnpj,@prov_rg_ie,@prov_name,@prov_fantazy_name,@prov_addres,@prov_city,@prov_district,@prov_uf,@prov_zip_code,@prov_telephone,@prov_email)";


                res = db.ExecuteNonQuery(SQL, "@prov_rg_ie", prov.Rg_ie,
                                                "@prov_cpf_cnpj", prov.Cpf_cnpj,
                                                "@prov_name", prov.Name,
                                                "@prov_fantazy_name", prov.Fantasy_name,
                                                "@prov_addres", prov.Address,
                                                "@prov_city", prov.City,
                                                "@prov_district", prov.District,
                                                "@prov_uf", prov.Uf,
                                                "@prov_zip_code", prov.Zip_code,
                                                "@prov_telephone", prov.Telephone,
                                                "@prov_email", prov.Email);



            }
            return (res);
        }
        public List<object> searth(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> providers = new List<object>();


            string SQL = @"SELECT * FROM Provider WHERE prov_name like @filtro OR prov_cpf_cnpj like @filtro order by prov_name";
            filtro += "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Provider prov = new Provider();


                    prov.Id = Convert.ToInt32(dt.Rows[i]["prov_id"]);
                    prov.Name = dt.Rows[i]["prov_name"].ToString();
                    prov.Fantasy_name = dt.Rows[i]["prov_fantazy_name"].ToString();
                    prov.Cpf_cnpj = dt.Rows[i]["prov_cpf_cnpj"].ToString();
                    prov.Rg_ie = dt.Rows[i]["prov_rg_ie"].ToString();
                    prov.Address = dt.Rows[i]["prov_addres"].ToString();
                    prov.City = dt.Rows[i]["prov_city"].ToString();
                    prov.District = dt.Rows[i]["prov_district"].ToString();
                    prov.Zip_code = dt.Rows[i]["prov_zip_code"].ToString();
                    prov.Uf = dt.Rows[i]["prov_uf"].ToString();
                    prov.Telephone = dt.Rows[i]["prov_telephone"].ToString();
                    prov.Email = dt.Rows[i]["prov_email"].ToString();
                    prov.Created_at = Convert.ToDateTime(dt.Rows[i]["prov_created_at"].ToString());

                    providers.Add(prov);
                }
            }
            return (providers);

        }
        public bool remove(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Provider WHERE prov_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }

        public bool update(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(Provider))
            {
                Provider prov = (Provider)Objeto;

                string SQL = @"UPDATE Provider SET prov_rg_ie = @prov_rg_ie,
                                                    prov_name = @prov_name,
                                                    prov_fantazy_name = @prov_fantazy_name,
                                                    prov_addres = @prov_addres,
                                                    prov_city = @prov_city,
                                                    prov_district = @prov_district,
                                                    prov_uf = @prov_uf,
                                                    prov_zip_code = @prov_zip_code,
                                                    prov_telephone = @prov_telephone,
                                                    prov_email = @prov_email
                            WHERE prov_id = @id";

                res = db.ExecuteNonQuery(SQL, "@id", prov.Id,
                                                "@prov_rg_ie", prov.Rg_ie,
                                                "@prov_name", prov.Name,
                                                "@prov_fantazy_name", prov.Fantasy_name,
                                                "@prov_addres", prov.Address,
                                                "@prov_city", prov.City,
                                                "@prov_district", prov.District,
                                                "@prov_uf", prov.Uf,
                                                "@prov_zip_code", prov.Zip_code,
                                                "@prov_telephone", prov.Telephone,
                                                "@prov_email", prov.Email);


            }
            return res;
        }
    }
}
