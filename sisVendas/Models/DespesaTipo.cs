using System;

namespace sisVendas.Models
{
    class DespesaTipo
    {
        private int id;
        private string nome;
        private DateTime created_at;

        public DespesaTipo()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
    }
}
