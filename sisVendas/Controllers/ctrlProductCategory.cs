using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Controllers
{
    class ctrlProductCategory
    {
        private Banco dataBase = new Banco();
        private ProductCategory CurrentProductCategory = new ProductCategory();

        public bool SaveProductCategory(string id, string name)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                CurrentProductCategory.Id = number;

            CurrentProductCategory.Name = name;

            dataBase.Conecta();
            bool result = false;
            ProductCategoryDB prodCategoryDB = new ProductCategoryDB(dataBase);
            if (number == 0)
            {
                result = prodCategoryDB.Gravar(CurrentProductCategory);
            }
            else
            {
                result = prodCategoryDB.update(CurrentProductCategory);
            }
            dataBase.Desconecta();

            return (result);
        }
        public DataTable searthProductCategory(string filter)
        {

            DataTable dtProductCategory = new DataTable();

            dtProductCategory.Columns.Add("prodCategory_id", typeof(int));
            dtProductCategory.Columns.Add("prodCategory_name");
            dtProductCategory.Columns.Add("prodCategory_created_at", typeof(DateTime));

            dataBase.Conecta();
            ProductCategoryDB productCategoryDB = new ProductCategoryDB(dataBase);
            foreach (ProductCategory prodCategory in productCategoryDB.searth(filter))
            {

                DataRow line = dtProductCategory.NewRow();

                line["prodCategory_id"] = prodCategory.Id;
                line["prodCategory_name"] = prodCategory.Name;
                line["prodCategory_created_at"] = prodCategory.Created_at;


                dtProductCategory.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtProductCategory);
        }
       
        public bool removeProduct(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ProductCategoryDB prodCategoryDB = new ProductCategoryDB(dataBase);
            res = prodCategoryDB.remove(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}
