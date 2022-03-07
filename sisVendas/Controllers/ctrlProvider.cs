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
    class ctrlProvider
    {
        private Banco dataBase = new Banco();
        private Provider CurrentProvider= new Provider();

        public bool SaveProvider(string id, string cpf_cnpj, string rg_ie, string name, string fantasy_name, string address,
            string city, string district, string zip_code, string uf, string telephone, string email)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                CurrentProvider.Id = number;

            CurrentProvider.Name = name;
            CurrentProvider.Fantasy_name = fantasy_name;
            CurrentProvider.Cpf_cnpj = cpf_cnpj;
            CurrentProvider.Zip_code = zip_code;
            CurrentProvider.Address = address;
            CurrentProvider.Email = email;
            CurrentProvider.Rg_ie = rg_ie;
            CurrentProvider.Telephone = telephone;
            CurrentProvider.City = city;
            CurrentProvider.Uf = uf;
            CurrentProvider.District = district;

            dataBase.Conecta();
            bool result = false;
            ProviderDB prov = new ProviderDB(dataBase);
            if (number == 0)
            {
                result = prov.Gravar(CurrentProvider);
            }
            else
            {
                result = prov.update(CurrentProvider);
            }
            dataBase.Desconecta();

            return (result);
        }
        public DataTable searthProvider(string filter)
        {

            DataTable diProvider = new DataTable();

            diProvider.Columns.Add("prov_id", typeof(int));
            diProvider.Columns.Add("prov_cpf_cnpj");
            diProvider.Columns.Add("prov_rg_ie");
            diProvider.Columns.Add("prov_name");
            diProvider.Columns.Add("prov_fantazy_name");
            diProvider.Columns.Add("prov_addres");
            diProvider.Columns.Add("prov_city");
            diProvider.Columns.Add("prov_zip_code");
            diProvider.Columns.Add("prov_district");
            diProvider.Columns.Add("prov_uf");
            diProvider.Columns.Add("prov_created_at", typeof(DateTime));
            diProvider.Columns.Add("prov_telephone");
            diProvider.Columns.Add("prov_email");


            dataBase.Conecta();
            ProviderDB provDB = new ProviderDB(dataBase);
            foreach (Provider pro in provDB.searth(filter))
            {

                DataRow line = diProvider.NewRow();

                line["prov_id"] = pro.Id;
                line["prov_name"] = pro.Name;
                line["prov_fantazy_name"] = pro.Fantasy_name;
                line["prov_cpf_cnpj"] = pro.Cpf_cnpj;
                line["prov_zip_code"] = pro.Zip_code;
                line["prov_addres"] = pro.Address;
                line["prov_email"] = pro.Email;
                line["prov_rg_ie"] = pro.Rg_ie;
                line["prov_telephone"] = pro.Telephone;
                line["prov_city"] = pro.City;
                line["prov_created_at"] = pro.Created_at;
                line["prov_uf"] = pro.Uf;
                line["prov_district"] = pro.District;

                diProvider.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (diProvider);
        }
        public bool removeProvider(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ProviderDB provDB = new ProviderDB(dataBase);
            res = provDB.remove(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}
