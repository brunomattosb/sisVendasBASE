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
                                                                                                                    desp_dataPagamento, desp_status)
                        VALUES (@desp_descricao,@desp_valor,@desp_idTipo, @desp_idCaixa, @desp_desconto, @desp_dataReferencia, @desp_formaPagamento,
                                                                                                                @desp_dataPagamento, @desp_status)";

                res = db.ExecuteNonQuery(SQL, "@desp_descricao", desp.Descricao,
                                                "@desp_valor", desp.Valor - desp.Desconto,
                                                "@desp_idTipo", desp.IdTipo,
                                                "@desp_idCaixa", desp.IdCaixa,
                                                "@desp_desconto", desp.Desconto,
                                                "@desp_dataReferencia", desp.DataReferencia,
                                                "@desp_formaPagamento", desp.Forma_pagamento,
                                                "@desp_dataPagamento", desp.DataPagamento,
                                                "@desp_status", desp.Status
                                                );
            }
            return (res);
        }
        public bool estornarDespesa(int idParcela)
        {
            MessageBox.Show(idParcela + ":Despesa");
            bool res = false;
            string SQL = @"UPDATE despesa SET desp_status = 'DEVE', desp_formaPagamento = 'F'
                        WHERE desp_id = @desp_id";

            res = db.ExecuteNonQuery(SQL, "@desp_id", idParcela);

            return res;
        }
        public List<object> Buscar(string filtro)
        {
            List<object> expense = new List<object>();

            DataTable dt = new DataTable();



            string SQL = @"SELECT * FROM Despesa ";
            if (filtro != "")
            {
                SQL = SQL + "where " + filtro;
            }
            SQL = SQL + " order by desp_id DESC";
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
                    exp.DataPagamento = Convert.ToDateTime(dt.Rows[i]["desp_dataPagamento"].ToString());
                    exp.Forma_pagamento = dt.Rows[i]["desp_formaPagamento"].ToString();
                    exp.Status = dt.Rows[i]["desp_status"].ToString();
                    expense.Add(exp);
                }
            }


            return (expense);
        }
        public List<object> BuscarPorIdCaixa(int idCaixa)
        {
            List<object> expense = new List<object>();

            DataTable dt = new DataTable();



            string SQL = @"SELECT * FROM Despesa where desp_idCaixa = @idCaixa AND desp_status = 'PAGO' order by desp_id DESC";
            
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
                    exp.Status = dt.Rows[i]["desp_status"].ToString();
                    expense.Add(exp);
                }
            }


            return (expense);
        }
        public bool quitarDespesaParcial(int idParcela, double valorParcela, double valorPago, int idCaixa)
        {

            bool res = false;

            string SQL = @"UPDATE Despesa SET desp_idCaixa = @desp_idCaixa,
                                                    desp_valor = @desp_valor
                        WHERE desp_id = @desp_id";

            res = db.ExecuteNonQuery(SQL, "@desp_idCaixa", idCaixa,
                                            "@desp_valor", valorParcela - valorPago,
                                            "@desp_id", idParcela);

            return res;
        }
        public List<object> BuscarDespesaParaContasAPagar(string filtro)
        {
            List<object> expense = new List<object>();
            
            DataTable dt = new DataTable();
            


            string SQL = @"select desp_id, desp_dataReferencia, desp_dataPagamento, desp_status, desp_formaPagamento, desp_idCaixa, desp_valor,
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
                    // , , , , , , desp_valor, 
                    exp.Id = Convert.ToInt32(dt.Rows[i]["desp_id"]);
                    exp.DataReferencia = Convert.ToDateTime(dt.Rows[i]["desp_dataReferencia"].ToString());
                    exp.DataPagamento = Convert.ToDateTime(dt.Rows[i]["desp_dataPagamento"].ToString());
                    exp.Status = dt.Rows[i]["desp_status"].ToString();
                    exp.Forma_pagamento = dt.Rows[i]["desp_formaPagamento"].ToString();
                    exp.IdCaixa = Convert.ToInt32(dt.Rows[i]["desp_idCaixa"]);
                    exp.Valor = Convert.ToDouble(dt.Rows[i]["desp_valor"].ToString());
                    exp.Descricao = dt.Rows[i]["desp_tipo_nome"].ToString();
                    
                    expense.Add(exp);
                }
            }
           
            return (expense);
        }
        public List<object> BuscarFiltrado(string filtro)
        {
            List<object> expense = new List<object>();
            DataTable dt = new DataTable();
            /*
            string SQL = @"SELECT * FROM Despesa ";

            if(filtro != "")
            {
                SQL = SQL +"where "+ filtro;
            }
            SQL = SQL + " order by desp_id DESC";
            Console.WriteLine (SQL + "SQL!");
            db.ExecuteQuery(SQL, out dt);

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
                    exp.Criado_em = Convert.ToDateTime(dt.Rows[i]["desp_criado_em"].ToString());
                    exp.Desconto = Convert.ToDouble(dt.Rows[i]["desp_desconto"].ToString());
                    exp.DataDespesa = Convert.ToDateTime(dt.Rows[i]["desp_data"].ToString());
                    exp.DataVencimento = Convert.ToDateTime(dt.Rows[i]["desp_dtVencimento"].ToString());
                    exp.Forma_pagamento = dt.Rows[i]["desp_formaPagamento"].ToString();
                    exp.Status = dt.Rows[i]["desp_status"].ToString();

                    expense.Add(exp);
                }
            }*/
            return (expense);

        }
        public bool quitarDespesa(int idDespesa, char tipoPagamento, int idCaixa)
        {

            bool res = false;
            string SQL = @"UPDATE Despesa SET desp_status = 'PAGO',
                                                    desp_formaPagamento = @desp_formaPagamento,
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
                                            desp_dataPagamento = @desp_dataPagamento,
                                            desp_desconto = @desp_desconto,
                                            desp_dataReferencia = @desp_dataReferencia,
                                            desp_formaPagamento = @desp_formaPagamento,
                                            desp_status = @desp_status
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
                                                "@desp_status", desp.Status);
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
