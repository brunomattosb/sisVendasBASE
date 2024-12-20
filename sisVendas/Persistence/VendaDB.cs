﻿using sisVendas.Models;
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

            if (Objeto.GetType() == typeof(Vendas))
            {
                Vendas venda = (Vendas)Objeto;

                string SQL;

                SQL = @"INSERT INTO Venda (venda_idCliente, venda_desconto, venda_idFunc, venda_num_nf)
                        values (@venda_idCliente, @venda_desconto, @venda_idFunc, @venda_num_nf)";


                //grava null caso idCliente seja zero
                if (venda.Id_cliente == 0)
                {
                    SQL = @"INSERT INTO Venda (venda_idCliente, venda_desconto, venda_num_nf)
                        values (null, @venda_desconto, @venda_idFunc, @venda_num_nf)";
                }

                res = db.ExecuteNonQuery(SQL, "@venda_idCliente", venda.Id_cliente,
                                                    "@venda_desconto", venda.Desconto,
                                                    "@venda_num_nf", venda.Id_nf,
                                                    "@venda_idFunc", venda.Id_funcionario);

                if (res)
                {
                    retorno = db.GetIdentity();
                }

            }
            return (retorno);
        }

        public DataTable buscar(string filtro)
        {
            DataTable dtVenda = new DataTable();

            dtVenda.Columns.Add("id", typeof(int));
            dtVenda.Columns.Add("desconto", typeof(double));
            dtVenda.Columns.Add("cpf_cnpj");
            dtVenda.Columns.Add("total", typeof(double));
            dtVenda.Columns.Add("criado_em", typeof(DateTime));
            dtVenda.Columns.Add("venda_cancelada", typeof(bool));
            dtVenda.Columns.Add("nome");

            dtVenda.Columns.Add("nf_num", typeof(int));
            dtVenda.Columns.Add("nf_xmotivo");
            dtVenda.Columns.Add("nf_cstat", typeof(int));

            string SQL = @"select venda_id, venda_desconto,venda_desconto + soma as total_venda, venda_criado_em, cli_nome, cli_cpf_cnpj, venda_cancelada, nf_num, nf_cstat, nf_xmotivo
                                                                                                                                    from venda 
            left join cliente on venda.venda_idCliente = cliente.cli_id

            left join (
                            select parcela_idVenda, sum(parcela_valor) as soma from ParcelaVenda 
                                                            group by parcela_idVenda) as parcelas 
							on venda.venda_id = parcelas.parcela_idVenda
            left join NF on nf.nf_num = venda.venda_num_nf";

            Console.WriteLine(SQL);
            if (filtro != "")
            {
                SQL = SQL + "where " + filtro;
                Console.WriteLine(SQL);
            }

            DataTable dt = new DataTable();

            db.ExecuteQuery(SQL, out dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow linha = dtVenda.NewRow();

                    linha["id"] = Convert.ToInt32(dt.Rows[i]["venda_id"]);
                    linha["desconto"] = Convert.ToDouble(dt.Rows[i]["venda_desconto"].ToString());
                    linha["cpf_cnpj"] = dt.Rows[i]["cli_cpf_cnpj"].ToString();
                    linha["total"] = Convert.ToDouble(dt.Rows[i]["total_venda"].ToString());
                    linha["nome"] = dt.Rows[i]["cli_nome"].ToString();
                    linha["criado_em"] = Convert.ToDateTime(dt.Rows[i]["venda_criado_em"].ToString());
                    linha["venda_cancelada"] = Convert.ToBoolean(dt.Rows[i]["venda_cancelada"].ToString());

                    int.TryParse(dt.Rows[i]["nf_num"].ToString(), out int num);
                    linha["nf_num"] = num;
                    linha["nf_xmotivo"] = dt.Rows[i]["nf_xmotivo"].ToString();
                    int.TryParse(dt.Rows[i]["nf_cstat"].ToString(), out int stat);
                    linha["nf_cstat"] = stat;

                    dtVenda.Rows.Add(linha);

                }
            }
            return (dtVenda);

        }
        public DataTable buscarParaRelatorio(string filtro)
        {
  

            string SQL = @"
select cli_nome as 'Cliente', cli_cpf_cnpj as 'CPF/CNPJ', venda_desconto + soma as 'Total',
venda_desconto as 'Desconto',venda_criado_em as 'Data' from (      
				select venda_id, venda_desconto,venda_desconto + soma as total_venda, venda_criado_em, 
																cli_nome, cli_cpf_cnpj,venda_cancelada, soma
                                                                               from venda 
				left join cliente on venda.venda_idCliente = cliente.cli_id
				inner join (select parcela_idVenda, sum(parcela_valor) as soma from ParcelaVenda 
																group by parcela_idVenda) as parcelas 
								on venda.venda_id = parcela_idVenda
) as teste ";

            Console.WriteLine(SQL);
            if (filtro != "")
            {
                SQL = SQL + "where " + filtro;
                Console.WriteLine(SQL);
            }

            DataTable dt = new DataTable();

            db.ExecuteQuery(SQL, out dt);


            return (dt);

        }
        public DataTable verificarMesmoCaixa(int idVenda)
        {
            
            string SQL = @"select parcela_idCaixa from ParcelaVenda
	                        where parcela_idVenda = @idVenda
	                        group by parcela_idCaixa";

            DataTable dt = new DataTable();

            db.ExecuteQuery(SQL, out dt, "@idVenda", idVenda);

            
            return (dt);
        }
        public bool remover(int id)
        {
            bool res = false;
            string SQL = @"update venda set venda_cancelada = 1 WHERE venda_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
        public bool removerFisica(int id)
        {
            bool res = false;
            string SQL = @"delete from venda WHERE venda_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
        public bool restabelecer(int id)
        {
            bool res = false;
            string SQL = @"update venda set venda_cancelada = 0 WHERE venda_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }

        public Vendas buscarVendaPorCod(int idVenda)
        {
            DataTable dt = new DataTable();

            string SQL = @"SELECT * FROM Venda WHERE venda_id = @idVenda";

            db.ExecuteQuery(SQL, out dt, "@idVenda", idVenda);
            Vendas venda = new Vendas();

            if (dt.Rows.Count > 0)
            {
                venda.Id = int.Parse(dt.Rows[0]["venda_id"].ToString());
                venda.Id_funcionario = int.Parse(dt.Rows[0]["venda_idFunc"].ToString());
                venda.Id_nf = int.TryParse(dt.Rows[0]["venda_num_nf"].ToString(), out int nf)? nf:0;
                venda.Desconto = double.Parse(dt.Rows[0]["venda_desconto"].ToString());
                venda.Created_at = Convert.ToDateTime(dt.Rows[0]["venda_criado_em"]);
                venda.Venda_cancelada = bool.Parse(dt.Rows[0]["venda_cancelada"].ToString());
                
                if (dt.Rows[0]["venda_idCliente"].ToString() == "")
                {
                    venda.Id_cliente = 0;
                }
                else
                {
                    venda.Id_cliente = int.Parse(dt.Rows[0]["venda_idCliente"].ToString());
                }
            }
            else
            {
                return null;
            }
            return (venda);
        }

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
