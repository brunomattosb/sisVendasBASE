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
    internal class ctrlPromocao
    {
        private Banco dataBase = new Banco();
        private Promocao PromocaoSelecionada = new Promocao();


        public bool SalvarPromocao(DataTable dttProdutos, string nome, DateTime inicio, DateTime fim, int idFuncionario)
        {
            PromocaoSelecionada.IdFunc = idFuncionario;
            PromocaoSelecionada.DtInicio = inicio;
            PromocaoSelecionada.DtFim = fim;
            PromocaoSelecionada.Nome = nome;

            dataBase.Conecta();
            int idPromo = 0;
            bool res = false;

            PromocaoDB promoDB = new PromocaoDB(dataBase);
            idPromo = promoDB.Gravar(PromocaoSelecionada);
            if (idPromo!=0)
            {
                ItemsPromocaoDB itemsPromoDB = new ItemsPromocaoDB(dataBase);
                ItemsPromocao item = new ItemsPromocao();
                foreach (DataRow prod in dttProdutos.Rows)
                {
                    item.Id_promocao = idPromo;
                    item.Id_produto = int.Parse(prod["prod_id"].ToString());
                    item.Valor = double.Parse(prod["prod_valor"].ToString());

                    itemsPromoDB.Gravar(item);
                }
        }
            else
            {
                MessageBox.Show("Deu ruim");
            }

            dataBase.Desconecta();

            return (res);
        }


        public DataTable Buscar(string filtro)
        {

            DataTable dttPromocao = new DataTable();

            dttPromocao.Columns.Add("promo_id", typeof(int));
            dttPromocao.Columns.Add("promo_nome");
            dttPromocao.Columns.Add("promo_inicio", typeof(DateTime)); 
            dttPromocao.Columns.Add("promo_fim", typeof(DateTime));
            dttPromocao.Columns.Add("promo_idFunc", typeof(int));
            dttPromocao.Columns.Add("promo_criado_em", typeof(DateTime));
            

            dataBase.Conecta();
            PromocaoDB promoDB = new PromocaoDB(dataBase);
            foreach (Promocao promo in promoDB.Buscar(filtro))
            {

                DataRow line = dttPromocao.NewRow();

                line["promo_id"] = promo.Id;
                line["promo_nome"] = promo.Nome;
                line["promo_inicio"] = promo.DtInicio.Date;
                line["promo_fim"] = promo.DtFim;
                line["promo_criado_em"] = promo.Criado_em;
                line["promo_idFunc"] = promo.IdFunc;


                dttPromocao.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dttPromocao);
        }
        /*public Cliente buscarClientePorCpf(string filtro)
        {
            Cliente cli = new Cliente();
            dataBase.Conecta();

            ClientDB bd = new ClientDB(dataBase);
            cli = (Cliente)bd.BuscarPorCPF(filtro);

            dataBase.Desconecta();
            return cli;

        }*/
        /*public Cliente buscarClientePorId(int filtro)
        {
            Cliente cli = new Cliente();
            dataBase.Conecta();

            ClientDB bd = new ClientDB(dataBase);
            cli = (Cliente)bd.buscarPorID(filtro);

            dataBase.Desconecta();
            return cli;

        }*/

        public bool finalizarPromocao(int cod)
        {
            bool res = true;
            dataBase.Conecta();
            PromocaoDB promoDB = new PromocaoDB(dataBase);
            res = promoDB.finalizar(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}
