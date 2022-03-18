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
    class ProductDB
    {
        private Banco db = null;
        public ProductDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Produto))
            {
                Produto prod = (Produto)Objeto;

                string SQL;

                SQL = @"INSERT INTO Product (prod_id,prod_name,prod_complement,prod_inventory,prod_category,prod_brand,prod_value, prod_un)
                        values (@prod_id,@prod_name,@prod_complement,@prod_inventory,@prod_category,@prod_brand,@prod_value, @prod_un)";

                res = db.ExecuteNonQuery(SQL, "@prod_name", prod.Name,
                                                "@prod_id", prod.Id,
                                                "@prod_un", prod.Un,
                                                "@prod_complement", prod.Complement,
                                                "@prod_inventory", prod.Inventory,
                                                "@prod_category", prod.Prod_category,
                                                "@prod_brand", prod.Prod_brand,
                                                "@prod_value", prod.Value);



            }
            return (res);
        }
        public List<object> searth(string filtro)
        {
            DataTable dt = new DataTable();
            List<object> produtos = new List<object>();


            string SQL = @"SELECT * FROM Product WHERE prod_name like @filtro order by prod_name";
            filtro += "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Produto prod = new Produto();


                    prod.Id = dt.Rows[i]["prod_id"].ToString();
                    prod.Name = dt.Rows[i]["prod_name"].ToString();
                    prod.Complement = dt.Rows[i]["prod_complement"].ToString();
                    prod.Inventory = Convert.ToInt32(dt.Rows[i]["prod_inventory"]);
                    prod.Prod_category = Convert.ToInt32(dt.Rows[i]["prod_category"]);
                    prod.Prod_brand = Convert.ToInt32(dt.Rows[i]["prod_brand"]);
                    prod.Value = Convert.ToDouble(dt.Rows[i]["prod_value"].ToString());
                    prod.Un = dt.Rows[i]["prod_un"].ToString();
                    prod.Created_at = Convert.ToDateTime(dt.Rows[i]["prod_created_at"].ToString());

                    produtos.Add(prod);
                }
            }
            return (produtos);

        }
        
        public Produto buscarPorCod(string filtro)
        {
            DataTable dt = new DataTable();

            string SQL = @"SELECT * FROM Product WHERE prod_id like @filtro";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);
            Produto prod = new Produto();

            if (dt.Rows.Count > 0)
            {
                prod.Id = dt.Rows[0]["prod_id"].ToString();
                prod.Name = dt.Rows[0]["prod_name"].ToString();
                prod.Complement = dt.Rows[0]["prod_complement"].ToString();
                prod.Inventory = Convert.ToInt32(dt.Rows[0]["prod_inventory"]);
                prod.Prod_category = Convert.ToInt32(dt.Rows[0]["prod_category"]);
                prod.Prod_brand = Convert.ToInt32(dt.Rows[0]["prod_brand"]);
                prod.Un = dt.Rows[0]["prod_un"].ToString();
                prod.Value = Convert.ToDouble(dt.Rows[0]["prod_value"].ToString());
                prod.Created_at = Convert.ToDateTime(dt.Rows[0]["prod_created_at"].ToString());
            }
            else
            {
                return null;
            }
            return (prod);

        }

        public bool remove(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Product WHERE prod_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }

        public bool update(object Objeto)
        {
            
            bool res = false;
            if (Objeto.GetType() == typeof(Produto))
            {
                Produto prod = (Produto)Objeto;
                MessageBox.Show(prod.Id + "");
                string SQL = @"UPDATE Product SET prod_name = @prod_name,
                                            prod_complement = @prod_complement,
                                            prod_inventory = @prod_inventory,
                                            prod_category = @prod_category,
                                            prod_brand = @prod_brand,
                                            prod_value = @prod_value,
                                            prod_un = @prod_un
                            WHERE prod_id = @id";

                res = db.ExecuteNonQuery(SQL, "@id", prod.Id,
                                                "@prod_name", prod.Name,
                                                "@prod_un", prod.Un,
                                                "@prod_complement", prod.Complement,
                                                "@prod_inventory", prod.Inventory,
                                                "@prod_category", prod.Prod_category,
                                                "@prod_brand", prod.Prod_brand,
                                                "@prod_value", prod.Value);


            }
            return res;
        }
    }

}
