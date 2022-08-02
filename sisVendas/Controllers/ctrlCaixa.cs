using sisVendas.Models;
using sisVendas.Persistence;
using System.Data;

namespace sisVendas.Controllers
{
    class ctrlCaixa
    {
        private Banco dataBase = new Banco();
        private Caixa caixaSelecionado = new Caixa();

        public bool AbrirCaixa(int codFunc, double saldoAnterior)
        {
            caixaSelecionado.Funcionario.Id  = codFunc;
            caixaSelecionado.SaldoAnterior = (saldoAnterior);

            dataBase.Conecta();
            bool result = false;
            CaixaDB caixaDB = new CaixaDB(dataBase);

            result = caixaDB.GravarAbrirCaixa(caixaSelecionado);

            dataBase.Desconecta();

            return (result);
        }

        public bool FecharCaixa(int id, double entradas, double saidas)
        {
            caixaSelecionado.Id = id;
            caixaSelecionado.Entradas = entradas;
            caixaSelecionado.Saidas = saidas;

            dataBase.Conecta();
            bool result = false;
            CaixaDB caixaDB = new CaixaDB(dataBase);

            result = caixaDB.GravarFecharCaixa(caixaSelecionado);

            dataBase.Desconecta();

            return (result);
        }


        //public DataTable Buscar(string filter)
        //{

        //    DataTable dt;

        //    dataBase.Conecta();
        //    CaixaDB caixaDB= new CaixaDB(dataBase);

        //    dt = caixaDB.Buscar(filter);

        //    dataBase.Desconecta();

        //    return (dt);
        //}
        public Caixa buscarCaixaAberto(int idFunc)
        {
            Caixa caixa = new Caixa();
            dataBase.Conecta();

            CaixaDB bd = new CaixaDB(dataBase);
            caixa = (Caixa)bd.buscarCaixaAberto(idFunc);

            dataBase.Desconecta();
            return caixa;

        }
        public DataTable BuscarResumoFormHome()
        {
            DataTable dt;

            dataBase.Conecta();
            CaixaDB caixaDB = new CaixaDB(dataBase);

            dt = caixaDB.BuscarResumoHome();

            dataBase.Desconecta();

            return (dt);

        }
        //public double buscarSaldoCaixaAnterior(int filter)
        //{
        //    double saldo;
        //    dataBase.Conecta();

        //    CaixaDB bd = new CaixaDB(dataBase);
        //    saldo = bd.buscarSaldoCaixaAnterior(filter);

        //    dataBase.Desconecta();
        //    return saldo;

        //}

        /*
        
        public bool removeClient(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ClientDB clidDB = new ClientDB(dataBase);
            res = clidDB.remove(cod);
            dataBase.Desconecta();
            return res;
        }*/
    }

    
}
