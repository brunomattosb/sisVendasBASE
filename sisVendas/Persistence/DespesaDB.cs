using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace sisVendas.Persistence
{
    class DespesaDB
    {
        private Banco db = null;
        public DespesaDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;
            
            if (Objeto.GetType() == typeof(Despesa))
            {
                Despesa desp = (Despesa)Objeto;

                string SQL;

                
                SQL = @"INSERT INTO Despesa(desp_descricao,desp_valor,desp_idTipo, desp_idCaixa, desp_desconto, desp_dataReferencia, desp_formaPagamento,
                                                                                                                    desp_dataPagamento, desp_dataVencimento)
                        VALUES (@desp_descricao,@desp_valor,@desp_idTipo, @desp_idCaixa, @desp_desconto, @desp_dataReferencia, @desp_formaPagamento,
                                                                                                                NULLIF (@desp_dataPagamento, ''), @desp_dataVencimento)";

                res = db.ExecuteNonQuery(SQL, "@desp_descricao", desp.Descricao,
                                                "@desp_valor", desp.Valor - desp.Desconto,
                                                "@desp_idTipo", desp.IdTipo,
                                                "@desp_idCaixa", desp.IdCaixa,
                                                "@desp_desconto", desp.Desconto,
                                                "@desp_dataReferencia", desp.DataReferencia,
                                                "@desp_formaPagamento", desp.Forma_pagamento,
                                                "@desp_dataPagamento", desp.DataPagamento,
                                                "@desp_dataVencimento", desp.DataVencimento
                                                );
            }
            return (res);
        }
        public bool estornarDespesa(int idParcela)
        {
            bool res = false;
            string SQL = @"UPDATE despesa SET desp_dataPagamento = null, desp_formaPagamento = 'F'
                        WHERE desp_id = @desp_id";

            res = db.ExecuteNonQuery(SQL, "@desp_id", idParcela);

            return res;
        }
        public List<object> Buscar(string filtro)
        {
            List<object> expense = new List<object>();

            DataTable dt = new DataTable();



            string SQL = @"SELECT desp_id,desp_idTipo,desp_descricao,desp_valor,desp_idCaixa,desp_dataPagamento,desp_desconto,desp_dataReferencia,desp_formaPagamento,
desp_dataVencimento,desp_tipo_nome FROM Despesa
inner join DespesaTipo on DespesaTipo.desp_tipo_id = Despesa.desp_idTipo";
            if (filtro != "")
            {
                SQL = SQL + " where " + filtro;
            }
            SQL = SQL + " order by desp_dataReferencia DESC";
            Console.WriteLine(SQL);

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Despesa exp = new Despesa();

                    exp.Id = Convert.ToInt32(dt.Rows[i]["desp_id"]);
                    exp.Descricao = dt.Rows[i]["desp_descricao"].ToString();
                    exp.Valor = Convert.ToDouble(dt.Rows[i]["desp_valor"].ToString());
                    exp.IdTipo = Convert.ToInt32(dt.Rows[i]["desp_idTipo"]);
                    exp.IdCaixa = Convert.ToInt32(dt.Rows[i]["desp_idCaixa"]);
                    exp.Desconto = Convert.ToDouble(dt.Rows[i]["desp_desconto"].ToString());
                    exp.DataReferencia = Convert.ToDateTime(dt.Rows[i]["desp_dataReferencia"].ToString());
                    
                    exp.Forma_pagamento = dt.Rows[i]["desp_formaPagamento"].ToString();
                    exp.DataVencimento = Convert.ToDateTime(dt.Rows[i]["desp_dataVencimento"].ToString());
                    exp.Tipo = dt.Rows[i]["desp_tipo_nome"].ToString();


                    if (DateTime.TryParse(dt.Rows[i]["desp_dataPagamento"].ToString(), out DateTime dtPagamento))
                    {
                        exp.DataPagamento = dtPagamento;
                    }
                    else
                    {
                        exp.DataPagamento = null;
                    }
                    
                    expense.Add(exp);
                }
            }


            return (expense);
        }
        public DataTable buscarParaRelatorio(string filtro)
        {
            List<object> expense = new List<object>();

            DataTable dt = new DataTable();



            string SQL = @"SELECT desp_dataReferencia as 'Referência',desp_tipo_nome as 'Tipo',
                                            desp_valor as 'Valor',desp_desconto as 'Desconto',
							                desp_dataPagamento as 'Dt Pgmto',desp_dataVencimento as 'Dt Vencimento'
																							FROM Despesa
		inner join DespesaTipo on DespesaTipo.desp_tipo_id = Despesa.desp_idTipo";
            if (filtro != "")
            {
                SQL = SQL + " where " + filtro;
            }
            SQL = SQL + " order by desp_dataReferencia DESC";
            Console.WriteLine(SQL);

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

            return (dt);
        }
        public List<object> BuscarPorIdCaixa(int idCaixa)
        {
            List<object> expense = new List<object>();

            DataTable dt = new DataTable();



            string SQL = @"SELECT * FROM Despesa where desp_idCaixa = @idCaixa AND desp_dataPagamento is not null order by desp_id DESC";
            
            Console.WriteLine(SQL);

            db.ExecuteQuery(SQL, out dt, "@idCaixa", idCaixa);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Despesa exp = new Despesa();

                    exp.Id = Convert.ToInt32(dt.Rows[i]["desp_id"]);
                    exp.Descricao = dt.Rows[i]["desp_descricao"].ToString();
                    exp.Valor = Convert.ToDouble(dt.Rows[i]["desp_valor"].ToString());
                    exp.IdTipo = Convert.ToInt32(dt.Rows[i]["desp_idTipo"]);
                    exp.IdCaixa = Convert.ToInt32(dt.Rows[i]["desp_idCaixa"]);
                    exp.Desconto = Convert.ToDouble(dt.Rows[i]["desp_desconto"].ToString());
                    exp.DataReferencia = Convert.ToDateTime(dt.Rows[i]["desp_dataReferencia"].ToString());
                    exp.DataPagamento = Convert.ToDateTime(dt.Rows[i]["desp_dataPagamento"].ToString());
                    exp.Forma_pagamento = dt.Rows[i]["desp_formaPagamento"].ToString();
                    exp.DataVencimento = Convert.ToDateTime(dt.Rows[i]["desp_dataVencimento"].ToString());
                    expense.Add(exp);
                }
            }


            return (expense);
        }
        
        public List<object> BuscarDespesaParaContasAPagar(string filtro)
        {
            List<object> expense = new List<object>();
            
            DataTable dt = new DataTable();

            string SQL = @"select desp_id, desp_dataPagamento, desp_dataVencimento, desp_formaPagamento, desp_idCaixa, desp_valor,
                                                                                                            desp_tipo_nome from Despesa
	                            inner join DespesaTipo on DespesaTipo.desp_tipo_id = Despesa.desp_idTipo";
            
            if(filtro != "")
            {
                SQL = SQL + " where " + filtro;
            }

            db.ExecuteQuery(SQL, out dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Despesa exp = new Despesa();
                    exp.Id = Convert.ToInt32(dt.Rows[i]["desp_id"]);
                    exp.DataVencimento = Convert.ToDateTime(dt.Rows[i]["desp_dataVencimento"].ToString());
                    exp.Forma_pagamento = dt.Rows[i]["desp_formaPagamento"].ToString();
                    exp.IdCaixa = Convert.ToInt32(dt.Rows[i]["desp_idCaixa"]);
                    exp.Valor = Convert.ToDouble(dt.Rows[i]["desp_valor"].ToString());
                    exp.Descricao = dt.Rows[i]["desp_tipo_nome"].ToString();
                    
                    if(DateTime.TryParse(dt.Rows[i]["desp_dataPagamento"].ToString(), out DateTime dtPagmento))
                    {
                        exp.DataPagamento = dtPagmento;
                    }
                    else
                    {
                        exp.DataPagamento = null;
                    }
                    expense.Add(exp);
                }
            }
           
            return (expense);
        }
        
        public bool quitarDespesa(int idDespesa, char tipoPagamento, int idCaixa)
        {

            bool res = false;
            string SQL = @"UPDATE Despesa SET desp_formaPagamento = @desp_formaPagamento,
                                                    desp_dataPagamento = @desp_dataPagamento,
                                                    desp_idCaixa = @desp_idCaixa
                        WHERE desp_id = @desp_id";

            res = db.ExecuteNonQuery(SQL, "@desp_formaPagamento", tipoPagamento,
                                            "@desp_dataPagamento", DateTime.Now,
                                            "@desp_id", idDespesa,
                                            "@desp_idCaixa", idCaixa);

            return res;
        }
        public bool Atualizar(object Objeto)
        {
            bool res = false;
            if (Objeto.GetType() == typeof(Despesa))
            {
                Despesa desp = (Despesa)Objeto;

                string SQL = @"UPDATE Despesa SET desp_idTipo = @desp_idTipo,
                                            desp_descricao = @desp_descricao,
                                            desp_valor = @desp_valor,
                                            desp_idCaixa = @desp_idCaixa,
                                            desp_dataPagamento = NULLIF (@desp_dataPagamento, ''),
                                            desp_desconto = @desp_desconto,
                                            desp_dataReferencia = @desp_dataReferencia,
                                            desp_formaPagamento = @desp_formaPagamento,
                                            desp_dataVencimento = @desp_dataVencimento
                            WHERE desp_id = @desp_id";

                res = db.ExecuteNonQuery(SQL, "@desp_descricao", desp.Descricao,
                                                "@desp_valor", desp.Valor - desp.Desconto,
                                                "@desp_idTipo", desp.IdTipo,
                                                "@desp_idCaixa", desp.IdCaixa,
                                                "@desp_desconto", desp.Desconto,
                                                "desp_dataReferencia", desp.DataReferencia,
                                                "desp_id", desp.Id,
                                                "@desp_dataPagamento", desp.DataPagamento,
                                                "@desp_formaPagamento", desp.Forma_pagamento,
                                                "@desp_dataVencimento", desp.DataVencimento);
            }
            return res;
        }
        public bool Remover(string id)
        {
            bool res = false;
            string SQL = @"DELETE FROM Despesa WHERE desp_id = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }
    }
}
