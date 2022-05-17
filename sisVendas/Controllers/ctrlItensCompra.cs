using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisVendas.Controllers
{ 
    internal class ctrlItensCompra
    {
        private Banco dataBase = new Banco();
        private ItenCompra ItensCompraSelecionado = new ItenCompra();

        public bool SalvarItensCompra(int id_compra, string id_produto, double quantidade, double valor)
        {
            ItensCompraSelecionado.Quantidade = quantidade;
            ItensCompraSelecionado.Id_produto = id_produto;
            ItensCompraSelecionado.Id_compra = id_compra;
            ItensCompraSelecionado.Valor = valor;

            dataBase.Conecta();
            bool result = false;
            ItensCompraDB itensCompra = new ItensCompraDB(dataBase);

            result = itensCompra.Gravar(ItensCompraSelecionado);

            dataBase.Desconecta();

            return (result);
        }

        public DataTable buscarItens(int filter)
        {
            dataBase.Conecta();
            ItensCompraDB itensDB = new ItensCompraDB(dataBase);

            DataTable dt = itensDB.buscarPorIdCompra(filter);

            dataBase.Desconecta();

            return (dt);
        }

        /*
        public bool removerItensCompra(int cod)
        {
            bool res = true;
            dataBase.Conecta();
            ItensCompraDB db = new ItensCompraDB(dataBase);
            res = db.removerItensCompra(cod);
            dataBase.Desconecta();
            return res;
        }*/
    }
}
