using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Controllers
{
    internal class ctrlDespesa
    {
        private Banco dataBase = new Banco();
        private Despesa CurrentExpense = new Despesa();

        public bool SalvarDespesa(string id, string descricao, double valor, int tipo, int caixaId, double desconto, DateTime dataDespesa, string formaPagamento, DateTime dataVecimento, string status)
        {
            if (Int32.TryParse(id, out int number))
                CurrentExpense.Id = number;

            CurrentExpense.Descricao = descricao;
            CurrentExpense.Valor = valor;
            CurrentExpense.IdTipo = tipo;
            CurrentExpense.IdCaixa = caixaId;
            CurrentExpense.Desconto = desconto;
            CurrentExpense.Status = status;
            CurrentExpense.DataReferencia = dataDespesa;
            CurrentExpense.DataPagamento = dataVecimento;

            if (formaPagamento == "Dinheiro")
            {
                CurrentExpense.Forma_pagamento = "M";
            }
            else if (formaPagamento == "Débito")
            {
                CurrentExpense.Forma_pagamento = "D";
            }
            else if (formaPagamento == "Crédito")
            {
                CurrentExpense.Forma_pagamento = "C";
            }
            else
            {
                CurrentExpense.Forma_pagamento = "F";
            }

            dataBase.Conecta();
            bool result = false;
            DespesaDB exp = new DespesaDB(dataBase);
            if (number == 0)
            {
                result = exp.Gravar(CurrentExpense);
            }
            else
            {
                result = exp.Atualizar(CurrentExpense);
            }
            dataBase.Desconecta();

            return (result);
        }
        public bool estornarDespesa(int idDespesa)
        {

            dataBase.Conecta();
            bool result = false;
            DespesaDB despDB = new DespesaDB(dataBase);

            result = despDB.estornarDespesa(idDespesa);

            dataBase.Desconecta();

            return (result);
        }
        public DataTable Buscar(string filtro)
        {

            DataTable dtExpense = new DataTable();
            
            dtExpense.Columns.Add("desp_id", typeof(int));
            dtExpense.Columns.Add("desp_descricao");
            dtExpense.Columns.Add("desp_idTipo", typeof(int));
            dtExpense.Columns.Add("desp_idCaixa", typeof(int));
            dtExpense.Columns.Add("desp_dataPagamento", typeof(DateTime));
            dtExpense.Columns.Add("desp_valor", typeof(double));
            dtExpense.Columns.Add("desp_dataReferencia", typeof(DateTime));
            dtExpense.Columns.Add("desp_desconto", typeof(double));
            dtExpense.Columns.Add("desp_formaPagamento");
            dtExpense.Columns.Add("desp_status");

            dataBase.Conecta();
            DespesaDB expDB = new DespesaDB(dataBase);

            foreach (Despesa exp in expDB.Buscar(filtro))
            {

                DataRow line = dtExpense.NewRow();

                if (exp.Forma_pagamento == "M")
                {
                    line["desp_formaPagamento"] = "Dinheiro";
                }
                else if (exp.Forma_pagamento == "D")
                {
                    line["desp_formaPagamento"] = "Débito";
                }
                else if (exp.Forma_pagamento == "C")
                {
                    line["desp_formaPagamento"] = "Crédito";
                }
                else
                {
                    line["desp_formaPagamento"] = "À Pagar";
                }

                line["desp_id"] = exp.Id;
                line["desp_descricao"] = exp.Descricao;
                line["desp_valor"] = exp.Valor;
                line["desp_idTipo"] = exp.IdTipo;
                line["desp_dataPagamento"] = exp.DataPagamento;
                line["desp_idCaixa"] = exp.IdCaixa;
                line["desp_dataReferencia"] = exp.DataReferencia;
                line["desp_desconto"] = exp.Desconto;
                line["desp_status"] = exp.Status;



                dtExpense.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtExpense);
        }
        public DataTable BuscarPorIdCaixa(int idCaixa)
        {

            DataTable dtExpense = new DataTable();

            dtExpense.Columns.Add("desp_id", typeof(int));
            dtExpense.Columns.Add("desp_descricao");
            dtExpense.Columns.Add("desp_idTipo", typeof(int));
            dtExpense.Columns.Add("desp_idCaixa", typeof(int));
            dtExpense.Columns.Add("desp_dataPagamento", typeof(DateTime));
            dtExpense.Columns.Add("desp_valor", typeof(double));
            dtExpense.Columns.Add("desp_dataReferencia", typeof(DateTime));
            dtExpense.Columns.Add("desp_desconto", typeof(double));
            dtExpense.Columns.Add("desp_formaPagamento");
            dtExpense.Columns.Add("desp_status");

            dataBase.Conecta();
            DespesaDB expDB = new DespesaDB(dataBase);

            foreach (Despesa exp in expDB.BuscarPorIdCaixa(idCaixa))
            {

                DataRow line = dtExpense.NewRow();

                if (exp.Forma_pagamento == "M")
                {
                    line["desp_formaPagamento"] = "Dinheiro";
                }
                else if (exp.Forma_pagamento == "D")
                {
                    line["desp_formaPagamento"] = "Débito";
                }
                else if (exp.Forma_pagamento == "C")
                {
                    line["desp_formaPagamento"] = "Crédito";
                }
                else
                {
                    line["desp_formaPagamento"] = "À Pagar";
                }

                line["desp_id"] = exp.Id;
                line["desp_descricao"] = exp.Descricao;
                line["desp_valor"] = exp.Valor;
                line["desp_idTipo"] = exp.IdTipo;
                line["desp_dataPagamento"] = exp.DataPagamento;
                line["desp_idCaixa"] = exp.IdCaixa;
                line["desp_dataReferencia"] = exp.DataReferencia;
                line["desp_desconto"] = exp.Desconto;
                line["desp_status"] = exp.Status;



                dtExpense.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtExpense);
        }
        public DataTable buscarDespesasAPagar(string filtro)
        {

            DataTable dtExpense = new DataTable();
            
            dtExpense.Columns.Add("id", typeof(int));
            dtExpense.Columns.Add("dtPagamento", typeof(DateTime));
            dtExpense.Columns.Add("dtDespesa", typeof(DateTime));
            dtExpense.Columns.Add("status"); // "DEVE" "PAGO"
            dtExpense.Columns.Add("formaPagamento"); // "M/D/C/F"
            dtExpense.Columns.Add("caixaId", typeof(int));
            dtExpense.Columns.Add("valor", typeof(double));
            dtExpense.Columns.Add("idVenda", typeof(int));
            dtExpense.Columns.Add("descricao");

            dataBase.Conecta();
            // buscar despesas
            DespesaDB expDB = new DespesaDB(dataBase);
            foreach (Despesa exp in expDB.BuscarDespesaParaContasAPagar(filtro))
            {

                DataRow line = dtExpense.NewRow();

                if (exp.Forma_pagamento == "M")
                {
                    line["formaPagamento"] = "Dinheiro";
                }
                else if (exp.Forma_pagamento == "D")
                {
                    line["formaPagamento"] = "Débito";
                }
                else if (exp.Forma_pagamento == "C")
                {
                    line["formaPagamento"] = "Crédito";
                }
                else
                {
                    line["formaPagamento"] = "À Pagar";
                }

                line["id"] = exp.Id;
                line["valor"] = exp.Valor;
                line["descricao"] = exp.Descricao;
                line["idVenda"] = 0;
                line["caixaId"] = exp.IdCaixa;
                line["dtDespesa"] = exp.DataReferencia;
                line["dtPagamento"] = exp.DataPagamento;
                line["status"] = exp.Status;

                dtExpense.Rows.Add(line);
            }
            
            dataBase.Desconecta();

            return (dtExpense);
        }
        public bool RemoverDespesa(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            DespesaDB expDB = new DespesaDB(dataBase);
            res = expDB.Remover(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}
