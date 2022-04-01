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
        private int idCaixa;
        private int id;

        public ParcelaVenda(){}

        public ParcelaVenda(int id_venda, double valor, DateTime data, string status, char tipo_pagamento, int idCaixa, int id)
        {
            this.id_venda = id_venda;
            this.valor = valor;
            this.data = data;
            this.status = status;
            this.tipo_pagamento = tipo_pagamento;
            this.idCaixa = idCaixa;
            this.id = id;
        }

        public int Cod_venda { get => id_venda; set => id_venda = value; }
        public double Valor { get => valor; set => valor = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Status { get => status; set => status = value; }
        public char Tipo_pagamento { get => tipo_pagamento; set => tipo_pagamento = value; }
        public int IdCaixa { get => idCaixa; set => idCaixa = value; }
        public int Id { get => id; set => id = value; }
    }
}
