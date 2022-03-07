using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Persistence
{
    class EmployeeDB
    {
        private Banco db = null;
        public EmployeeDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(Employee))
            {
                Employee emp = (Employee)Objeto;

                string SQL;

                SQL = @"INSERT INTO Employee(emp_name,emp_cpf,emp_zip_code,emp_addres,emp_district,emp_city,emp_telephone,emp_rg,emp_uf,emp_birth_at,
                        emp_sex,emp_email,emp_base_salary,emp_username,emp_password,emp_licence, emp_admission, emp_resignation)
                        VALUES (@emp_name,@emp_cpf,@emp_zip_code,@emp_addres,@emp_district,@emp_city,@emp_telephone,@emp_rg,@emp_uf,@emp_birth_at,
                                @emp_sex,@emp_email,@emp_base_salary,@emp_username,@emp_password,@emp_licence,@emp_admission, @emp_resignation)";

                res = db.ExecuteNonQuery(SQL, "@emp_name", emp.Name,
                                                "@emp_cpf", emp.Cpf,
                                                "@emp_zip_code", emp.Zip_code,
                                                "@emp_addres", emp.Address,
                                                "@emp_district", emp.District,
                                                "@emp_city", emp.City,
                                                "@emp_telephone", emp.Telephone,
                                                "@emp_rg", emp.Rg,
                                                "@emp_uf", emp.Uf,
                                                "@emp_birth_at", emp.Birth_at,
                                                "@emp_sex", emp.Sex,
                                                "@emp_email", emp.Email,
                                                "@emp_base_salary", emp.Base_salary,
                                                "@emp_username", emp.Username,
                                                "@emp_password", emp.Password,
                                                "@emp_licence", emp.Licence,
                                                "@emp_admission", emp.Admission,
                                                "@emp_resignation", emp.Resignation);


            }
            return (res);
        }
        
        public List<object> searth(string filtro)
        {
            
            DataTable dt = new DataTable();
            List<object> employees = new List<object>();


            string SQL = @"SELECT * FROM Employee WHERE emp_name like @filtro OR emp_cpf like @filtro order by emp_name";
            filtro += "%";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Employee emp = new Employee();


                    emp.Id = Convert.ToInt32(dt.Rows[i]["emp_id"]);
                    emp.Name = dt.Rows[i]["emp_name"].ToString();
                    emp.Cpf = dt.Rows[i]["emp_cpf"].ToString();
                    emp.Zip_code = dt.Rows[i]["emp_zip_code"].ToString();
                    emp.Address = dt.Rows[i]["emp_addres"].ToString();
                    emp.District = dt.Rows[i]["emp_district"].ToString();
                    emp.City = dt.Rows[i]["emp_city"].ToString();
                    emp.Telephone = dt.Rows[i]["emp_telephone"].ToString();
                    emp.Rg = dt.Rows[i]["emp_rg"].ToString();
                    emp.Uf = dt.Rows[i]["emp_uf"].ToString();
                    emp.Birth_at = Convert.ToDateTime(dt.Rows[i]["emp_birth_at"].ToString());
                    emp.Created_at = Convert.ToDateTime(dt.Rows[i]["emp_created_at"].ToString());
                    emp.Email = dt.Rows[i]["emp_email"].ToString();
                    emp.Sex = Convert.ToChar(dt.Rows[i]["emp_sex"].ToString()[0]);
                    emp.Base_salary = Convert.ToDouble(dt.Rows[i]["emp_base_salary"].ToString());
                    emp.Username = dt.Rows[i]["emp_username"].ToString();
                    emp.Password = dt.Rows[i]["emp_password"].ToString();
                    emp.Licence = dt.Rows[i]["emp_licence"].ToString();
                    emp.Admission = Convert.ToDateTime(dt.Rows[i]["emp_admission"].ToString());
                    emp.Resignation = Convert.ToDateTime(dt.Rows[i]["emp_resignation"].ToString());
                    employees.Add(emp);
                }
            }
            return (employees);

        }
        
        
        public bool update(object Objeto)
        {

            bool res = false;
            if (Objeto.GetType() == typeof(Employee))
            {
                Employee emp = (Employee)Objeto;

                string SQL = @"UPDATE Employee SET emp_name = @emp_name,
                                            emp_id = @emp_id,
                                            emp_zip_code = @emp_zip_code,
                                            emp_addres = @emp_addres,
                                            emp_district = @emp_district,
                                            emp_city = @emp_city,
                                            emp_telephone = @emp_telephone,
                                            emp_rg = @emp_rg,
                                            emp_uf = @emp_uf,
                                            emp_birth_at = @emp_birth_at,
                                            emp_sex = @emp_sex,
                                            emp_email = @emp_email,
                                            emp_base_salary = @emp_base_salary,
                                            emp_username = @emp_username,
                                            emp_password = @emp_password,
                                            emp_licence = @emp_licence,
                                            emp_admission = @emp_admission,
                                            emp_resignation = @emp_resignation
                            WHERE emp_id = @emp_id";

                res = db.ExecuteNonQuery(SQL, "@emp_name", emp.Name,
                                                "@emp_id", emp.Id,
                                                "@emp_zip_code", emp.Zip_code,
                                                "@emp_addres", emp.Address,
                                                "@emp_district", emp.District,
                                                "@emp_city", emp.City,
                                                "@emp_telephone", emp.Telephone,
                                                "@emp_rg", emp.Rg,
                                                "@emp_uf", emp.Uf,
                                                "@emp_birth_at", emp.Birth_at,
                                                "@emp_sex", emp.Sex,
                                                "@emp_email", emp.Email,
                                                "@emp_base_salary", emp.Base_salary,
                                                "@emp_username", emp.Username,
                                                "@emp_password", emp.Password,
                                                "@emp_licence", emp.Licence,
                                                "@emp_admission", emp.Admission,
                                                "@emp_resignation", emp.Resignation);
            }
            return res;
        }
        public bool remove(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Employee WHERE emp_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
    }
}
