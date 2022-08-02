using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Data;

namespace sisVendas.Controllers
{
    class ctrlFornecedor
    {
        private Banco dataBase = new Banco();
        private Fornecedor CurrentProvider= new Fornecedor();

        public bool SalvarFornecedor(string id, string cpf_cnpj, string rg_ie, string nome, string nome_fantasia, string endereco,
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
        public Fornecedor BuscarFornecedorPorCnpj(string cnpj)
        {

            Fornecedor prov = new Fornecedor();

            dataBase.Conecta();
            FornecedorDB bd = new FornecedorDB(dataBase);
            prov = (Fornecedor)bd.BuscarFornecedor("WHERE forn_cpf_cnpj like '"+cnpj+"'");

            dataBase.Desconecta();
            return prov;
        }
        public Fornecedor BuscarForneceodrPorCod(int cod)
        {

            Fornecedor prov = new Fornecedor();

            dataBase.Conecta();
            FornecedorDB bd = new FornecedorDB(dataBase);
            prov = (Fornecedor)bd.BuscarFornecedor("WHERE forn_id = " + cod );

            dataBase.Desconecta();
            return prov;
        }

        public DataTable BuscarParaDGV(string filter)
        {

            DataTable diProvider = new DataTable();

            diProvider.Columns.Add("forn_id", typeof(int));
            diProvider.Columns.Add("forn_cpf_cnpj");
            diProvider.Columns.Add("forn_nome");

            dataBase.Conecta();
            FornecedorDB fornDB = new FornecedorDB(dataBase);
            foreach (Fornecedor pro in fornDB.BuscarParaDGV(filter))
            {

                DataRow line = diProvider.NewRow();

                line["forn_id"] = pro.Id;
                line["forn_nome"] = pro.Nome;
                line["forn_cpf_cnpj"] = pro.Cpf_cnpj;

                diProvider.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (diProvider);
        }
        //public DataTable BuscarCpfNome()
        //{

        //    DataTable diProvider = new DataTable();


        //    dataBase.Conecta();
        //    FornecedorDB fornDB = new FornecedorDB(dataBase);
        //    diProvider = fornDB.BuscarCpfNome();

        //    dataBase.Desconecta();

        //    return (diProvider);
        //}
        
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
