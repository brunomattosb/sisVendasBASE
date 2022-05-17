using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Controllers
{
    class ctrlVenda
    {
        private Banco dataBase = new Banco();

        private Vendas vendaSelecionada = new Vendas();
        private ctrlItensVenda controlItensVenda = new ctrlItensVenda();
        private ctrlParcelasVenda controlParcelas = new ctrlParcelasVenda();
        private ctrlProduct controlProdutos = new ctrlProduct();

        public bool SalvarVenda(int id_cliente, DataTable dtParcelas, DataTable dtProdutos, double desconto, int idCaixa, int idFunc)
        { 
            bool res = true;

            vendaSelecionada.Id_cliente = id_cliente;
            vendaSelecionada.ItensVenda = dtProdutos;
            vendaSelecionada.ParcelasVenda = dtParcelas;
            vendaSelecionada.Desconto = desconto;
            vendaSelecionada.Id_funcionario = idFunc;

            dataBase.Conecta();

            VendaDB venda = new VendaDB(dataBase);

            vendaSelecionada.Id = venda.Gravar(vendaSelecionada);
            
            if (vendaSelecionada.Id != 0)
            {
                ctrlProduct controlProduto = new ctrlProduct();

                foreach (DataRow row in dtProdutos.Rows)
                {
                    if(!controlItensVenda.SalvarItensVenda(
                            vendaSelecionada.Id,
                            row["cod"].ToString(),
                            double.Parse(row["amount"].ToString())
                    ))
                    {
                        res = false;
                    }
                    

                }

                foreach (DataRow row in dtParcelas.Rows)
                {
                    double valor = double.Parse(row["valor"].ToString());
                    if (!controlParcelas.SalvarParcela(
                        vendaSelecionada.Id,
                        valor,
                        row["tipo_pagamento"].ToString(),
                        DateTime.Parse(row["data"].ToString()),
                        idCaixa))
                    {
                        
                        res = false;
                        
                    }

                }

            }
            else
            {
                res = false;
                MessageBox.Show("Erro ao gravar venda!");
            }

            if (!res)
            {
                MessageBox.Show(vendaSelecionada.Id + "Venda a ser excluida");
                controlItensVenda.removerItensVenda(vendaSelecionada.Id);
                controlParcelas.removerParcelas(vendaSelecionada.Id);
                this.removerVenda(vendaSelecionada.Id, dtProdutos);
            }

            
            dataBase.Desconecta();

            return (res);
        }
        public DataTable buscarVendas(string filter)
        {
            
            dataBase.Conecta();

            VendaDB vendaDB = new VendaDB(dataBase);

            DataTable dtVendas = vendaDB.buscar(filter);

            dataBase.Desconecta();

            return (dtVendas);
        }
        public bool removerVenda(int cod, DataTable dttProduto)
        {
            bool res = true;
            dataBase.Conecta();
            VendaDB vendaDB = new VendaDB(dataBase);
            res = vendaDB.remover(cod);
            if (res)
            {
                foreach (DataRow prod in dttProduto.Rows)
                {

                    controlProdutos.adicionarEstoque(prod["cod"].ToString(), double.Parse(prod["amount"].ToString()));
                }
            }
            dataBase.Desconecta();
            return res;
        }
        public bool restabelecerVenda(int cod, DataTable dttProduto)
        {
            bool res = true;
            dataBase.Conecta();
            VendaDB vendaDB = new VendaDB(dataBase);
            res = vendaDB.restabelecer(cod);
            if (res)
            {
                foreach (DataRow prod in dttProduto.Rows)
                {

                    controlProdutos.removerEstoque(prod["cod"].ToString(), double.Parse(prod["amount"].ToString()));
                }
            }
            dataBase.Desconecta();
            return res;
        }
        

        public Vendas buscarVendaPorCod(int idVenda)
        {
           
            Vendas venda = new Vendas();

            dataBase.Conecta();
            VendaDB bd = new VendaDB(dataBase);
            venda = (Vendas)bd.buscarVendaPorCod(idVenda);

            dataBase.Desconecta();
            return venda;
            
        }
    }
}
