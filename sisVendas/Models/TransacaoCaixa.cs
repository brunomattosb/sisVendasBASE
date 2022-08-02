using System;

namespace sisVendas.Models
{
    public class TransacaoCaixa
    {
        private int id;
        private int idCaixa;
        private char tipo;
        private string descricao;
        private DateTime hora;
        private double valor;
        public TransacaoCaixa()
        {

        }

        public TransacaoCaixa(int id, int idCaixa, char tipo, string descricao, DateTime hora, double valor)
        {
            this.id = id;
            this.idCaixa = idCaixa;
            this.tipo = tipo;
            this.descricao = descricao;
            this.hora = hora;
            this.valor = valor;
        }

        public int Id { get => id; set => id = value; }
        public int IdCaixa { get => idCaixa; set => idCaixa = value; }
        public char Tipo { get => tipo; set => tipo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
