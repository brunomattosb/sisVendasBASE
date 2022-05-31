using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Data;
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
        private ctrlCliente controlCliente = new ctrlCliente();

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
                    if (controlParcelas.SalvarParcela(
                        vendaSelecionada.Id,
                        valor,
                        row["tipo_pagamento"].ToString(),
                        DateTime.Parse(row["data"].ToString()),
                        idCaixa))
                    {

                        if(row["tipo_pagamento"].ToString() == "Saldo")
                        {
                            controlCliente.removerSaldo(vendaSelecionada.Id_cliente, valor);
                        }


                    }
                    else
                    {
                        res = false;

                    }

                }

            }
            else
            {
                res = false;
                MessageBox.Show("Erro ao gravar venda!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!res)
            {
                
                this.exclusaoFisicaDaVeda(vendaSelecionada.Id, dtProdutos);
            }

            
            dataBase.Desconecta();

            return (res);
        }


        public int verificarMesmoCaixa(int idVenda)
        {
            int res =0;
            dataBase.Conecta();
            VendaDB vendaDB = new VendaDB(dataBase);
            DataTable dt = vendaDB.verificarMesmoCaixa(idVenda);
            int count = dt.Rows.Count;
            if (count != 1)
            {
                return res;
            }else
            {

                res = int.Parse(dt.Rows[0]["parcela_idCaixa"].ToString());
                
            }
            dataBase.Desconecta();
            return res;
        }
        
        public DataTable buscarVendas(string filter)
        {
            
            dataBase.Conecta();

            VendaDB vendaDB = new VendaDB(dataBase);

            DataTable dtVendas = vendaDB.buscar(filter);

            dataBase.Desconecta();

            return (dtVendas);
        }
        public DataTable buscarParaRelatorio(string filter)
        {

            dataBase.Conecta();

            VendaDB vendaDB = new VendaDB(dataBase);

            DataTable dtVendas = vendaDB.buscarParaRelatorio(filter);

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
        public bool exclusaoFisicaDaVeda(int cod, DataTable dttProduto)
        {
            bool res = true;
            dataBase.Conecta();
            VendaDB vendaDB = new VendaDB(dataBase);

            //adicionar estoque
            //if (res)
            //{
            
            foreach (DataRow prod in dttProduto.Rows)
            {
                controlProdutos.adicionarEstoque(prod["cod"].ToString(), double.Parse(prod["amount"].ToString()));
            }
            controlItensVenda.removerItensVenda(cod);
            controlParcelas.removerParcelas(cod);
            //}
            res = vendaDB.removerFisica(cod);


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
