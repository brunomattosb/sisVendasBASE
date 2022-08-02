using System;

namespace sisVendas.Models
{
    public class ParcelaVenda
    {
        private int id_venda;
        private double valor;
        private Nullable<DateTime> dataVencimento;
        private Nullable<DateTime> dataPagamento;
        private char tipo_pagamento;
        private int idCaixa;
        private int id;

        public ParcelaVenda(){}


        public int Cod_venda { get => id_venda; set => id_venda = value; }
        public double Valor { get => valor; set => valor = value; }
        public char Tipo_pagamento { get => tipo_pagamento; set => tipo_pagamento = value; }
        public int IdCaixa { get => idCaixa; set => idCaixa = value; }
        public int Id { get => id; set => id = value; }
        public DateTime? DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public DateTime? DataPagamento { get => dataPagamento; set => dataPagamento = value; }
    }
}
