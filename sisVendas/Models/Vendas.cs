using sisVendas.Models.Venda;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Models
{
    public class Vendas
    {
        private int id;
        private int id_cliente;
        private int id_funcionario;
        private DataTable itensVenda;
        private double desconto;
        private bool venda_cancelada;
        private DataTable parcelasVenda;
        private DateTime created_at;

        public Vendas()
        {

        }

        public int Id { get => id; set => id = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public DataTable ItensVenda { get => itensVenda; set => itensVenda = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public DataTable ParcelasVenda { get => parcelasVenda; set => parcelasVenda = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public bool Venda_cancelada { get => venda_cancelada; set => venda_cancelada = value; }
        public int Id_funcionario { get => id_funcionario; set => id_funcionario = value; }
    }
}
