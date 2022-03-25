using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    public class ParcelaVenda
    {
        private int id_venda;
        private double valor;
        private DateTime data; 
        private string status;
        private char tipo_pagamento;

        public ParcelaVenda( int cod_venda, double valor, DateTime data, string status, char tipo_pagamento)
        {

            this.id_venda = cod_venda;
            this.valor = valor;
            this.data = data;
            this.status = status;
            this.tipo_pagamento = tipo_pagamento;
        }
        public ParcelaVenda(double valor, char tipo_pagamento)
        {
            this.valor = valor;
            this.tipo_pagamento = tipo_pagamento;
        }
        public ParcelaVenda(){}

        public int Cod_venda { get => id_venda; set => id_venda = value; }
        public double Valor { get => valor; set => valor = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Status { get => status; set => status = value; }
        public char Tipo_pagamento { get => tipo_pagamento; set => tipo_pagamento = value; }
    }
}
