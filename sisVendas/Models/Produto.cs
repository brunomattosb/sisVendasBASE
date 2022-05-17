using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    class Produto 
    {
        private string id;
        private string nome;
        private int estoque;
        private int prod_Categoria;
        private int prod_Marca;
        private string descricao;
        private double valor;
        private DateTime criado_em;
        private string un;

        public Produto()
        {
        }

        public string Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Estoque { get => estoque; set => estoque = value; }
        public int Prod_Categoria { get => prod_Categoria; set => prod_Categoria = value; }
        public int Prod_Marca { get => prod_Marca; set => prod_Marca = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Valor { get => valor; set => valor = value; }
        public DateTime Criado_em { get => criado_em; set => criado_em = value; }
        public string Un { get => un; set => un = value; }
    }
}
