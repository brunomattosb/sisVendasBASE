using sisVendas.Models.Venda;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    class classVenda
    {
        private int id;
        private int id_cliente;
        private DataTable itensVenda;
        private double desconto;
        private DataTable parcelasVenda;
        private DateTime created_at;

        public classVenda()
        {

        }

        public classVenda(int id, int id_cliente, DataTable itensVenda, double desconto, DataTable parcelasVenda, DateTime created_at)
        {
            this.id = id;
            this.id_cliente = id_cliente;
            this.itensVenda = itensVenda;
            this.desconto = desconto;
            this.parcelasVenda = parcelasVenda;
            this.created_at = created_at;
        }

        public int Id { get => id; set => id = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public DataTable ItensVenda { get => itensVenda; set => itensVenda = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public DataTable ParcelasVenda { get => parcelasVenda; set => parcelasVenda = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
    }
}
