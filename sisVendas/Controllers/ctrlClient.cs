
using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Collections.Generic;
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

        //

        // DateTime created_at, char sex, double balance)
        public bool SaveClient(string id, string name, string cpf_cnpj, string zip_code, string address, string district,
            string email, string rg_ie, string telephone, string uf, string city, string fantasy_name, DateTime birth_at,
            char sex, double balance)
        {

            // Verifica se existe um numero no tbCod
            if (!Int32.TryParse(id, out int number))
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

            MessageBox.Show(CurrentClient + "");
            
            


            //banco.Conecta();
            //ClienteBD cli = new ClienteBD(banco);
            //if (cod == 0)
            //{
            //    result = cli.Gravar(ClienteAtual);
            //}
            //else
            //{
            //    result = cli.Atualizar(ClienteAtual);
            //}
            //banco.Desconecta();

            //return (result);
            return true;
        }
    }

    
}
