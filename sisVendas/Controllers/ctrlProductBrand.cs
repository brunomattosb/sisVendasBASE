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
    class ctrlProductBrand
    {
        private Banco dataBase = new Banco();
        private ProductBrand CurrentProductBrand = new ProductBrand();

        public bool SaveProductBrand(string id, string name)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                CurrentProductBrand.Id = number;

            CurrentProductBrand.Name = name;

            dataBase.Conecta();
            bool result = false;
            ProductBrandDB prodBrandDB = new ProductBrandDB(dataBase);
            if (number == 0)
            {
                result = prodBrandDB.Gravar(CurrentProductBrand);
            }
            else
            {
                result = prodBrandDB.update(CurrentProductBrand);
            }
            dataBase.Desconecta();

            return (result);
        }
        public DataTable searthProductBrand(string filter)
        {

            DataTable dtProductbrand = new DataTable();

            dtProductbrand.Columns.Add("ProdBrand_id", typeof(int));
            dtProductbrand.Columns.Add("ProdBrand_name");
            dtProductbrand.Columns.Add("ProdBrand_created_at", typeof(DateTime));

            dataBase.Conecta();
            ProductBrandDB productBrandDB = new ProductBrandDB(dataBase);
            foreach (ProductBrand prodBrand in productBrandDB.searth(filter))
            {

                DataRow line = dtProductbrand.NewRow();

                line["ProdBrand_id"] = prodBrand.Id;
                line["ProdBrand_name"] = prodBrand.Name;
                line["ProdBrand_created_at"] = prodBrand.Created_at;


                dtProductbrand.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtProductbrand);
        }
        public bool removeProduct(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ProductBrandDB prodBrandDB = new ProductBrandDB(dataBase);
            res = prodBrandDB.remove(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}
