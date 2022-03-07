using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    class Product 
    {
        private int id;
        private string name;
        private int inventory;
        private int prod_category;
        private int prod_brand;
        private string complement;
        private double value;
        private DateTime created_at;

        public Product()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Inventory { get => inventory; set => inventory = value; }
        public int Prod_category { get => prod_category; set => prod_category = value; }
        public int Prod_brand { get => prod_brand; set => prod_brand = value; }
        public string Complement { get => complement; set => complement = value; }
        public double Value { get => value; set => this.value = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
    }
}
