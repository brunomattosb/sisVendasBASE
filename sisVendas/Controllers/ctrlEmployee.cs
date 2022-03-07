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
    internal class ctrlEmployee
    {
        private Banco dataBase = new Banco();
        private Employee currentEmployee = new Employee();

        public bool SavEmployee(string id, string cpf, string rg, string name, string address, char sex, string city, string district, string cep,
            string uf, DateTime birth_at, string telephone, string email, double baseSalary, string username, string password, string licence,
            DateTime admission, DateTime resignation)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                currentEmployee.Id = number;

            currentEmployee.Name = name;
            currentEmployee.Cpf = cpf;
            currentEmployee.Rg = rg;
            currentEmployee.Address = address;
            currentEmployee.Sex = sex;
            currentEmployee.City = city;
            currentEmployee.District = district;
            currentEmployee.Zip_code = cep;
            currentEmployee.Uf = uf;
            currentEmployee.Birth_at = birth_at;
            currentEmployee.Telephone = telephone;
            currentEmployee.Email = email;
            currentEmployee.Base_salary = baseSalary;
            currentEmployee.Username = username;
            currentEmployee.Password = password;
            currentEmployee.Licence = licence;
            currentEmployee.Admission = admission;
            currentEmployee.Resignation = resignation;

            dataBase.Conecta();
            bool result = false;
            EmployeeDB emp = new EmployeeDB(dataBase);
            if (number == 0)
            {
                result = emp.Gravar(currentEmployee);
            }
            else
            {
                //result = emp.updateClient(currentEmployee);
            }
            dataBase.Desconecta();

            return (result);
        }
        
        public DataTable searthEmployee(string filter)
        {

            DataTable dtEmployee = new DataTable();

            dtEmployee.Columns.Add("emp_id", typeof(int));
            dtEmployee.Columns.Add("emp_name");
            dtEmployee.Columns.Add("emp_cpf");
            dtEmployee.Columns.Add("emp_zip_code");
            dtEmployee.Columns.Add("emp_addres");
            dtEmployee.Columns.Add("emp_district");
            dtEmployee.Columns.Add("emp_city");
            dtEmployee.Columns.Add("emp_telephone");
            dtEmployee.Columns.Add("emp_rg");
            dtEmployee.Columns.Add("emp_uf");
            dtEmployee.Columns.Add("emp_username");
            dtEmployee.Columns.Add("emp_password");
            dtEmployee.Columns.Add("emp_licence");
            dtEmployee.Columns.Add("emp_birth_at", typeof(DateTime));
            dtEmployee.Columns.Add("emp_created_at", typeof(DateTime));
            dtEmployee.Columns.Add("emp_admission", typeof(DateTime));
            dtEmployee.Columns.Add("emp_resignation", typeof(DateTime));
            dtEmployee.Columns.Add("emp_sex");
            dtEmployee.Columns.Add("emp_email");
            dtEmployee.Columns.Add("emp_base_salary", typeof(double));



            dataBase.Conecta();
            EmployeeDB empDB = new EmployeeDB(dataBase);
            foreach (Employee emp in empDB.searth(filter))
            {

                DataRow line = dtEmployee.NewRow();

                line["emp_id"] = emp.Id;
                line["emp_name"] = emp.Name;
                line["emp_cpf"] = emp.Cpf;
                line["emp_zip_code"] = emp.Zip_code;
                line["emp_addres"] = emp.Address ;
                line["emp_district"] = emp.District;
                line["emp_city"] = emp.City;
                line["emp_telephone"] = emp.Telephone;
                line["emp_uf"] = emp.Uf;
                line["emp_rg"] = emp.Rg;
                line["emp_birth_at"] = emp.Birth_at;
                line["emp_created_at"] = emp.Created_at;
                line["emp_sex"] = emp.Sex;
                line["emp_email"] = emp.Email;
                line["emp_base_salary"] = emp.Base_salary;
                line["emp_username"] = emp.Username;
                line["emp_password"] = emp.Password;
                line["emp_licence"] = emp.Licence;
                line["emp_admission"] = emp.Admission;
                line["emp_resignation"] = emp.Resignation;

                dtEmployee.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtEmployee);
        }
        
        public bool removeEmployee(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            EmployeeDB emp = new EmployeeDB(dataBase);
            res = emp.remove(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}
 