using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    class ProductCategoryDB
    {
        private Banco db = null;
        public ProductCategoryDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(ProductCategory))
            {
                ProductCategory prodCat = (ProductCategory)Objeto;

                string SQL;

                SQL = @"INSERT INTO ProductCategory(prodCategory_name)
                        VALUES (@prodCategory_name)";

                res = db.ExecuteNonQuery(SQL, "@prodCategory_name", prodCat.Name);


            }
            return (res);
        }

        public List<object> searth(string filtro)
        {

            DataTable dt = new DataTable();
            List<object> prodCategories = new List<object>();


            string SQL = @"SELECT * FROM ProductCategory WHERE prodCategory_name like @filtro order by prodCategory_name";
            filtro += "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProductCategory cat = new ProductCategory();


                    cat.Id = Convert.ToInt32(dt.Rows[i]["prodCategory_id"]);
                    cat.Name = dt.Rows[i]["prodCategory_name"].ToString();
                    cat.Created_at = Convert.ToDateTime(dt.Rows[i]["prodCategory_created_at"].ToString());


                    prodCategories.Add(cat);
                }
            }
            return (prodCategories);

        }


        public bool update(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(ProductCategory))
            {
                ProductCategory exp = (ProductCategory)Objeto;

                string SQL = @"UPDATE ProductCategory SET prodCategory_name = @prodCategory_name
                            WHERE prodCategory_id = @prodCategory_id";

                res = db.ExecuteNonQuery(SQL, "@prodCategory_name", exp.Name,
                                                "@prodCategory_id", exp.Id);
            }
            return res;
        }
        public bool remove(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM ProductCategory WHERE prodCategory_id     = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
    }
}
