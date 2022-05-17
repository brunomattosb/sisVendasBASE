using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    internal class ItensCompraDB
    {
        private Banco db = null;
        public ItensCompraDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(ItenCompra))
            {
                ItenCompra itensCompra = (ItenCompra)Objeto;

                string SQL;

                SQL = @"INSERT INTO ItenCompra (iten_quantidade,iten_idCompra,iten_idProduto, iten_valor)
                        values (@iten_quantidade,@iten_idCompra,@iten_idProduto, @iten_valor)";


                res = db.ExecuteNonQuery(SQL, "@iten_quantidade", itensCompra.Quantidade,
                                                "@iten_idCompra", itensCompra.Id_compra,
                                                "@iten_idProduto", itensCompra.Id_produto,
                                                "@iten_valor", itensCompra.Valor);



            }
            return (res);
        }
        public DataTable buscarPorIdCompra(int filtro)
        {
            DataTable dt = new DataTable();

            string SQL = @"select iten_quantidade, iten_idProduto,iten_valor, iten_quantidade * iten_valor as total, Produto.prod_un, Produto.prod_nome  
	                                                                                                    from ItenCompra 
	                        inner join Produto ON Produto.prod_id = ItenCompra.iten_idProduto
                        where iten_idCompra = @filtro";

            db.ExecuteQuery(SQL, out dt, "@filtro", filtro);

  
            return (dt);

        }
        /*
        public bool removerItensCompra(int id)
        {
            bool res = false;
            string SQL = @"DELETE FROM ItensCompra WHERE iten_idCompra = @id";
            res = db.ExecuteNonQuery(SQL, "@id", id);
            return res;
        }*/
    }
}
