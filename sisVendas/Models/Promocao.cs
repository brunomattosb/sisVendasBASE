using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    internal class Promocao
    {
        private int id;
        private string nome;
        private DateTime dtInicio;
        private DateTime dtFim;
        private DateTime criado_em;

        public Promocao()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DtInicio { get => dtInicio; set => dtInicio = value; }
        public DateTime DtFim { get => dtFim; set => dtFim = value; }
        public DateTime Criado_em { get => criado_em; set => criado_em = value; }
    }
}
