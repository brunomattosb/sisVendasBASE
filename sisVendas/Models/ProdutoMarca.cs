using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    class ProdutoMarca
    {
        private int id;
        private string nome;
        private DateTime criado_em;

        public ProdutoMarca()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Criado_em { get => criado_em; set => criado_em = value; }
    }
}
