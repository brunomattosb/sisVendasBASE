using sisVendas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Persistence
{
    internal class ItemsPromocaoDB
    {
        private Banco db = null;
        public ItemsPromocaoDB(Banco db)
        {
            this.db = db;
        }
        public bool Gravar(object Objeto)
        {
            bool res = false;

            if (Objeto.GetType() == typeof(ItemsPromocao))
            {
                ItemsPromocao itensPromocao = (ItemsPromocao)Objeto;

                string SQL;

                SQL = @"INSERT INTO ItensPromocao (iten_idPromocao,iten_idProduto, iten_valor)
                        values (@iten_idPromocao,@iten_idProduto, @iten_valor)";

                res = db.ExecuteNonQuery(SQL, "@iten_idPromocao", itensPromocao.Id_promocao,
                                                "@iten_idProduto", itensPromocao.Id_produto,
                                                "@iten_valor", itensPromocao.Valor);
            }
            return (res);
        }
        public DataTable buscarPorIdPromo(int filtro)
        {
            DataTable dt = new DataTable();

            string SQL = @"select prod_nome, iten_valor from ItensPromocao 
        inner join Produto on Produto.prod_id = ItensPromocao.iten_idProduto
                        where iten_idPromocao = @filtro";

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
