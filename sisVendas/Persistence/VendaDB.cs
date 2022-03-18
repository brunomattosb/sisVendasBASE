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
    class VendaDB
    {
        private Banco db = null;
        public VendaDB(Banco db)
        {
            this.db = db;
        }
        public int Gravar(object Objeto)
        {
            bool res = false;
            int retorno = 0;

            if (Objeto.GetType() == typeof(classVenda))
            {
                classVenda venda = (classVenda)Objeto;

                string SQL;

                SQL = @"INSERT INTO Venda (venda_idCliente, venda_desconto)
                        values (@venda_idCliente, @venda_desconto)";


                //grava null caso idCliente seja zero
                if(venda.Id_cliente == 0)
                {
                    SQL = @"INSERT INTO Venda (venda_idCliente, venda_desconto)
                        values (null, @venda_desconto)";

                    res = db.ExecuteNonQuery(SQL, "@venda_desconto", venda.Desconto);
                }
                else
                    res = db.ExecuteNonQuery(SQL, "@venda_idCliente", venda.Id_cliente,
                                                    "@venda_desconto", venda.Desconto);

                if (res)
                {
                    retorno = db.GetIdentity();
                }

            }
            return (retorno);
        } 
        
        public List<object> buscar(string filtro)
        {
            DataTable dt = new DataTable();

            List<object> vendas = new List<object>();

            // venda_id, venda_desconto,venda_desconto + soma as total_venda, venda_criado_em, cli_name, cli_cpf_cnpj

            string SQL = @"select * from (      
	                        select venda_id, venda_desconto,venda_desconto + soma as total_venda, venda_criado_em, cli_name, cli_cpf_cnpj 
                                                                                                                                    from venda 
                            inner join client on venda.venda_idCliente = client.cli_id
                            inner join (
                                            select parcela_idVenda, sum(parcela_valor) as soma from ParcelasVenda 
                                                                            group by parcela_idVenda) as parcelas 
							                on venda.venda_id = parcela_idVenda
                            ) as teste ";

            if(filtro != "")
            {
                SQL = SQL + filtro;
            }

            //where total_venda >= 50.00 AND cli_cpf_cnpj = 38713376845 AND cli_name = 'Bruno' AND venda_criado_em BETWEEN '01/11/1995 00:00:00' AND '01/11/2029 00:00:00'
            db.ExecuteQuery(SQL, out dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    VendaCompleta venda = new VendaCompleta();

                    venda.Id = Convert.ToInt32(dt.Rows[i]["venda_id"]);
                    venda.Desconto = Convert.ToDouble(dt.Rows[i]["venda_desconto"].ToString());
                    venda.Total_venda = Convert.ToDouble(dt.Rows[i]["total_venda"].ToString());
                    venda.Venda_criado_em = Convert.ToDateTime(dt.Rows[i]["venda_criado_em"].ToString());
                    venda.Cli_cpf_cnpj = dt.Rows[i]["cli_cpf_cnpj"].ToString();
                    venda.Cli_name = dt.Rows[i]["cli_name"].ToString();

                    vendas.Add(venda);
                }
            }
            return (vendas);

        }
        /*
        public bool remove(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Provider WHERE prov_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
        */
        
        public bool atualizar(object Objeto)
        {
            /*
            bool res = false;
            if (Objeto.GetType() == typeof(Provider))
            {
                Provider prov = (Provider)Objeto;

                string SQL = @"UPDATE Provider SET prov_rg_ie = @prov_rg_ie,
                                                    prov_name = @prov_name,
                                                    prov_fantazy_name = @prov_fantazy_name,
                                                    prov_addres = @prov_addres,
                                                    prov_city = @prov_city,
                                                    prov_district = @prov_district,
                                                    prov_uf = @prov_uf,
                                                    prov_zip_code = @prov_zip_code,
                                                    prov_telephone = @prov_telephone,
                                                    prov_email = @prov_email
                            WHERE prov_id = @id";

                res = db.ExecuteNonQuery(SQL, "@id", prov.Id,
                                                "@prov_rg_ie", prov.Rg_ie,
                                                "@prov_name", prov.Name,
                                                "@prov_fantazy_name", prov.Fantasy_name,
                                                "@prov_addres", prov.Address,
                                                "@prov_city", prov.City,
                                                "@prov_district", prov.District,
                                                "@prov_uf", prov.Uf,
                                                "@prov_zip_code", prov.Zip_code,
                                                "@prov_telephone", prov.Telephone,
                                                "@prov_email", prov.Email);


            }
            return res;*/
            return false;
        }
    }

}
