
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
    class ctrlTransacaoCaixa
    {
        private Banco dataBase = new Banco();
        private TransacaoCaixa TransacaoSelecionada = new TransacaoCaixa();

        public bool salvarTransacao(int idCaixa, string descricao, char tipo, double valor)
        {

            TransacaoSelecionada.IdCaixa = idCaixa;
            TransacaoSelecionada.Descricao = descricao;
            TransacaoSelecionada.Tipo = tipo;
            TransacaoSelecionada.Valor = valor;
            
            dataBase.Conecta();
            bool result = false;
            TransacaoCaixaDB transacao = new TransacaoCaixaDB(dataBase);

            result = transacao.Gravar(TransacaoSelecionada);
            

            dataBase.Desconecta();

            return (result);
        }
        
        public DataTable buscarPorIdCaixa(int filter)
        {

            DataTable dtTransacao = new DataTable();

            dtTransacao.Columns.Add("transacao_id", typeof(int));
            dtTransacao.Columns.Add("transacao_idcaixa", typeof(int));
            dtTransacao.Columns.Add("transacao_tipo");
            dtTransacao.Columns.Add("transacao_descricao");
            dtTransacao.Columns.Add("transacao_valor", typeof(double));
            dtTransacao.Columns.Add("transacao_criado_em", typeof(DateTime));

            dataBase.Conecta();
            TransacaoCaixaDB transacaoDB= new TransacaoCaixaDB(dataBase);
            foreach (TransacaoCaixa transacao in transacaoDB.buscar(filter))
            {
                
                DataRow line = dtTransacao.NewRow();

                line["transacao_id"] = transacao.Id;
                line["transacao_idcaixa"] = transacao.IdCaixa;
                line["transacao_tipo"] = transacao.Tipo;
                line["transacao_descricao"] = transacao.Descricao;
                line["transacao_valor"] = transacao.Valor;
                line["transacao_criado_em"] = transacao.Hora;



                dtTransacao.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtTransacao);
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
 
        }
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
