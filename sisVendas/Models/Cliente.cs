using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    public class Cliente
    {
        private int id;
        private string name;
        private string email;
        private string fantasy_name;
        private string rg_ie;
        private string telephone;
        private string cpf_cnpj;
        private string zip_code;
        private string address;
        private string district;
        private string uf;
        private string city;
        private DateTime birth_at;
        private DateTime created_at;
        private char sex;
        private double balance;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Fantasy_name { get => fantasy_name; set => fantasy_name = value; }
        public string Rg_ie { get => rg_ie; set => rg_ie = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public string Zip_code { get => zip_code; set => zip_code = value; }
        public string Address { get => address; set => address = value; }
        public string District { get => district; set => district = value; }
        public string Uf { get => uf; set => uf = value; }
        public string City { get => city; set => city = value; }
        public DateTime Birth_at { get => birth_at; set => birth_at = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public char Sex { get => sex; set => sex = value; }
        public double Balance { get => balance; set => balance = value; }

        public Cliente(int id, string name, string email, string fantasy_name, string rg_ie, string telephone, string cpf_cnpj, string zip_code, string address, string district, string uf, string city, DateTime birth_at, DateTime created_at, char sex, double balance)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.fantasy_name = fantasy_name;
            this.rg_ie = rg_ie;
            this.telephone = telephone;
            this.cpf_cnpj = cpf_cnpj;
            this.zip_code = zip_code;
            this.address = address;
            this.district = district;
            this.uf = uf;
            this.city = city;
            this.birth_at = birth_at;
            this.created_at = created_at;
            this.sex = sex;
            this.balance = balance;
        }

        public Cliente()
        {
        }
    }
}
