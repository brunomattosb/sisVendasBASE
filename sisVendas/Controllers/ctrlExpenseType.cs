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
    class ctrlExpenseType
    {
        private Banco dataBase = new Banco();
        private ExpenseType CurrentExpenseType = new ExpenseType();

        public bool SaveExpenseType(string id, string name)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                CurrentExpenseType.Id = number;

            CurrentExpenseType.Name = name;

            dataBase.Conecta();
            bool result = false;
            ExpenseTypeDB expTypeDB = new ExpenseTypeDB(dataBase);
            if (number == 0)
            {
                result = expTypeDB.Gravar(CurrentExpenseType);
            }
            else
            {
                result = expTypeDB.update(CurrentExpenseType);
            }
            dataBase.Desconecta();

            return (result);
        }
        public DataTable searthExpenseType(string filter)
        {

            DataTable dtExpenseType = new DataTable();

            dtExpenseType.Columns.Add("expType_id", typeof(int));
            dtExpenseType.Columns.Add("expType_name");
            dtExpenseType.Columns.Add("expType_created_at", typeof(DateTime));

            dataBase.Conecta();
            ExpenseTypeDB expTypeDB = new ExpenseTypeDB(dataBase);
            foreach (ExpenseType exptype in expTypeDB.searth(filter))
            {

                DataRow line = dtExpenseType.NewRow();

                line["expType_id"] = exptype.Id;
                line["expType_name"] = exptype.Name;
                line["expType_created_at"] = exptype.Created_at;


                dtExpenseType.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtExpenseType);
        }
        public bool removeExpenseType(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ExpenseTypeDB expTypeDB = new ExpenseTypeDB(dataBase);
            res = expTypeDB.remove(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}

