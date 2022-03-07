using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    class Provider
    {
        private int id;
        private string cpf_cnpj;
        private string rg_ie;
        private string name;
        private string fantasy_name;
        private string address;
        private string city; 
        private string district;
        private string zip_code;
        private string uf;
        private string telephone;
        private string email;
        private DateTime created_at;

        public Provider()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public string Rg_ie { get => rg_ie; set => rg_ie = value; }
        public string Name { get => name; set => name = value; }
        public string Fantasy_name { get => fantasy_name; set => fantasy_name = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string District { get => district; set => district = value; }
        public string Zip_code { get => zip_code; set => zip_code = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
    }
}
