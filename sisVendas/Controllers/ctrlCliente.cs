
using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Data;
using System.Windows.Forms;

namespace sisVendas.Controllers
{
    class ctrlCliente
    {
        private Banco dataBase = new Banco();
        private Cliente clienteSelecionado = new Cliente();

        public DataTable BuscarParaDGV(string filtro)
        {

            DataTable dtClient = new DataTable();

            dtClient.Columns.Add("cli_id", typeof(int));
            dtClient.Columns.Add("cli_nome");
            dtClient.Columns.Add("cli_cpf_cnpj");
            dtClient.Columns.Add("cli_telefone");
            dtClient.Columns.Add("cli_saldo", typeof(double));

            dataBase.Conecta();
            ClientDB cliBDB = new ClientDB(dataBase);
            foreach (Cliente cli in cliBDB.BuscarParaDGV(filtro))
            {

                DataRow line = dtClient.NewRow();
                
                line["cli_id"] = cli.Id;
                line["cli_nome"] = cli.Nome;
                line["cli_cpf_cnpj"] = cli.Cpf_cnpj;
                line["cli_telefone"] = cli.Endereco.fone;
                line["cli_saldo"] = cli.Saldo;

                dtClient.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtClient);
        }

        public bool SalvarCliete(string cod,
                    string nome,
                    string nome_fantasia,
                    string cpf_cnpj,
                    string cep,
                    string logradouro,
                    string numero,
                    string bairro,
                    string municipio,
                    long municipio_cod,
                    string fone,
                    string rg_ie,
                    string estado,
                    Nullable<DateTime> dtNascimento,
                    char sexo,
                    double valor,
                    string email,
                    string complemento)
        {

            // verifica se existe um numero no tbcod
            if (int.TryParse(cod, out int number))
                clienteSelecionado.Id = number;
            
            clienteSelecionado.Nome = nome;
            clienteSelecionado.Nome_fantasia = nome_fantasia;
            clienteSelecionado.Cpf_cnpj = cpf_cnpj;
            clienteSelecionado.Endereco.CEP = cep;
            clienteSelecionado.Endereco.xLgr = logradouro;
            clienteSelecionado.Endereco.nro = numero;
            clienteSelecionado.Endereco.xBairro = bairro;
            clienteSelecionado.Endereco.xMun = municipio;
            if(long.TryParse(fone, out long fone_num))
                clienteSelecionado.Endereco.fone = fone_num;
            clienteSelecionado.Rg_ie = rg_ie;
            clienteSelecionado.Endereco.cMun = municipio_cod;
            clienteSelecionado.DtNascimento = dtNascimento;
            clienteSelecionado.Sexo = sexo;
            clienteSelecionado.Saldo = valor;
            clienteSelecionado.Email = email;
            clienteSelecionado.Endereco.xCpl = complemento;
            clienteSelecionado.Endereco.UF = estado;

            dataBase.Conecta();
            bool res = false;
            ClientDB cli = new ClientDB(dataBase);
            if (number == 0)
            {
                res = cli.Gravar(clienteSelecionado);
            }
            else
            {
                res = cli.Atualizar(clienteSelecionado);
            }
            dataBase.Desconecta();
            return (res);
        }
        public bool SalvarClieteEmBranco(string cod,
                    string nome,
                    string cpf_cnpj)
        {

            clienteSelecionado.Nome = nome;
            clienteSelecionado.Cpf_cnpj = cpf_cnpj;

            dataBase.Conecta();
            bool res = false;
            ClientDB cli = new ClientDB(dataBase);

            res = cli.GravarClienteEmBranco(clienteSelecionado);
            

            dataBase.Desconecta();
            return (res);
        }
        //public bool adicionarSaldo(int idCliente, double valor)
        //{
        //    bool res = false;

        //    dataBase.Conecta();
        //    ClientDB cli = new ClientDB(dataBase);

        //    res = cli.adicionarSaldo(idCliente, valor);

        //    dataBase.Desconecta();
        //    return res;
        //}
        public bool removerSaldo(int idCliente, double valor)
        {
            bool res = false;

            dataBase.Conecta();
            ClientDB cli = new ClientDB(dataBase);

            res = cli.removerSaldo(idCliente, valor);

            dataBase.Desconecta();
            return res;
        }
        //public DataTable Buscar(string filtro)
        //{

        //    DataTable dtClient = new DataTable();

