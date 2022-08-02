using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Data;

namespace sisVendas.Controllers
{
    internal class ctrlFuncionario
    {
        private Banco dataBase = new Banco();
        private Funcionario funcionarioSelecionado = new Funcionario();

        /*
        public void adicionarPrimeiroAcesso()
        {
            dataBase.Conecta();
            FuncionarioDB bd = new FuncionarioDB(dataBase);

            if(bd.buscarSePrimeiroAcesso() == 0)
            {
                salvarFuncionario("0", "99999999999", "9999999", "ADMIN", "ENDEREÇO 9999", 'M', "EPITÁCIO", "CENTRO", "19470000",
            "SP", DateTime.Now, "18999999999", "email@email.com", 0, "admin", "admin", "Master", DateTime.Now, DateTime.Now, true);
            }

            dataBase.Desconecta();
        }*/
        public bool SalvarFuncionario(string id, string cpf, string rg, string nome, string endereco, char sexo, string cidade, string bairro, string cep,
            string uf, DateTime dtNascimento, string telefone, string email, double baseSalario, string usuario, string senha, string licenca,
            DateTime admission, DateTime resignation, bool ativo)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                funcionarioSelecionado.Id = number;

            funcionarioSelecionado.Nome = nome;
            funcionarioSelecionado.Cpf = cpf;
            funcionarioSelecionado.Rg = rg;
            funcionarioSelecionado.Endereco = endereco;
            funcionarioSelecionado.Sexo = sexo;
            funcionarioSelecionado.Cidade = cidade;
            funcionarioSelecionado.Bairro = bairro;
            funcionarioSelecionado.Cep = cep;
            funcionarioSelecionado.Uf = uf;
            funcionarioSelecionado.DtNascimento = dtNascimento;
            funcionarioSelecionado.Telefone = telefone;
            funcionarioSelecionado.Email = email;
            funcionarioSelecionado.Base_salario = baseSalario;
            funcionarioSelecionado.Usuario = usuario;
            funcionarioSelecionado.Senha = senha;
            funcionarioSelecionado.Licenca = licenca;
            funcionarioSelecionado.Admissao = admission;
            funcionarioSelecionado.Demissao = resignation;
            funcionarioSelecionado.Ativo = ativo;

            dataBase.Conecta();
            bool result = false;
            FuncionarioDB func = new FuncionarioDB(dataBase);
            if (number == 0)
            {
                result = func.Gravar(funcionarioSelecionado);
            }
            else
            {
                result = func.Atualizar(funcionarioSelecionado);
            }
            dataBase.Desconecta();

            return (result);
        }

        public Funcionario BuscarFuncionarioPorUsuario(string usuario)
        {

            Funcionario func = new Funcionario();
            dataBase.Conecta();

            FuncionarioDB bd = new FuncionarioDB(dataBase);
            func = (Funcionario)bd.BuscarPorFiltro(string.Format("where func_usuario like '{0}' and func_ativo = 1", usuario));

            dataBase.Desconecta();
            return func;

        }
        public Funcionario BuscarFuncionarioPorCPF(string cpf)
        {

            Funcionario func = new Funcionario();
            dataBase.Conecta();

            FuncionarioDB bd = new FuncionarioDB(dataBase);
            func = (Funcionario)bd.BuscarPorFiltro(string.Format("where func_cpf like '{0}' and func_ativo = 1", cpf));

            dataBase.Desconecta();
            return func;

        }

        //public Funcionario BuscarPorCPF(string usuario)
        //{

        //    Funcionario func = new Funcionario();
        //    dataBase.Conecta();

        //    FuncionarioDB bd = new FuncionarioDB(dataBase);
        //    func = (Funcionario)bd.buscarPorCPF(usuario);

        //    dataBase.Desconecta();
        //    return func;

        //}
        //public DataTable BuscarCpfNome()
        //{

        //    DataTable dtFunc = new DataTable();

        //    dataBase.Conecta();
        //    FuncionarioDB empDB = new FuncionarioDB(dataBase);
        //    dtFunc = empDB.BuscarCpfNome();

        //    dataBase.Desconecta();

        //    return (dtFunc);

        //}
        public DataTable BuscarParaDGV(string filter)
        {
            DataTable dtEmployee = new DataTable();

            dtEmployee.Columns.Add("func_id", typeof(int));
            dtEmployee.Columns.Add("func_nome");
            dtEmployee.Columns.Add("func_cpf");
            dtEmployee.Columns.Add("func_usuario");
            dtEmployee.Columns.Add("func_ativo", typeof(bool));

            dataBase.Conecta();
            FuncionarioDB empDB = new FuncionarioDB(dataBase);
            foreach (Funcionario emp in empDB.BuscarParaDGV(filter))
            {
                DataRow line = dtEmployee.NewRow();

                line["func_id"] = emp.Id;
                line["func_nome"] = emp.Nome;
                line["func_cpf"] = emp.Cpf;
                line["func_usuario"] = emp.Usuario;
                line["func_ativo"] = emp.Ativo;

                dtEmployee.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtEmployee);
        }
        //public DataTable BuscarParaComboBox()
        //{

        //    DataTable dtEmployee = new DataTable();

        //    dtEmployee.Columns.Add("func_id", typeof(int));
        //    dtEmployee.Columns.Add("func_nome");

        //    dataBase.Conecta();
        //    FuncionarioDB empDB = new FuncionarioDB(dataBase);
        //    foreach (Funcionario emp in empDB.BuscarParaComboBox())
        //    {

        //        DataRow line = dtEmployee.NewRow();

        //        line["func_id"] = emp.Id;
        //        line["func_nome"] = emp.Nome;

        //        dtEmployee.Rows.Add(line);
        //    }
        //    dataBase.Desconecta();

        //    return (dtEmployee);
        //}

        public bool Remover(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            FuncionarioDB emp = new FuncionarioDB(dataBase);
            res = emp.remove(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}
 