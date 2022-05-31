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
    internal class ctrlParcelasCompra
    {
        private Banco dataBase = new Banco();
     
        private ParcelaCompra parcelaSelecionada = new ParcelaCompra();


        public bool SalvarParcela(int id_compra, double valor, string tipo, DateTime dataVencimento, int idCaixa)
        {

            parcelaSelecionada.IdCompra = id_compra;
            parcelaSelecionada.Valor = valor;
            parcelaSelecionada.IdCaixa = idCaixa;
            parcelaSelecionada.DataPagamento = DateTime.Now;
            parcelaSelecionada.DataVencimento = dataVencimento;

            if (tipo == "Dinheiro")
            {
                parcelaSelecionada.Tipo_pagamento = 'M';
            }
            else if (tipo == "Débito")
            {
                parcelaSelecionada.Tipo_pagamento = 'D';
                
            }
            else if (tipo == "Crédito")
            {
                parcelaSelecionada.Tipo_pagamento = 'C';
            }
            else
            {
                parcelaSelecionada.Tipo_pagamento = 'F';
                parcelaSelecionada.DataPagamento = null;
            }

            dataBase.Conecta();
            bool result = false;
            ParcelaCompraDB parcelaCompra = new ParcelaCompraDB(dataBase);

            result = parcelaCompra.Gravar(parcelaSelecionada);

            dataBase.Desconecta();

            return (result);
        }
        public bool estornarParcela(int idParcela)
        {

            dataBase.Conecta();
            bool result = false;
            ParcelaCompraDB parcelaCompra = new ParcelaCompraDB(dataBase);

            result = parcelaCompra.estornarParcela(idParcela);

            dataBase.Desconecta();

            return (result);
        }
        public DataTable buscarParcelasPorIdCaixa(int idCaixa)
        {

            DataTable dtParcelas = new DataTable();

            dtParcelas.Columns.Add("id", typeof(int));
            dtParcelas.Columns.Add("idCaixa", typeof(int));
            dtParcelas.Columns.Add("idCompra", typeof(int));
            dtParcelas.Columns.Add("valor", typeof(double));
            dtParcelas.Columns.Add("tipo");
            dtParcelas.Columns.Add("data", typeof(DateTime));

            dataBase.Conecta();
            ParcelaCompraDB parcelaDB = new ParcelaCompraDB(dataBase);
            foreach (ParcelaCompra parcela in parcelaDB.buscarParcelasPorIdCaixa(idCaixa))
            {
                DataRow line = dtParcelas.NewRow();

                line["id"] = parcela.Id;
                line["idCompra"] = parcela.IdCompra;
                line["valor"] = parcela.Valor;
                line["data"] = parcela.DataPagamento;
                line["tipo"] = parcela.Tipo_pagamento;
                line["idCaixa"] = parcela.IdCaixa;

                dtParcelas.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtParcelas);
        }
        public bool quitarParcela(int idParcela, double valorParcela, double valorPago, int idCaixa, int idVenda, string tipo, string despesaTipo)//, string tipo, int idCaixa)
        {
            dataBase.Conecta();
            bool result = false;
            
            char tipoPagamento;
            if (tipo == "Dinheiro")
            {
                tipoPagamento = 'M';
            }
            else if (tipo == "Fiado")
            {
                tipoPagamento = 'F';
            }
            else if (tipo == "Crédito")
            {
                tipoPagamento = 'C';
            }
            else
            {
                tipoPagamento = 'D';
            }

            if (despesaTipo == "Despesa")
            {
                DespesaDB despesaDB = new DespesaDB(dataBase);
                result = despesaDB.quitarDespesa(idParcela, tipoPagamento, idCaixa);
            }
            else // ContaAPagar
            {
                ParcelaCompraDB parcelaCompra = new ParcelaCompraDB(dataBase);
                result = parcelaCompra.quitarParcela(idParcela, tipoPagamento, idCaixa);
            }

            dataBase.Desconecta();
            return (result);
        }
        public DataTable buscarParaRelatorio(string filtro)
        {


            dataBase.Conecta();

            // buscar Parcelas Compras
            ParcelaCompraDB parcDB = new ParcelaCompraDB(dataBase);

            DataTable dtExpense = parcDB.buscarParcelasAPagarParaRelatorio(filtro);
            
            dataBase.Desconecta();

            return (dtExpense);
        }
        public DataTable buscarParcelasAPagar(string filtro)
        {

            DataTable dtExpense = new DataTable();

            dtExpense.Columns.Add("id", typeof(int));
            dtExpense.Columns.Add("dtPagamento", typeof(DateTime));
            dtExpense.Columns.Add("dtVencimento", typeof(DateTime));
            dtExpense.Columns.Add("formaPagamento"); // "M/D/C/F"
            dtExpense.Columns.Add("caixaId", typeof(int));
            dtExpense.Columns.Add("valor", typeof(double));
            dtExpense.Columns.Add("idVenda", typeof(int));
            dtExpense.Columns.Add("descricao");

            dataBase.Conecta();

            // buscar Parcelas Compras
            ParcelaCompraDB parcDB = new ParcelaCompraDB(dataBase);

            foreach (ParcelaCompra parc in parcDB.BuscarParcelasAPagar(filtro))
            {

                DataRow line = dtExpense.NewRow();

                if (parc.Tipo_pagamento == 'M')
                {
                    line["formaPagamento"] = "Dinheiro";
                }
                else if (parc.Tipo_pagamento == 'D')
                {
                    line["formaPagamento"] = "Débito";
                }
                else if (parc.Tipo_pagamento == 'C')
                {
                    line["formaPagamento"] = "Crédito";
                }
                else
                {
                    line["formaPagamento"] = "À Pagar";
                }

                line["id"] = parc.Id;
                line["valor"] = parc.Valor;
                line["descricao"] = "Compra realizada";
                line["idVenda"] = parc.IdCompra;
                line["caixaId"] = parc.IdCaixa;
                line["dtVencimento"] = parc.DataVencimento;

                if (parc.DataPagamento == null)
                {
                    line["dtPagamento"] = DBNull.Value;
                }
                else
                {
                    line["dtPagamento"] = parc.DataPagamento;
                }

                dtExpense.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtExpense);
        }
        public DataTable buscarParcelas(int codVenda)
        {

            DataTable dtParcelas = new DataTable();

            dtParcelas.Columns.Add("id", typeof(int));
            dtParcelas.Columns.Add("idCaixa", typeof(int));
            dtParcelas.Columns.Add("idCompra", typeof(int));
            dtParcelas.Columns.Add("valor", typeof(double));
            dtParcelas.Columns.Add("tipo_pagamento");
            dtParcelas.Columns.Add("dataPagamento", typeof(DateTime));
            dtParcelas.Columns.Add("dataVencimento", typeof(DateTime));

            dataBase.Conecta();
            ParcelaCompraDB parcelaDB = new ParcelaCompraDB(dataBase);
            foreach (ParcelaCompra parcela in parcelaDB.buscarParcelasPorIdCompra(codVenda))
            {

                DataRow line = dtParcelas.NewRow();
                line["id"] = parcela.Id;
                line["idCompra"] = parcela.IdCompra;
                line["valor"] = parcela.Valor;
                if(parcela.DataPagamento == null)
                {
                    line["dataPagamento"] = DBNull.Value;
                }
                else {
                    line["dataPagamento"] = parcela.DataPagamento; 
                }
                line["dataVencimento"] = parcela.DataVencimento;
                
                
                
                line["idCaixa"] = parcela.IdCaixa;
                
                char tipo = parcela.Tipo_pagamento;
                if (tipo == 'M')
                {
                    line["tipo_pagamento"] = "Dinheiro";
                }
                else if( tipo == 'D')
                {
                    line["tipo_pagamento"] = "Débito";
                }else if(tipo == 'C')
                {
                    line["tipo_pagamento"] = "Crédito";
                }else
                {
                    line["tipo_pagamento"] = "A Pagar";
                }

                dtParcelas.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtParcelas);
        }
    }
}