        //    dtClient.Columns.Add("cli_id", typeof(int));
        //    dtClient.Columns.Add("cli_nome");
        //    dtClient.Columns.Add("cli_nome_fansasia");
        //    dtClient.Columns.Add("cli_cpf_cnpj");
        //    dtClient.Columns.Add("cli_cep");
        //    dtClient.Columns.Add("cli_endereco");
        //    dtClient.Columns.Add("cli_email");
        //    dtClient.Columns.Add("cli_rg_ie");
        //    dtClient.Columns.Add("cli_telefone");
        //    dtClient.Columns.Add("cli_cidade");
        //    dtClient.Columns.Add("cli_dt_aniversario", typeof(DateTime));
        //    dtClient.Columns.Add("cli_created_at", typeof(DateTime));
        //    dtClient.Columns.Add("cli_sexo");
        //    dtClient.Columns.Add("cli_saldo", typeof(double));
        //    dtClient.Columns.Add("cli_uf");
        //    dtClient.Columns.Add("cli_bairro");

        //    dataBase.Conecta();
        //    ClientDB cliBDB= new ClientDB(dataBase);
        //    foreach (Cliente cli in cliBDB.Buscar(filtro))
        //    {

        //        DataRow line = dtClient.NewRow();

        //        line["cli_id"] = cli.Id ;
        //        line["cli_nome"] = cli.Nome;
        //        line["cli_nome_fansasia"] = cli.Nome_fantasia;
        //        line["cli_cpf_cnpj"] = cli.Cpf_cnpj;
        //        line["cli_cep"] = cli.Cep;
        //        line["cli_endereco"] = cli.Endereco;
        //        line["cli_rg_ie"] = cli.Rg_ie;
        //        line["cli_telefone"] = cli.Telefone;
        //        line["cli_cidade"] = cli.Cidade;
        //        line["cli_created_at"] = cli.Criado_em;
        //        line["cli_sexo"] = cli.Sexo;
        //        line["cli_saldo"] = cli.Saldo;
        //        line["cli_uf"] = cli.Uf;
        //        line["cli_bairro"] = cli.Bairro;
        //        line["cli_email"] = cli.Email;

        //        if(cli.DtNascimento == null)
        //            line["cli_dt_aniversario"] = DBNull.Value;
        //        else
        //            line["cli_dt_aniversario"] = cli.DtNascimento;

        //        dtClient.Rows.Add(line);
        //    }
        //    dataBase.Desconecta();

        //    return (dtClient);
        //}
        //public DataTable buscarCpfNome()
        //{




        //    dataBase.Conecta();
        //    ClientDB cliBDB = new ClientDB(dataBase);

        //    DataTable dtClient = cliBDB.BuscarCpfNome();
        //    /*if (dt.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            Cliente cli = new Cliente();


        //            cli.Id = Convert.ToInt32(dt.Rows[i]["cli_id"]);
        //            cli.Nome = dt.Rows[i]["cli_nome"].ToString();
        //            cli.Nome_fantasia = dt.Rows[i]["cli_nome_fansasia"].ToString();
        //            cli.Cpf_cnpj = dt.Rows[i]["cli_cpf_cnpj"].ToString();
        //            cli.Cep = dt.Rows[i]["cli_cep"].ToString();
        //            cli.Endereco = dt.Rows[i]["cli_endereco"].ToString();
        //            cli.Bairro = dt.Rows[i]["cli_bairro"].ToString();
        //            cli.Cidade = dt.Rows[i]["cli_cidade"].ToString();
        //            cli.Telefone = dt.Rows[i]["cli_telefone"].ToString();
        //            cli.Rg_ie = dt.Rows[i]["cli_rg_ie"].ToString();
        //            cli.Uf = dt.Rows[i]["cli_uf"].ToString();
        //            cli.Criado_em = Convert.ToDateTime(dt.Rows[i]["cli_created_at"].ToString());
        //            cli.Sexo = Convert.ToChar(dt.Rows[i]["cli_sexo"].ToString()[0]);
        //            cli.Saldo = Convert.ToDouble(dt.Rows[i]["cli_saldo"].ToString());
        //            cli.Email = dt.Rows[i]["cli_email"].ToString();

        //            if (!DateTime.TryParse(dt.Rows[i]["cli_dt_aniversario"].ToString(), out DateTime result))
        //                cli.DtNascimento = null;
        //            else
        //                cli.DtNascimento = result;

        //            clients.Add(cli);
        //        }
        //    }*/
        //    dataBase.Desconecta();

        //    return (dtClient);
        //}
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
        public bool RemoverCliente(string cod)
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
