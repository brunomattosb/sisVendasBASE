
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
    class ctrlCaixa
    {
        private Banco dataBase = new Banco();
        private Caixa caixaSelecionado = new Caixa();

        public bool AbrirCaixa(int codFunc, double saldoAnterior, string suprimentos, string sangria)
        {

            // Verifica se existe um numero no tbCod
            //if (Int32.TryParse(id, out int number))
            //    CurrentClient.Id = number;

            caixaSelecionado.IdFunc = codFunc;
            caixaSelecionado.SaldoAnterior = (saldoAnterior);
            caixaSelecionado.Suprimento = double.Parse(suprimentos);
            caixaSelecionado.Sangria = double.Parse(sangria);


            dataBase.Conecta();
            bool result = false;
            CaixaDB caixaDB = new CaixaDB(dataBase);

            result = caixaDB.GravarAbrirCaixa(caixaSelecionado);

            dataBase.Desconecta();

            return (result);
        }
        public bool FecharCaixa(int id,double entradas, double saidas) { 


            caixaSelecionado.Id = id;
            caixaSelecionado.Entradas = entradas;
            caixaSelecionado.Saidas = saidas;

            dataBase.Conecta();
            bool result = false;
            CaixaDB caixaDB = new CaixaDB(dataBase);

            result = caixaDB.GravarFecharCaixa(caixaSelecionado);

            dataBase.Desconecta();

            return (result);
        }

        public DataTable buscarCaixa(int filter)
        {

            DataTable dtCixa = new DataTable();

            dtCixa.Columns.Add("caixa_id", typeof(int));
            dtCixa.Columns.Add("caixa_idFunc", typeof(int));
            dtCixa.Columns.Add("caixa_dtAbertura", typeof(DateTime));
            dtCixa.Columns.Add("caixa_dtFechamento", typeof(DateTime));
            dtCixa.Columns.Add("caixa_saldoAnterior", typeof(double));
            dtCixa.Columns.Add("caixa_entradas", typeof(double));
            dtCixa.Columns.Add("caixa_saidas", typeof(double));
            dtCixa.Columns.Add("caixa_suprimento", typeof(double));
            dtCixa.Columns.Add("caixa_sangria", typeof(double));

            dataBase.Conecta();
            CaixaDB caixaDB= new CaixaDB(dataBase);

            foreach (Caixa caixa in caixaDB.searth(filter))
            {
                
                DataRow line = dtCixa.NewRow();

                line["caixa_id"] = caixa.Id;
                line["caixa_idFunc"] = caixa.IdFunc;
                line["caixa_dtAbertura"] = caixa.DtAbertura;
                
                if (caixa.Dtfechamento == null)
                {
                    line["caixa_dtFechamento"] = DBNull.Value;
                }
                else
                {
                    line["caixa_dtFechamento"] = caixa.Dtfechamento;
                }
                    
                line["caixa_saldoAnterior"] = caixa.SaldoAnterior;
                line["caixa_entradas"] = caixa.Entradas;
                line["caixa_saidas"] = caixa.Saidas;
                line["caixa_suprimento"] = caixa.Suprimento;
                line["caixa_sangria"] = caixa.Sangria;

                dtCixa.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtCixa);
        }
        public Caixa buscarCaixaAberto(int filter)
        {
            Caixa caixa = new Caixa();
            dataBase.Conecta();

            CaixaDB bd = new CaixaDB(dataBase);
            caixa = (Caixa)bd.buscarCaixaAberto(filter);

            dataBase.Desconecta();
            return caixa;

        }
        public double buscarSaldoCaixaAnterior(int filter)
        {
            double saldo;
            dataBase.Conecta();

            CaixaDB bd = new CaixaDB(dataBase);
            saldo = bd.buscarSaldoCaixaAnterior(filter);

            dataBase.Desconecta();
            return saldo;

        }
        
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
