using System;       

namespace sisVendas.Models
{
    class ProdutoCategoria
    {
        private int id;
        private string nome;
        private DateTime criado_em;

        public ProdutoCategoria()
        {
        }

        public ProdutoCategoria(int id)
        {
            this.id = id;
        }

        public ProdutoCategoria(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Criado_em { get => criado_em; set => criado_em = value; }
    }
}
