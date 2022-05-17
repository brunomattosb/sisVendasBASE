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
        private string nome;
        private string email;
        private string nome_fantasia;
        private string rg_ie;
        private string telefone;
        private string cpf_cnpj;
        private string cep;
        private string endereco;
        private string bairro;
        private string uf;
        private string cidade;
        private DateTime dtNascimento;
        private DateTime criado_em;
        private char sexo;
        private double saldo;

        public Cliente()
        {
        }
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Nome_fantasia { get => nome_fantasia; set => nome_fantasia = value; }
        public string Rg_ie { get => rg_ie; set => rg_ie = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public DateTime DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        public DateTime Criado_em { get => criado_em; set => criado_em = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public double Saldo { get => saldo; set => saldo = value; }
    }
}
