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
    internal class ctrlExpensee
    {
        private Banco dataBase = new Banco();
        private Expense CurrentExpense = new Expense();

        // DateTime created_at, char sex, double balance)
        public bool SaveExpense(string id, string name, string description, double value, int type)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                CurrentExpense.Id = number;

            CurrentExpense.Name = name;
            CurrentExpense.Description = description;
            CurrentExpense.Value = value;
            CurrentExpense.Exp_type = type;

            dataBase.Conecta();
            bool result = false;
            ExpenseDB exp = new ExpenseDB(dataBase);
            if (number == 0)
            {
                result = exp.Gravar(CurrentExpense);
            }
            else
            {
                result = exp.update(CurrentExpense);
            }
            dataBase.Desconecta();

            return (result);
        }
        public DataTable searthExpense(string filter)
        {

            DataTable dtExpense = new DataTable();

            dtExpense.Columns.Add("exp_id", typeof(int));
            dtExpense.Columns.Add("exp_name");
            dtExpense.Columns.Add("exp_description");
            dtExpense.Columns.Add("exp_type", typeof(int));
            dtExpense.Columns.Add("exp_created_at", typeof(DateTime));
            dtExpense.Columns.Add("exp_value", typeof(double));

            dataBase.Conecta();
            ExpenseDB expDB = new ExpenseDB(dataBase);

            foreach (Expense exp in expDB.searth(filter))
            {

                DataRow line = dtExpense.NewRow();

                line["exp_id"] = exp.Id;
                line["exp_name"] = exp.Name;
                line["exp_description"] = exp.Description;
                line["exp_value"] = exp.Value;
                line["exp_type"] = exp.Exp_type;
                line["exp_created_at"] = exp.Created_at;

                dtExpense.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtExpense);
        }
        public bool removeExpense(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ExpenseDB expDB = new ExpenseDB(dataBase);
            res = expDB.remove(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}
