using sisVendas.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Controllers
{
    internal class ctrlBanco
    {
        private Banco dataBase = new Banco();

        public bool CriarDB()
        {
            //caixaSelecionado.IdFunc = codFunc;
            //caixaSelecionado.SaldoAnterior = (saldoAnterior);

            
            bool result = false;
            BancoDB bancoDB = new BancoDB(dataBase);

            result = bancoDB.CriarDataBase();
            if (result)
            {
                dataBase.Conecta();

                bancoDB.InserirTabelas();

                dataBase.Desconecta();

            }

           

            return result;
        }

    }
}
