using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    public class Despesa
    {
        private int id;
        private string descricao;
        private double valor;
        private int idTipo;
        private int idCaixa;
        private Nullable<DateTime> dataReferencia;
        private double desconto;
        private Nullable<DateTime> dataPagamento;
        private Nullable<DateTime> dataVencimento;
        private string forma_pagamento;
        private string tipo;

        public Despesa()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Valor { get => valor; set => valor = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
        public int IdCaixa { get => idCaixa; set => idCaixa = value; }
        public Nullable<DateTime> DataReferencia { get => dataReferencia; set => dataReferencia = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public Nullable<DateTime> DataPagamento { get => dataPagamento; set => dataPagamento = value; }
        public string Forma_pagamento { get => forma_pagamento; set => forma_pagamento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public Nullable<DateTime> DataVencimento { get => dataVencimento; set => dataVencimento = value; }
    }
}
