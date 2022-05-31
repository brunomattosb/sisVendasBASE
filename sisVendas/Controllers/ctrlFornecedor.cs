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
    class ctrlFornecedor
    {
        private Banco dataBase = new Banco();
        private Fornecedor CurrentProvider= new Fornecedor();

        public bool SaveProvider(string id, string cpf_cnpj, string rg_ie, string nome, string nome_fantasia, string endereco,
            string cidade, string bairro, string cep, string uf, string telefone, string email)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                CurrentProvider.Id = number;

            CurrentProvider.Nome = nome;
            CurrentProvider.Nome_fantasia = nome_fantasia;
            CurrentProvider.Cpf_cnpj = cpf_cnpj;
            CurrentProvider.Cep = cep;
            CurrentProvider.Endereco = endereco;
            CurrentProvider.Email = email;
            CurrentProvider.Rg_ie = rg_ie;
            CurrentProvider.Telefone = telefone;
            CurrentProvider.Cidade = cidade;
            CurrentProvider.Uf = uf;
            CurrentProvider.Bairro = bairro;

            dataBase.Conecta();
            bool result = false;
            FornecedorDB prov = new FornecedorDB(dataBase);
            if (number == 0)
            {
                result = prov.Gravar(CurrentProvider);
            }
            else
            {
                result = prov.Atualizar(CurrentProvider);
            }
            dataBase.Desconecta();

            return (result);
        }
        public Fornecedor buscarForneceodrPorCpfCnpj(string filter)
        {

            Fornecedor prov = new Fornecedor(); 

            dataBase.Conecta();
            FornecedorDB bd = new FornecedorDB(dataBase);
            prov = (Fornecedor)bd.buscarPorCpfCnpj(filter);

            dataBase.Desconecta();
            return prov;
        }
        public Fornecedor buscarForneceodrPorCod(int filter)
        {

            Fornecedor prov = new Fornecedor();

            dataBase.Conecta();
            FornecedorDB bd = new FornecedorDB(dataBase);
            prov = (Fornecedor)bd.buscarPorCod(filter);

            dataBase.Desconecta();
            return prov;
        }
        
        public DataTable buscar(string filter)
        {

            DataTable diProvider = new DataTable();

            diProvider.Columns.Add("forn_id", typeof(int));
            diProvider.Columns.Add("forn_cpf_cnpj");
            diProvider.Columns.Add("forn_rg_ie");
            diProvider.Columns.Add("forn_nome");
            diProvider.Columns.Add("forn_nome_fantasia");
            diProvider.Columns.Add("forn_endereco");
            diProvider.Columns.Add("forn_cidade");
            diProvider.Columns.Add("forn_cep");
            diProvider.Columns.Add("forn_bairro");
            diProvider.Columns.Add("forn_uf");
            diProvider.Columns.Add("forn_criado_em", typeof(DateTime));
            diProvider.Columns.Add("forn_telefone");
            diProvider.Columns.Add("forn_email");


            dataBase.Conecta();
            FornecedorDB fornDB = new FornecedorDB(dataBase);
            foreach (Fornecedor pro in fornDB.buscar(filter))
            {

                DataRow line = diProvider.NewRow();

                line["forn_id"] = pro.Id;
                line["forn_nome"] = pro.Nome;
                line["forn_nome_fantasia"] = pro.Nome_fantasia;
                line["forn_cpf_cnpj"] = pro.Cpf_cnpj;
                line["forn_cep"] = pro.Cep;
                line["forn_endereco"] = pro.Endereco;
                line["forn_email"] = pro.Email;
                line["forn_rg_ie"] = pro.Rg_ie;
                line["forn_telefone"] = pro.Telefone;
                line["forn_cidade"] = pro.Cidade;
                line["forn_criado_em"] = pro.Criado_em;
                line["forn_uf"] = pro.Uf;
                line["forn_bairro"] = pro.Bairro;

                diProvider.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (diProvider);
        }
        public DataTable BuscarCpfNome()
        {

            DataTable diProvider = new DataTable();


            dataBase.Conecta();
            FornecedorDB fornDB = new FornecedorDB(dataBase);
            diProvider = fornDB.BuscarCpfNome();
            
            dataBase.Desconecta();

            return (diProvider);
        }
        public DataTable buscarFornecedorResumido(string filter)
        {

            DataTable dtFornecedor = new DataTable();

            dtFornecedor.Columns.Add("forn_id", typeof(int));
            dtFornecedor.Columns.Add("forn_cpf_cnpj");
            dtFornecedor.Columns.Add("forn_nome");
            dtFornecedor.Columns.Add("forn_nome_fantasia");


            dataBase.Conecta();
            FornecedorDB fornDB = new FornecedorDB(dataBase);
            foreach (Fornecedor pro in fornDB.buscarResumido(filter))
            {

                DataRow line = dtFornecedor.NewRow();

                line["forn_id"] = pro.Id;
                line["forn_nome"] = pro.Nome;
                line["forn_nome_fantasia"] = pro.Nome_fantasia;
                line["forn_cpf_cnpj"] = pro.Cpf_cnpj;


                dtFornecedor.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtFornecedor);
        }
        public bool removerFornecedor(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            FornecedorDB provDB = new FornecedorDB(dataBase);
            res = provDB.remover(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}
