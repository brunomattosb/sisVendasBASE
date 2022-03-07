﻿using sisVendas.Models;
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
        private Product CurrentProduct = new Product();

        // DateTime created_at, char sex, double balance)
        public bool SaveProduct(string id, string name, string complement, int inventory, int category, int brand,
            double value)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                CurrentProduct.Id = number;
            CurrentProduct.Name = name;
            CurrentProduct.Complement = complement;
            CurrentProduct.Inventory = inventory;
            CurrentProduct.Prod_category = category;
            CurrentProduct.Prod_brand = brand;
            CurrentProduct.Value = value;

            dataBase.Conecta();
            bool result = false;

            ProductDB prodDB = new ProductDB(dataBase);
            if (prodDB.searthByCod(id).Count() == 0)
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

            dtProduct.Columns.Add("prod_id", typeof(int));
            dtProduct.Columns.Add("prod_name");
            dtProduct.Columns.Add("prod_complement");
            dtProduct.Columns.Add("prod_inventory", typeof(int));
            dtProduct.Columns.Add("prod_category", typeof(int));
            dtProduct.Columns.Add("prod_brand", typeof(int));
            dtProduct.Columns.Add("prod_value", typeof(double));
            dtProduct.Columns.Add("prod_created_at", typeof(DateTime));

            dataBase.Conecta();
            ProductDB prodDB = new ProductDB(dataBase);
            foreach (Product prod in prodDB.searth(filter))
            {

                DataRow line = dtProduct.NewRow();

                line["prod_id"] = prod.Id;
                line["prod_name"] = prod.Name;
                line["prod_complement"] = prod.Complement;
                line["prod_inventory"] = prod.Inventory;
                line["prod_category"] = prod.Prod_category;
                line["prod_brand"] = prod.Prod_brand;
                line["prod_value"] = prod.Value;
                line["prod_created_at"] = prod.Created_at;

                dtProduct.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtProduct);
        }
        public DataTable searthProductByCod(string filter)
        {

            DataTable dtProduct = new DataTable();

            dtProduct.Columns.Add("prod_id", typeof(int));
            dtProduct.Columns.Add("prod_name");
            dtProduct.Columns.Add("prod_complement");
            dtProduct.Columns.Add("prod_inventory", typeof(int));
            dtProduct.Columns.Add("prod_category", typeof(int));
            dtProduct.Columns.Add("prod_brand", typeof(int));
            dtProduct.Columns.Add("prod_value", typeof(double));
            dtProduct.Columns.Add("prod_created_at", typeof(DateTime));

            dataBase.Conecta();
            ProductDB prodDB = new ProductDB(dataBase);
            foreach (Product prod in prodDB.searthByCod(filter))
            {

                DataRow line = dtProduct.NewRow();

                line["prod_id"] = prod.Id;
                line["prod_name"] = prod.Name;
                line["prod_complement"] = prod.Complement;
                line["prod_inventory"] = prod.Inventory;
                line["prod_category"] = prod.Prod_category;
                line["prod_brand"] = prod.Prod_brand;
                line["prod_value"] = prod.Value;
                line["prod_created_at"] = prod.Created_at;

                dtProduct.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtProduct);
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
