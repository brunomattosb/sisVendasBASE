using System;

namespace sisVendas.Models
{
    class Caixa
    {

        private int id;
        private Funcionario func;
        private DateTime dtAbertura;
        private Nullable<DateTime> dtfechamento;
        private double saldoAnterior;
        private double entradas;
        private double saidas;

        public Caixa()
        {
            func = new Funcionario();
        }

        public int Id { get => id; set => id = value; }
        public Funcionario Funcionario { get => func; set => func = value; }
        public DateTime DtAbertura { get => dtAbertura; set => dtAbertura = value; }
        public Nullable<DateTime> Dtfechamento { get => dtfechamento; set => dtfechamento = value; }
        public double SaldoAnterior { get => saldoAnterior; set => saldoAnterior = value; }
        public double Entradas { get => entradas; set => entradas = value; }
        public double Saidas { get => saidas; set => saidas = value; }
    }
}
