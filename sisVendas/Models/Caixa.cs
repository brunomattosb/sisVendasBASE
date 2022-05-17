using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    public class Caixa
    {

        private int id;
        private int idFunc;
        private DateTime dtAbertura;
        private Nullable<DateTime> dtfechamento;
        private double saldoAnterior;
        private double entradas;
        private double saidas;

        public Caixa()
        {

        }

        public int Id { get => id; set => id = value; }
        public int IdFunc { get => idFunc; set => idFunc = value; }
        public DateTime DtAbertura { get => dtAbertura; set => dtAbertura = value; }
        public Nullable<DateTime> Dtfechamento { get => dtfechamento; set => dtfechamento = value; }
        public double SaldoAnterior { get => saldoAnterior; set => saldoAnterior = value; }
        public double Entradas { get => entradas; set => entradas = value; }
        public double Saidas { get => saidas; set => saidas = value; }
    }
}
