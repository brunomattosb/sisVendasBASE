
using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Controllers
{
    class ctrlClient
    {
        private Banco dataBase = new Banco();
        private Client CurrentClient = new Client();

        // DateTime created_at, char sex, double balance)
        public bool SaveClient(string id, string name, string cpf_cnpj, string zip_code, string address, string district,
            string email, string rg_ie, string telephone, string uf, string city, string fantasy_name, DateTime birth_at,
            char sex, double balance)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                CurrentClient.Id = number;

            CurrentClient.Name = name;
            CurrentClient.Fantasy_name = fantasy_name;
            CurrentClient.Cpf_cnpj = cpf_cnpj;
            CurrentClient.Zip_code = zip_code;
            CurrentClient.Address = address;
            CurrentClient.Email = email;
            CurrentClient.Rg_ie = rg_ie;
            CurrentClient.Telephone = telephone;
            CurrentClient.City = city;
            CurrentClient.Birth_at = birth_at;
            CurrentClient.Sex = sex;
            CurrentClient.Balance = balance;
            CurrentClient.Uf = uf;
            CurrentClient.District = district;

            dataBase.Conecta();
            bool result = false;
            ClientDB cli = new ClientDB(dataBase);
            if (number == 0)
            {
                result = cli.Gravar(CurrentClient);
            }
            else
            {
                result = cli.updateClient(CurrentClient);
            }
            dataBase.Desconecta();

            return (result);
        }
        public DataTable searthClient(string filter)
        {

            DataTable dtClient = new DataTable();

            dtClient.Columns.Add("cli_id", typeof(int));
            dtClient.Columns.Add("cli_name");
            dtClient.Columns.Add("cli_fantasy_name");
            dtClient.Columns.Add("cli_cpf_cnpj");
            dtClient.Columns.Add("cli_zip_code");
            dtClient.Columns.Add("cli_addres");
            dtClient.Columns.Add("cli_email");
            dtClient.Columns.Add("cli_rg_ie");
            dtClient.Columns.Add("cli_telephone");
            dtClient.Columns.Add("cli_city");
            dtClient.Columns.Add("cli_birth_at", typeof(DateTime));
            dtClient.Columns.Add("cli_created_at", typeof(DateTime));
            dtClient.Columns.Add("cli_sex");
            dtClient.Columns.Add("cli_balance", typeof(double));
            dtClient.Columns.Add("cli_uf");
            dtClient.Columns.Add("cli_district");




            dataBase.Conecta();
            ClientDB cliBDB= new ClientDB(dataBase);
            foreach (Client cli in cliBDB.searthClient(filter))
            {
                
                DataRow line = dtClient.NewRow();

                line["cli_id"] = cli.Id ;
                line["cli_name"] = cli.Name;
                line["cli_fantasy_name"] = cli.Fantasy_name;
                line["cli_cpf_cnpj"] = cli.Cpf_cnpj;
                line["cli_zip_code"] = cli.Zip_code;
                line["cli_addres"] = cli.Address;
                line["cli_email"] = cli.Email;
                line["cli_rg_ie"] = cli.Rg_ie;
                line["cli_telephone"] = cli.Telephone;
                line["cli_city"] = cli.City;
                line["cli_birth_at"] = cli.Birth_at;
                line["cli_created_at"] = cli.Created_at;
                line["cli_sex"] = cli.Sex;
                line["cli_balance"] = cli.Balance;
                line["cli_uf"] = cli.Uf;
                line["cli_district"] = cli.District;

                dtClient.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtClient);
        }
        public bool removeClient(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ClientDB clidDB = new ClientDB(dataBase);
            res = clidDB.removeClient(cod);
            dataBase.Desconecta();
            return res;
        }
    }

    
}
