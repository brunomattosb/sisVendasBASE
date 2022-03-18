using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Controllers
{
    class ctrlProduct
    {
        private Banco dataBase = new Banco();
        private Produto CurrentProduct = new Produto();

        // DateTime created_at, char sex, double balance)
        public bool SaveProduct(string id, string name, string complement, int inventory, int category, int brand,
            double value, string UN)
        {

            // Verifica se existe um numero no tbCod
            CurrentProduct.Id = id;
            CurrentProduct.Name = name;
            CurrentProduct.Complement = complement;
            CurrentProduct.Inventory = inventory;
            CurrentProduct.Prod_category = category;
            CurrentProduct.Prod_brand = brand;
            CurrentProduct.Value = value;
            CurrentProduct.Un = UN;

            dataBase.Conecta();
            bool result = false;

            ProductDB prodDB = new ProductDB(dataBase);
            if (prodDB.buscarPorCod(id) == null)
            {
                result = prodDB.Gravar(CurrentProduct);
            }
            else
            {
                result = prodDB.update(CurrentProduct);
            }
            dataBase.Desconecta();

            return (result);
        }
        
        public DataTable searthProduct(string filter)
        {

            DataTable dtProduct = new DataTable();

            dtProduct.Columns.Add("prod_id");
            dtProduct.Columns.Add("prod_name");
            dtProduct.Columns.Add("prod_complement");
            dtProduct.Columns.Add("prod_un");
            dtProduct.Columns.Add("prod_inventory", typeof(int));
            dtProduct.Columns.Add("prod_category", typeof(int));
            dtProduct.Columns.Add("prod_brand", typeof(int));
            dtProduct.Columns.Add("prod_value", typeof(double));
            dtProduct.Columns.Add("prod_created_at", typeof(DateTime));

            dataBase.Conecta();
            ProductDB prodDB = new ProductDB(dataBase);
            foreach (Produto prod in prodDB.searth(filter))
            {

                DataRow line = dtProduct.NewRow();

                line["prod_id"] = prod.Id;
                line["prod_name"] = prod.Name;
                line["prod_complement"] = prod.Complement;
                line["prod_inventory"] = prod.Inventory;
                line["prod_category"] = prod.Prod_category;
                line["prod_brand"] = prod.Prod_brand;
                line["prod_value"] = prod.Value;
                line["prod_un"] = prod.Un;
                line["prod_created_at"] = prod.Created_at;
                
                dtProduct.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtProduct);
        }
        public Produto buscarProdutoPorCod(string filter)
        {

            Produto prod = new Produto();

            dataBase.Conecta();
            ProductDB bd = new ProductDB(dataBase);
            prod = (Produto)bd.buscarPorCod(filter);

            dataBase.Desconecta();
            return prod;
        }


        public bool removeProduct(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ProductDB prodDB = new ProductDB(dataBase);
            res = prodDB.remove(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}
