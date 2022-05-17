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
    class ctrlProdutoMarca
    {
        private Banco dataBase = new Banco();
        private ProdutoMarca marcaSelecionada = new ProdutoMarca();

        public bool salvarProdutoMarca(string id, string name)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                marcaSelecionada.Id = number;

            marcaSelecionada.Nome = name;

            dataBase.Conecta();
            bool result = false;
            ProdutoMarcaDB marcaDB = new ProdutoMarcaDB(dataBase);
            if (number == 0)
            {
                result = marcaDB.gravar(marcaSelecionada);
            }
            else
            {
                result = marcaDB.atualizar(marcaSelecionada);
            }
            dataBase.Desconecta();

            return (result);
        }
        public DataTable buscar(string filter)
        {

            DataTable dtProductbrand = new DataTable();

            dtProductbrand.Columns.Add("prod_marca_id", typeof(int));
            dtProductbrand.Columns.Add("prod_marca_nome");
            dtProductbrand.Columns.Add("prod_marca_criado_em", typeof(DateTime));

            dataBase.Conecta();
            ProdutoMarcaDB marcaDB = new ProdutoMarcaDB(dataBase);
            foreach (ProdutoMarca prodMarca in marcaDB.buscar(filter))
            {

                DataRow line = dtProductbrand.NewRow();

                line["prod_marca_id"] = prodMarca.Id;
                line["prod_marca_nome"] = prodMarca.Nome;
                line["prod_marca_criado_em"] = prodMarca.Criado_em;


                dtProductbrand.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtProductbrand);
        }
        public bool remover(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ProdutoMarcaDB marcaDB = new ProdutoMarcaDB(dataBase);
            res = marcaDB.remover(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}
