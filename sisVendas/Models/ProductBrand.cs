using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    class ProductBrand
    {
        private int id;
        private string name;
        private DateTime created_at;

        public ProductBrand()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
    }
}
