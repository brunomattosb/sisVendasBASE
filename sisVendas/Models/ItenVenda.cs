﻿using System;

namespace sisVendas.Models.Venda
{
    internal class ItenVenda
    {
        private int id;
        private double quantidade;
        private int id_venda;
        private string id_produto;
        private double valor;

        public ItenVenda()
        {

        }

        public ItenVenda(int id, double quantidade, int id_venda, string id_produto)
        {
            this.id = id;
            this.quantidade = quantidade;
            this.id_venda = id_venda;
            this.id_produto = id_produto;
        }

        public int Id { get => id; set => id = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        public int Id_venda { get => id_venda; set => id_venda = value; }
        public string Id_produto { get => id_produto; set => id_produto = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
