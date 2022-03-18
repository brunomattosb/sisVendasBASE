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

        private classVenda vendaSelecionada = new classVenda();
        private ctrlItensVenda controlItensVenda = new ctrlItensVenda();
        private ctrlParcelasVenda controlParcelas = new ctrlParcelasVenda();

        public bool SalvarVenda(int id_cliente, DataTable dtParcelas, DataTable dtProdutos, double desconto)
        {
            bool res = true;

            vendaSelecionada.Id_cliente = id_cliente;
            vendaSelecionada.ItensVenda = dtProdutos;
            vendaSelecionada.ParcelasVenda = dtParcelas;
            vendaSelecionada.Desconto = desconto;

            dataBase.Conecta();


            
            VendaDB venda = new VendaDB(dataBase);

            //gravar a venda
            vendaSelecionada.Id = venda.Gravar(vendaSelecionada);

            if(vendaSelecionada.Id != 0)
            {
                foreach (DataRow row in dtProdutos.Rows)
                {
                    controlItensVenda.SalvarItensVenda(
                            vendaSelecionada.Id,
                            row["cod"].ToString(),
                            double.Parse(row["amount"].ToString())
                    );

                    MessageBox.Show(vendaSelecionada.Id + "IDVENDA");
                    MessageBox.Show(row["cod"].ToString() + "CodProduto");
                    MessageBox.Show(row["amount"].ToString() + "Quantidade");
                }

                foreach (DataRow row in dtParcelas.Rows)
                {
                    controlParcelas.SalvarParcela(
                        vendaSelecionada.Id,
                        double.Parse(row["valor"].ToString()),
                        row["tipo"].ToString(),
                        DateTime.Parse(row["data"].ToString())
                        

                        );

                    MessageBox.Show(vendaSelecionada.Id + "IDVENDA");
                    MessageBox.Show(double.Parse(row["valor"].ToString()) + "VALOR");
                    MessageBox.Show(row["tipo"].ToString() + "TIPO");

                }
            }
            else
            {
                MessageBox.Show("Erro ao gravar venda!");
            }
            
            dataBase.Desconecta();

            return (res);

            
        }


        public DataTable buscarVendas(string filter)
        {

            DataTable dtVenda = new DataTable();

            dtVenda.Columns.Add("id", typeof(int));
            dtVenda.Columns.Add("desconto");
            dtVenda.Columns.Add("total");
            dtVenda.Columns.Add("criado_em", typeof(DateTime));
            dtVenda.Columns.Add("nome");
            dtVenda.Columns.Add("cpf_cnpj");

            dataBase.Conecta();

            VendaDB vendaDB = new VendaDB(dataBase);

            foreach (VendaCompleta venda in vendaDB.buscar(filter))
            {
                
                DataRow line = dtVenda.NewRow();

                line["id"] = venda.Id;
                line["desconto"] = "R$ "+venda.Desconto;
                line["total"] = "R$ " + venda.Total_venda;
                line["criado_em"] = venda.Venda_criado_em;
                line["nome"] = venda.Cli_name;
                line["cpf_cnpj"] = venda.Cli_cpf_cnpj;


                dtVenda.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtVenda);
        }


        /*public bool removeProvider(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ProviderDB provDB = new ProviderDB(dataBase);
            res = provDB.remove(cod);
            dataBase.Desconecta();
            return res;
        }*/

    }
}
