using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    public class ConfigImpressoraCodBarras
    {
        private string nomeImpressora;
        private int xCodigo;
        private int yCodigo;
        private int xTexto;
        private int yTexto;
        private int altura;

        public string NomeImpressora { get => nomeImpressora; set => nomeImpressora = value; }
        public int XCodigo { get => xCodigo; set => xCodigo = value; }
        public int YCodigo { get => yCodigo; set => yCodigo = value; }
        public int XTexto { get => xTexto; set => xTexto = value; }
        public int YTexto { get => yTexto; set => yTexto = value; }
        public int Altura { get => altura; set => altura = value; }
    }
}
