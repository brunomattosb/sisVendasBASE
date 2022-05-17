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
    class ctrlProdutoCategoria
    {
        private Banco dataBase = new Banco();
        private ProdutoCategoria CategoriaSelecionada = new ProdutoCategoria();

        public bool SalvarCategoriaProduto(string id, string name)
        {

            // Verifica se existe um numero no tbCod
            if (Int32.TryParse(id, out int number))
                CategoriaSelecionada.Id = number;

            CategoriaSelecionada.Nome = name;

            dataBase.Conecta();
            bool res = false;

            ProdutoCategoriaDB categoriaDB = new ProdutoCategoriaDB(dataBase);
            if (number == 0)
            {
                res = categoriaDB.Gravar(CategoriaSelecionada);
            }
            else
            {
                res = categoriaDB.Atualizar(CategoriaSelecionada);
            }
            dataBase.Desconecta();

            return (res);
        }
        public DataTable Buscar(string filter)
        {

            DataTable dtCategoria = new DataTable();

            dtCategoria.Columns.Add("prod_categoria_id", typeof(int));
            dtCategoria.Columns.Add("prod_categoria_nome");
            dtCategoria.Columns.Add("prod_categoria_criado_em", typeof(DateTime));

            dataBase.Conecta();
            ProdutoCategoriaDB categoriaDB = new ProdutoCategoriaDB(dataBase);
            foreach (ProdutoCategoria categoria in categoriaDB.buscar(filter))
            {

                DataRow line = dtCategoria.NewRow();

                line["prod_categoria_id"] = categoria.Id;
                line["prod_categoria_nome"] = categoria.Nome;
                line["prod_categoria_criado_em"] = categoria.Criado_em;


                dtCategoria.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtCategoria);
        }
       
        public bool Remover(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ProdutoCategoriaDB categoriaDB = new ProdutoCategoriaDB(dataBase);
            res = categoriaDB.remover(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}
