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
        private double suprimento;
        private double sangria;

        public Caixa()
        {

        }
        public Caixa(int id, int idFunc, DateTime dtAbertura, Nullable<DateTime> dtfechamento, double valorAbertura, double entradas, double saidas, double suprimento, double sangria)
        {
            this.id = id;
            this.idFunc = idFunc;
            this.dtAbertura = dtAbertura;
            this.dtfechamento = dtfechamento;
            this.saldoAnterior = valorAbertura;
            this.entradas = entradas;
            this.saidas = saidas;
            this.suprimento = suprimento;
            this.sangria = sangria;
        }
        public Caixa(int idFunc, DateTime dtAbertura, Nullable<DateTime> dtfechamento, double valorAbertura, double entradas, double saidas, double suprimento, double sangria)
        {
            this.idFunc = idFunc;
            this.dtAbertura = dtAbertura;
            this.dtfechamento = dtfechamento;
            this.saldoAnterior = valorAbertura;
            this.entradas = entradas;
            this.saidas = saidas;
            this.suprimento = suprimento;
            this.sangria = sangria;
        }

        public int Id { get => id; set => id = value; }
        public int IdFunc { get => idFunc; set => idFunc = value; }
        public DateTime DtAbertura { get => dtAbertura; set => dtAbertura = value; }
        public Nullable<DateTime> Dtfechamento { get => dtfechamento; set => dtfechamento = value; }
        public double SaldoAnterior { get => saldoAnterior; set => saldoAnterior = value; }
        public double Entradas { get => entradas; set => entradas = value; }
        public double Saidas { get => saidas; set => saidas = value; }
        public double Suprimento { get => suprimento; set => suprimento = value; }
        public double Sangria { get => sangria; set => sangria = value; }
    }
}
