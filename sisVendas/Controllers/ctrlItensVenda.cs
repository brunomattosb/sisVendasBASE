
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
        private ItenVenda ItensVendaSelecionado = new ItenVenda();
        private ctrlProduct controlProduto = new ctrlProduct();

        public bool SalvarItensVenda(int id_venda, string id_produto,double quantidade, double valorUn)
        {
            

            ItensVendaSelecionado.Quantidade = quantidade;
            ItensVendaSelecionado.Id_produto = id_produto;
            ItensVendaSelecionado.Id_venda = id_venda;
            ItensVendaSelecionado.Valor = valorUn;

            dataBase.Conecta();
            bool result = false;
            ItensVendaDB itensVenda = new ItensVendaDB(dataBase);

            result = itensVenda.Gravar(ItensVendaSelecionado);
            if (result)
            {
                //subtrair estoque
                controlProduto.removerEstoque(id_produto, quantidade);
            }
            
            dataBase.Desconecta();

            return (result);
        }

        public DataTable buscarItensVendaPorIDVenda(int filter)
        {

            DataTable dtItemsVenda = new DataTable();

            dataBase.Conecta();
            ItensVendaDB itensDB= new ItensVendaDB(dataBase);
            dtItemsVenda = itensDB.buscarPorIdVenda(filter);


            dataBase.Desconecta();

            return (dtItemsVenda);
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
