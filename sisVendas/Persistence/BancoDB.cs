using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace sisVendas.Persistence
{
    internal class BancoDB
    {
        private Banco db = null;
        public BancoDB(Banco db)
        {
            this.db = db;
        }

		//Producao
		//FILENAME = '"+Directory.GetCurrentDirectory() + @"\DataBase\dbSis.mdf',
		//Desenvolvimento
		//FILENAME = 'C:\Users\Bruno\Documents\sisVendas\sisVendas\DataBase\dbSis.mdf',
		public bool CriarDataBase()
        {
            bool res = false;
            
            String str;
            SqlConnection myConn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated security=SSPI;database=master");

            str = @"DROP DATABASE dbSis;";
			SqlCommand myCommand = new SqlCommand(str, myConn);
			myConn.Open();
			try
			{
				myCommand.ExecuteNonQuery();
			}
			catch{ }



			str = @"CREATE DATABASE dbSis ON PRIMARY 
            (NAME = dbSis,
            FILENAME = '" + Directory.GetCurrentDirectory() + @"\DataBase\dbSis.mdf',
            FILEGROWTH = 10 %)";

			myCommand = new SqlCommand(str, myConn);
            try
            {
                myCommand.ExecuteNonQuery();
                res = true;
                MessageBox.Show("DataBase criada com sucesso!", "SisVendas Automações Brasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Erro ao criar DataBase: "+ex.ToString(), "SisVendas Automações Brasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }

            return res;
        }
        public bool InserirTabelas()
        {
            bool res = false;

			
			string SQL = System.IO.File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SQLtoCreateDataSet.txt"));

			res = db.ExecuteNonQuery(SQL);
            

            return res;
        }
    }
}
