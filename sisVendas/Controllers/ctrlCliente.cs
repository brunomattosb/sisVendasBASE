
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
    class ctrlCliente
    {
        private Banco dataBase = new Banco();
        private Cliente CurrentClient = new Cliente();

        // DateTime created_at, char sex, double balance)
        public bool SalvarCliete(string id, string nome, string cpf_cnpj, string cep, string endereco, string bairro,
            string email, string rg_ie, string telefone, string uf, string cidade, string nome_fantasia, DateTime dtMascimento,
            char sexo, double saldo)
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
        }

        public DataTable Buscar(string filtro)
        {

            DataTable dtClient = new DataTable();

            dtClient.Columns.Add("cli_id", typeof(int));
            dtClient.Columns.Add("cli_nome");
            dtClient.Columns.Add("cli_nome_fansasia");
            dtClient.Columns.Add("cli_cpf_cnpj");
            dtClient.Columns.Add("cli_cep");
            dtClient.Columns.Add("cli_endereco");
            dtClient.Columns.Add("cli_email");
            dtClient.Columns.Add("cli_rg_ie");
            dtClient.Columns.Add("cli_telefone");
            dtClient.Columns.Add("cli_cidade");
            dtClient.Columns.Add("cli_dt_aniversario", typeof(DateTime));
            dtClient.Columns.Add("cli_created_at", typeof(DateTime));
            dtClient.Columns.Add("cli_sexo");
            dtClient.Columns.Add("cli_saldo", typeof(double));
            dtClient.Columns.Add("cli_uf");
            dtClient.Columns.Add("cli_bairro");

            dataBase.Conecta();
            ClientDB cliBDB= new ClientDB(dataBase);
            foreach (Cliente cli in cliBDB.Buscar(filtro))
            {
                
                DataRow line = dtClient.NewRow();

                line["cli_id"] = cli.Id ;
                line["cli_nome"] = cli.Nome;
                line["cli_nome_fansasia"] = cli.Nome_fantasia;
                line["cli_cpf_cnpj"] = cli.Cpf_cnpj;
                line["cli_cep"] = cli.Cep;
                line["cli_endereco"] = cli.Endereco;
                line["cli_rg_ie"] = cli.Rg_ie;
                line["cli_telefone"] = cli.Telefone;
                line["cli_cidade"] = cli.Cidade;
                line["cli_dt_aniversario"] = cli.DtNascimento;
                line["cli_created_at"] = cli.Criado_em;
                line["cli_sexo"] = cli.Sexo;
                line["cli_saldo"] = cli.Saldo;
                line["cli_uf"] = cli.Uf;
                line["cli_bairro"] = cli.Bairro;
                line["cli_email"] = cli.Email;

                dtClient.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtClient);
        }
        public Cliente buscarClientePorCpf(string filtro)
        {
            Cliente cli = new Cliente();
            dataBase.Conecta();

            ClientDB bd = new ClientDB(dataBase);
            cli = (Cliente)bd.BuscarPorCPF(filtro);

            dataBase.Desconecta();
            return cli;

        }
        public Cliente buscarClientePorId(int filtro)
        {
            Cliente cli = new Cliente();
            dataBase.Conecta();

            ClientDB bd = new ClientDB(dataBase);
            cli = (Cliente)bd.buscarPorID(filtro);

            dataBase.Desconecta();
            return cli;

        }
        public bool removeClient(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ClientDB clidDB = new ClientDB(dataBase);
            res = clidDB.Excluir(cod);
            dataBase.Desconecta();
            return res;
        }
    }

    
}
