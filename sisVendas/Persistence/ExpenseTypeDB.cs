using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    class ExpenseTypeDB
    {
        private Banco db = null;
        public ExpenseTypeDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(ExpenseType))
            {
                ExpenseType expType = (ExpenseType)Objeto;

                string SQL;

                SQL = @"INSERT INTO ExpenseType(expType_name)
                        VALUES (@expType_name)";

                res = db.ExecuteNonQuery(SQL, "@expType_name", expType.Name);


            }
            return (res);
        }

        public List<object> searth(string filtro)
        {

            DataTable dt = new DataTable();
            List<object> expenseType = new List<object>();


            string SQL = @"SELECT * FROM ExpenseType WHERE expType_name like @filtro order by expType_name";
            filtro += "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ExpenseType exp = new ExpenseType();


                    exp.Id = Convert.ToInt32(dt.Rows[i]["expType_id"]);
                    exp.Name = dt.Rows[i]["expType_name"].ToString();
                    exp.Created_at = Convert.ToDateTime(dt.Rows[i]["expType_created_at"].ToString());


                    expenseType.Add(exp);
                }
            }
            return (expenseType);

        }


        public bool update(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(ExpenseType))
            {
                ExpenseType exp = (ExpenseType)Objeto;

                string SQL = @"UPDATE ExpenseType SET expType_name = @expType_name,
                            WHERE emp_id = @emp_id";

                res = db.ExecuteNonQuery(SQL, "@expType_name", exp.Name,
                                                "@expType_id", exp.Id);
            }
            return res;
        }
        public bool remove(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM ExpenseType WHERE expType_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
    }
}
