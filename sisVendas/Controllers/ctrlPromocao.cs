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
    internal class ctrlPromocao
    {
        private Banco dataBase = new Banco();
        private Promocao PromocaoSelecionada = new Promocao();


        /*public bool SalvarPromocao(DataTable dttProdutos, DateTime inicio, DateTime fim, string nome, int idFuncionario)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                CurrentClient.Id = number;

            CurrentClient.Nome = nome;
            CurrentClient.Nome_fantasia = nome_fantasia;
            CurrentClient.Cpf_cnpj = cpf_cnpj;
            CurrentClient.Cep = cep;
            CurrentClient.Endereco = endereco;
            CurrentClient.Email = email;
            CurrentClient.Rg_ie = rg_ie;
            CurrentClient.Telefone = telefone;
            CurrentClient.Cidade = cidade;
            CurrentClient.DtNascimento = dtMascimento;
            CurrentClient.Sexo = sexo;
            CurrentClient.Saldo = saldo;
            CurrentClient.Uf = uf;
            CurrentClient.Bairro = bairro;

            dataBase.Conecta();
            bool res = false;
            ClientDB cli = new ClientDB(dataBase);
            if (number == 0)
            {
                res = cli.Gravar(CurrentClient);
            }
            else
            {
                res = cli.Atualizar(CurrentClient);
            }
            dataBase.Desconecta();

            return (res);
        }*/


        public DataTable Buscar(string filtro)
        {

            DataTable dttPromocao = new DataTable();

            dttPromocao.Columns.Add("promo_id", typeof(int));
            dttPromocao.Columns.Add("promo_nome");
            dttPromocao.Columns.Add("promo_inicio", typeof(DateTime)); ;
            dttPromocao.Columns.Add("promo_fim", typeof(DateTime));
            dttPromocao.Columns.Add("promo_criado_em", typeof(DateTime));
            

            dataBase.Conecta();
            PromocaoDB cliBDB = new PromocaoDB(dataBase);
            foreach (Promocao promo in cliBDB.Buscar(filtro))
            {

                DataRow line = dttPromocao.NewRow();

                line["promo_id"] = promo.Id;
                line["promo_nome"] = promo.Nome;
                line["promo_inicio"] = promo.DtInicio;
                line["promo_fim"] = promo.DtFim;
                line["promo_criado_em"] = promo.Criado_em;


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

        }*

        /*public bool removeClient(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ClientDB clidDB = new ClientDB(dataBase);
            res = clidDB.Excluir(cod);
            dataBase.Desconecta();
            return res;
        }*/
    }
}
