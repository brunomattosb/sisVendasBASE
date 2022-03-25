
using sisVendas.Models;
using sisVendas.Models.Venda;
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
    class ctrlItensVenda
    {
        private Banco dataBase = new Banco();
        private ItensVenda ItensVendaSelecionado = new ItensVenda();

        public bool SalvarItensVenda(int id_venda, string id_produto,double quantidade)
        {
            

            ItensVendaSelecionado.Quantidade = quantidade;
            ItensVendaSelecionado.Id_produto = id_produto;
            ItensVendaSelecionado.Id_venda = id_venda;

            dataBase.Conecta();
            bool result = false;
            ItensVendaDB itensVenda = new ItensVendaDB(dataBase);

            result = itensVenda.Gravar(ItensVendaSelecionado);
            
            dataBase.Desconecta();

            return (result);
        }

        public DataTable buscarItensVendaPorIDVenda(int filter)
        {

            DataTable dtClient = new DataTable();

            dtClient.Columns.Add("iten_id", typeof(int));
            dtClient.Columns.Add("iten_quantidade", typeof(double));
            dtClient.Columns.Add("iten_idVenda", typeof(int));
            dtClient.Columns.Add("iten_idProduto");



            dataBase.Conecta();
            ItensVendaDB itensDB= new ItensVendaDB(dataBase);
            foreach (ItensVenda itens in itensDB.buscarPorIdVenda(filter))
            {
                
                DataRow line = dtClient.NewRow();

                line["iten_id"] = itens.Id ;
                line["iten_quantidade"] = itens.Quantidade;
                line["iten_idVenda"] = itens.Id_venda;
                line["iten_idProduto"] = itens.Id_produto;


                dtClient.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtClient);
        }

        /*public Cliente buscarClientePorCpf(string filter)
        {
            Cliente cli = new Cliente();
            dataBase.Conecta();

            ClientDB bd = new ClientDB(dataBase);
            cli = (Cliente)bd.buscarCpf(filter);

            dataBase.Desconecta();
            return cli;
 
        }*/
        
        public bool removerItensVenda(int cod)
        {
            bool res = true;
            dataBase.Conecta();
            ItensVendaDB db = new ItensVendaDB(dataBase);
            res = db.removerItensVenda(cod);
            dataBase.Desconecta();
            return res;
        }
        
    }

    
}
