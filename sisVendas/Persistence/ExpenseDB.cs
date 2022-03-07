using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    class ExpenseDB
    {
        private Banco db = null;
        public ExpenseDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Expense))
            {
                Expense exp = (Expense)Objeto;

                string SQL;

                SQL = @"INSERT INTO Expense(exp_name,exp_description,exp_value,exp_type)
                        VALUES (@exp_name,@exp_description,@exp_value,@exp_type)";

                res = db.ExecuteNonQuery(SQL, "@exp_name", exp.Name,
                                                "@exp_description", exp.Description,
                                                "@exp_value", exp.Value,
                                                "@exp_type", exp.Exp_type);


            }
            return (res);
        }

        public List<object> searth(string filtro)
        {

            DataTable dt = new DataTable();
            List<object> expense = new List<object>();


            string SQL = @"SELECT * FROM Expense WHERE exp_name like @filtro OR exp_description like @filtro order by exp_name";
            filtro += "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Expense exp = new Expense();


                    exp.Id = Convert.ToInt32(dt.Rows[i]["exp_id"]);
                    exp.Name = dt.Rows[i]["exp_name"].ToString();
                    exp.Description = dt.Rows[i]["exp_description"].ToString();
                    exp.Value = Convert.ToDouble(dt.Rows[i]["exp_value"].ToString());
                    exp.Exp_type = Convert.ToInt32(dt.Rows[i]["exp_type"]);
                    exp.Created_at = Convert.ToDateTime(dt.Rows[i]["exp_created_at"].ToString());


                    expense.Add(exp);
                }
            }
            return (expense);

        }


        public bool update(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(Expense))
            {
                Expense exp = (Expense)Objeto;

                string SQL = @"UPDATE Expense SET exp_name = @exp_name,
                                            exp_description = @exp_description,
                                            exp_value = @exp_value,
                                            exp_type = @exp_type
                            WHERE exp_id = @exp_id";

                res = db.ExecuteNonQuery(SQL, "@exp_name", exp.Name,
                                                "@exp_description", exp.Description,
                                                "@exp_value", exp.Value,
                                                "@exp_id", exp.Id,
                                                "@exp_type", exp.Exp_type);
            }
            return res;
        }
        public bool remove(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Expense WHERE exp_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
    }
}
