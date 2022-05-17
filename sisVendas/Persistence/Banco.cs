using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Persistence
{
    class Banco
    {
        //SETUP INSTALL
        //private String strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetCurrentDirectory() + @"\DataBase\dbSis.mdf;Integrated Security=True;Connect Timeout=30";
        
        //PC DSENVOLVIMENTO
        private String strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bruno\Documents\sisVendas\sisVendas\DataBase\dbSis.mdf;Integrated Security=True;Connect Timeout=30";


        private SqlConnection con = null;
        private SqlTransaction trans = null;

        public bool Conecta()
        {
            bool resultado = false;
            try
            {
                //MessageBox.Show(strcon);
                con = new SqlConnection(strcon);
                con.Open();
                resultado = true;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro conexão" + e.Message);
                MessageBox.Show("Erro conexão" + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return resultado;
        }

        public void Desconecta()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
                con = null;
            }
        }

        public void BeginTransaction()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
                trans = con.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Commit();
                trans = null;
            }
        }

        public void RollbackTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Rollback();
                trans = null;
            }
        }

        public bool ExecuteQuery(String sql, out DataTable dt, params Object[] parametros)
        {
            dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro execute query" + e.Message);
                MessageBox.Show("Erro execute nonquery" + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool ExecuteNonQuery(String sql, params Object[] parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                {
                    if(parametros[i+1] == null)
                    {
                        cmd.Parameters.AddWithValue(parametros[i].ToString(), "");
                        //MessageBox.Show(parametros[i].ToString());
                    }
                    else
                        cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                }
                cmd.ExecuteNonQuery();

                
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro execute nonquery" + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public int GetIdentity()
        {
            SqlCommand cmd = new SqlCommand("SELECT @@IDENTITY", con);
            object o = cmd.ExecuteScalar();
            if (o != null)
                return Convert.ToInt32(o);
            else
                return 0;
        }
    }
}
