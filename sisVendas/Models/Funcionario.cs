using System;

namespace sisVendas.Models
{
    public class Funcionario
    {
        private int id;
        private string nome;
        private string email;
        private string rg;
        private string telefone;
        private string cpf;
        private string cep;
        private string endereco;
        private string bairro;
        private string uf;
        private string cidade;
        private DateTime dtNascimento;
        private DateTime criado_em;
        private char sexo;
        private double base_salario;
        private string usuario;
        private string senha;
        private string licenca;
        private DateTime admissao;
        private DateTime demissao;
        private bool ativo;

        public Funcionario()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public DateTime DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        public DateTime Criado_em { get => criado_em; set => criado_em = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public double Base_salario { get => base_salario; set => base_salario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Licenca { get => licenca; set => licenca = value; }
        public DateTime Admissao { get => admissao; set => admissao = value; }
        public DateTime Demissao { get => demissao; set => demissao = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}