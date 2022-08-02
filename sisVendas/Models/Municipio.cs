using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    public class Municipio
    {
        private int cod;
        private string nome;

        public Municipio()
        {
        }

        public int Cod { get => cod; set => cod = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
