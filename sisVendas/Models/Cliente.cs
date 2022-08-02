using NFe.Classes.Informacoes.Destinatario;
using System;

namespace sisVendas.Models
{
    public class Cliente
    {
        private int id;
        private string nome;
        private string email;
        private string nome_fantasia;
        private string rg_ie;
        private string cpf_cnpj;
        private Nullable<DateTime> dtNascimento;
        private char sexo;
        private double saldo;
        private enderDest endereco;
        private DateTime criado_em;

        public Cliente()
        {
            endereco = new enderDest();
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Nome_fantasia { get => nome_fantasia; set => nome_fantasia = value; }
        public string Rg_ie { get => rg_ie; set => rg_ie = value; }
        public string Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public DateTime? DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public enderDest Endereco { get => endereco; set => endereco = value; }
        public DateTime Criado_em { get => criado_em; set => criado_em = value; }
    }
}
