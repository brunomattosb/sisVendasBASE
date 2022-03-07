using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    class Expense
    {
        private int id;
        private string name;
        private string description;
        private double value;
        private int exp_type;
        private DateTime created_at;

        public Expense()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Value { get => value; set => this.value = value; }
        public int Exp_type { get => exp_type; set => exp_type = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
    }
}
