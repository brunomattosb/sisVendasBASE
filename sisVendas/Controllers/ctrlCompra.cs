using sisVendas.Controllers;
using sisVendas.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace sisVendas.Persistence
{
    internal class ctrlCompra
    {
        private Banco dataBase = new Banco();

        private Compra compraSelecionada = new Compra();
        private ctrlItensCompra controlItensCompra = new ctrlItensCompra();
        private ctrlParcelasCompra controlParcelas = new ctrlParcelasCompra();
        private ctrlProduct controlProdutos = new ctrlProduct();
        
        //private ctrlTransacaoCaixa controlTransacao = new ctrlTransacaoCaixa();
        
        public bool SalvarCompra(DataTable dttParcelas, DataTable dttProdutos, int id_fornecedor, double desconto, string chave, DateTime dtCompra, int idCaixa )
        {

            bool res = true;

            compraSelecionada.Id_fornecedor = id_fornecedor;
            compraSelecionada.Desconto = desconto;
            compraSelecionada.Chave = chave;
            compraSelecionada.Data = dtCompra;
            compraSelecionada.Id_caixa = idCaixa;

            dataBase.Conecta();

            CompraDB compra = new CompraDB(dataBase);

            compraSelecionada.Id = compra.Gravar(compraSelecionada);


            if (compraSelecionada.Id != 0)
            {
                ctrlProduct controlProduto = new ctrlProduct();
                foreach (DataRow row in dttProdutos.Rows)
                {

                    double.TryParse(row["iten_quantidade"].ToString(), out double quantidade);
                    if (controlItensCompra.SalvarItensCompra(
                            compraSelecionada.Id,
                            row["iten_idProduto"].ToString(),
                            quantidade,
                            double.Parse(row["iten_valor"].ToString().Replace("R$ ",""))
                            ))
                    {
                        controlProduto.adicionarEstoque(row["iten_idProduto"].ToString(), quantidade);
                    }
                    else
                    {
                        res = false;
                    }

                }

                foreach (DataRow row in dttParcelas.Rows)
                {
                    double valor = double.Parse(row["valor"].ToString());

                    if (!controlParcelas.SalvarParcela(
                        compraSelecionada.Id,
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
                MessageBox.Show("Erro ao gravar venda!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*if (!res)
            {
                controlItensVenda.removerItensVenda(vendaSelecionada.Id);
                controlParcelas.removerParcelas(vendaSelecionada.Id);
                this.removerVenda(vendaSelecionada.Id);
            }*/


            dataBase.Desconecta();

            return (res);
        }
        public DataTable buscarCompra(string filter)
        {

            dataBase.Conecta();

            CompraDB compraDB = new CompraDB(dataBase);

            DataTable dttCompras = compraDB.buscar(filter);

            dataBase.Desconecta();

            return (dttCompras);
        }
        public bool removerCompra(int cod, DataTable dttProduto)
        {
            bool res = true;
            dataBase.Conecta();
            CompraDB compraDB = new CompraDB(dataBase);
            res = compraDB.remover(cod);
            
            if (res)
            {
                foreach (DataRow prod in dttProduto.Rows)
                {
                    controlProdutos.removerEstoque(prod["iten_idProduto"].ToString(), double.Parse(prod["iten_quantidade"].ToString()));
                }
            }
            dataBase.Desconecta();
            return res;
        }
        public bool restabelecerCompra(int cod, DataTable dttProduto)
        {
            bool res = true;
            dataBase.Conecta();
            CompraDB compraDB = new CompraDB(dataBase);
            res = compraDB.restabelecer(cod);
            if (res)
            {
                foreach (DataRow prod in dttProduto.Rows)
                {
                    controlProdutos.adicionarEstoque(prod["iten_idProduto"].ToString(), double.Parse(prod["iten_quantidade"].ToString()));
                }
            }
            dataBase.Desconecta();
            return res;
        }
        /*
        public bool removerVenda(int cod)
        {
            bool res = true;
            dataBase.Conecta();
            VendaDB vendaDB = new VendaDB(dataBase);
            res = vendaDB.remover(cod);
            dataBase.Desconecta();
            return res;
        }
        public bool restabelecerVenda(int cod)
        {
            bool res = true;
            dataBase.Conecta();
            VendaDB vendaDB = new VendaDB(dataBase);
            res = vendaDB.restabelecer(cod);
            dataBase.Desconecta();
            return res;
        }

        */
        public Compra buscarCompra(int idVenda)
        {
            
            Compra compra = new Compra();
            ctrlItensCompra controlItensCompra = new ctrlItensCompra();
            ctrlParcelasCompra controlParcelas = new ctrlParcelasCompra();

            dataBase.Conecta();
            CompraDB bd = new CompraDB(dataBase);
            compra = (Compra)bd.buscarCompraPorCod(idVenda);
            compra.DttItens = controlItensCompra.buscarItens(idVenda);
            compra.DttParcelas = controlParcelas.buscarParcelas(idVenda);

            dataBase.Desconecta();
            return compra;

        }
    }
}
