using System;
using System.Data;

namespace sisVendas.Models
{
    internal class Compra
    {
        private int id;
        private int id_fornecedor;
        private int id_caixa;
        private double desconto;
        private bool cancelada;
        private string chave;
        private DateTime data;
        private DateTime created_at;
        private DataTable dttItens;
        private DataTable dttParcelas;

        public Compra()
        {
            
        }

        public int Id { get => id; set => id = value; }
        public int Id_fornecedor { get => id_fornecedor; set => id_fornecedor = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public bool Cancelada { get => cancelada; set => cancelada = value; }
        public string Chave { get => chave; set => chave = value; }
        public DateTime Data { get => data; set => data = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DataTable DttItens { get => dttItens; set => dttItens = value; }
        public DataTable DttParcelas { get => dttParcelas; set => dttParcelas = value; }
        public int Id_caixa { get => id_caixa; set => id_caixa = value; }
    }
}
