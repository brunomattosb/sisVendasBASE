using System;

namespace sisVendas.Models
{
    internal class ItenCompra
    {
        private int id;
        private double quantidade;
        private int id_compra;
        private string id_produto;
        private double valor;

        public ItenCompra()
        {
        }

        public int Id { get => id; set => id = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        public int Id_compra { get => id_compra; set => id_compra = value; }
        public string Id_produto { get => id_produto; set => id_produto = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
