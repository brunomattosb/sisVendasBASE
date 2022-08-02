using System;

namespace sisVendas.Models
{
    internal class ItemsPromocao
    {
        private int id;
        private int id_promocao;
        private int id_produto;
        private double valor;

        public ItemsPromocao()
        {
        }

        public int Id { get => id; set => id = value; }
        public int Id_promocao { get => id_promocao; set => id_promocao = value; }
        public int Id_produto { get => id_produto; set => id_produto = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
