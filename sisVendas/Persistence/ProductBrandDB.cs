
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sisVendas.Models;
using System.Threading.Tasks;
using System.Data;

namespace sisVendas.Persistence
{
    class ProductBrandDB
    {
        private Banco db = null;
        public ProductBrandDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(ProductBrand))
            {
                ProductBrand prodBrand = (ProductBrand)Objeto;

                string SQL;

                SQL = @"INSERT INTO ProductBrand(ProdBrand_name)
                        VALUES (@ProdBrand_name)";

                res = db.ExecuteNonQuery(SQL, "@ProdBrand_name", prodBrand.Name);


            }
            return (res);
        }

        public List<object> searth(string filtro)
        {

            DataTable dt = new DataTable();
            List<object> ProductBrand = new List<object>();


            string SQL = @"SELECT * FROM ProductBrand WHERE ProdBrand_name like @filtro order by ProdBrand_name";
            filtro += "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProductBrand prodBrand = new ProductBrand();


                    prodBrand.Id = Convert.ToInt32(dt.Rows[i]["prodBrand_id"]);
                    prodBrand.Name = dt.Rows[i]["prodBrand_name"].ToString();
                    prodBrand.Created_at = Convert.ToDateTime(dt.Rows[i]["prodBrand_created_at"].ToString());


                    ProductBrand.Add(prodBrand);
                }
            }
            return (ProductBrand);

        }


        public bool update(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(ProductBrand))
            {
                ProductBrand exp = (ProductBrand)Objeto;

                string SQL = @"UPDATE ProductBrand SET ProdBrand_name = @ProdBrand_name
                            WHERE ProdBrand_id = @ProdBrand_id";

                res = db.ExecuteNonQuery(SQL, "@ProdBrand_name", exp.Name,
                                                "@ProdBrand_id", exp.Id);
            }
            return res;
        }
        public bool remove(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM ProductBrand WHERE ProdBrand_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
    }
}
