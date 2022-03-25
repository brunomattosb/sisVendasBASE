using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    public class Employee
    {
        private int id;
        private string name;
        private string email;
        private string rg;
        private string telephone;
        private string cpf;
        private string zip_code;
        private string address;
        private string district;
        private string uf;
        private string city;
        private DateTime birth_at;
        private DateTime created_at;
        private char sex;
        private double base_salary;
        private string username;
        private string password;
        private string licence;
        private DateTime admission;
        private DateTime resignation;

        public Employee()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Zip_code { get => zip_code; set => zip_code = value; }
        public string Address { get => address; set => address = value; }
        public string District { get => district; set => district = value; }
        public string Uf { get => uf; set => uf = value; }
        public string City { get => city; set => city = value; }
        public DateTime Birth_at { get => birth_at; set => birth_at = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public char Sex { get => sex; set => sex = value; }
        public double Base_salary { get => base_salary; set => base_salary = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Licence { get => licence; set => licence = value; }
        public DateTime Admission { get => admission; set => admission = value; }
        public DateTime Resignation { get => resignation; set => resignation = value; }
    }
}