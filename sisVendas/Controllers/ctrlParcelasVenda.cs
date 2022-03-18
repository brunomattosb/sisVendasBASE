﻿
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
    class ctrlParcelasVenda
    {
        private Banco dataBase = new Banco();
        private ParcelaVenda parcelaSelecionada = new ParcelaVenda();

        
        public bool SalvarParcela(int id_venda, double valor, string tipo, DateTime data)
        {

            parcelaSelecionada.Cod_venda = id_venda;
            parcelaSelecionada.Valor = valor;
            parcelaSelecionada.Data = data;

            if(tipo == "Dinheiro")
            {
                parcelaSelecionada.Tipo_pagamento = 'M';
            }
            else
            {
                if(tipo == "Fiado")
                {
                    parcelaSelecionada.Tipo_pagamento = 'F';
                }
                else if(tipo == "Crédito")
                {
                    parcelaSelecionada.Tipo_pagamento = 'C';
                }
                else
                {
                    parcelaSelecionada.Tipo_pagamento = 'D';
                }
                
            }
            

            if(tipo == "Fiado")
            {
                parcelaSelecionada.Status = "DEVE";
            }
            else
            {
                parcelaSelecionada.Status = "PAGO";
            }



            dataBase.Conecta();
            bool result = false;
            ParcelaVendaDB parcelaVenda = new ParcelaVendaDB(dataBase);

            result = parcelaVenda.Gravar(parcelaSelecionada);

            dataBase.Desconecta();

            return (result);
        }
        
        public DataTable buscarParcelas(int codVenda)
        {

            DataTable dtParcelas = new DataTable();

            dtParcelas.Columns.Add("id", typeof(int));
            dtParcelas.Columns.Add("idVenda", typeof(int));
            dtParcelas.Columns.Add("valor", typeof(double));
            dtParcelas.Columns.Add("status");
            dtParcelas.Columns.Add("tipo");
            dtParcelas.Columns.Add("dataPagamento", typeof(DateTime));

            dataBase.Conecta();
            ParcelaVendaDB parcelaDB= new ParcelaVendaDB(dataBase);
            foreach (ParcelaVenda parcela in parcelaDB.buscarParcelasPorVenda(codVenda))
            {
                
                DataRow line = dtParcelas.NewRow();

                line["id"] = parcela.Id;
                line["idVenda"] = parcela.Cod_venda;
                line["valor"] = parcela.Valor;
                line["status"] = parcela.Status;
                line["tipo"] = parcela.Tipo_pagamento;
                line["dataPagamento"] = parcela.Data;
               

                dtParcelas.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtParcelas);
        }
        /*
        public Cliente buscarClientePorCpf(string filter)
        {
            Cliente cli = new Cliente();
            dataBase.Conecta();

            ClientDB bd = new ClientDB(dataBase);
            cli = (Cliente)bd.buscarCpf(filter);

            dataBase.Desconecta();
            return cli;
 
        }*/

        /*
        public bool removeClient(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ClientDB clidDB = new ClientDB(dataBase);
            res = clidDB.remove(cod);
            dataBase.Desconecta();
            return res;
        }*/
    }

    
}