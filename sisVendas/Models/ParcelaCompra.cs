﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    internal class ParcelaCompra
    {
        private int id;
        private int idCompra;
        private double valor;
        private DateTime dataPagamento;
        private DateTime dataReferencia;
        private string status;
        private char tipo_pagamento;
        private int idCaixa;

        public ParcelaCompra()
        {
        }

        public int Id { get => id; set => id = value; }
        public int IdCompra { get => idCompra; set => idCompra = value; }
        public double Valor { get => valor; set => valor = value; }
        public DateTime DataPagamento { get => dataPagamento; set => dataPagamento = value; }
        public string Status { get => status; set => status = value; }
        public char Tipo_pagamento { get => tipo_pagamento; set => tipo_pagamento = value; }
        public int IdCaixa { get => idCaixa; set => idCaixa = value; }
        public DateTime DataReferencia { get => dataReferencia; set => dataReferencia = value; }
    }
}