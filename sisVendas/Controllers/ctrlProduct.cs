using sisVendas.Models;
using sisVendas.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisVendas.Controllers
{
    class ctrlProduct
    {
        private Banco dataBase = new Banco();
        private Produto ProdutoSelecionado = new Produto();

        // DateTime created_at, char sex, double balance)
        public bool SaveProduct(string id, string nome, string complemento, int estoque, int categoria, int marca,
            double value, string UN)
        {

            // Verifica se existe um numero no tbCod
            ProdutoSelecionado.Id = id;
            ProdutoSelecionado.Nome = nome;
            ProdutoSelecionado.Descricao = complemento;
            ProdutoSelecionado.Estoque = estoque;
            ProdutoSelecionado.Prod_Categoria = categoria;
            ProdutoSelecionado.Prod_Marca = marca;
            ProdutoSelecionado.Valor = value;
            ProdutoSelecionado.Un = UN;

            dataBase.Conecta();
            bool result = false;

            ProductDB prodDB = new ProductDB(dataBase);
            if (prodDB.BuscarPorCod(id) == null)
            {
                result = prodDB.Gravar(ProdutoSelecionado);
            }
            else
            {
                result = prodDB.Atualizar(ProdutoSelecionado);
            }
            dataBase.Desconecta();

            return (result);
        }
        
        public DataTable searthProduct(string filter)
        {

            DataTable dtProduct = new DataTable();

            dtProduct.Columns.Add("prod_id");
            dtProduct.Columns.Add("prod_nome");
            dtProduct.Columns.Add("prod_complemento");
            dtProduct.Columns.Add("prod_un");
            dtProduct.Columns.Add("prod_estoque", typeof(int));
            dtProduct.Columns.Add("prod_categoria", typeof(int));
            dtProduct.Columns.Add("prod_marca", typeof(int));
            dtProduct.Columns.Add("prod_valor", typeof(double));
            dtProduct.Columns.Add("prod_criado_em", typeof(DateTime));

            dataBase.Conecta();
            ProductDB prodDB = new ProductDB(dataBase);
            foreach (Produto prod in prodDB.Buscar(filter))
            {

                DataRow line = dtProduct.NewRow();

                line["prod_id"] = prod.Id;
                line["prod_nome"] = prod.Nome;
                line["prod_complemento"] = prod.Descricao;
                line["prod_estoque"] = prod.Estoque;
                line["prod_categoria"] = prod.Prod_Categoria;
                line["prod_marca"] = prod.Prod_Marca;
                line["prod_valor"] = prod.Valor;
                line["prod_un"] = prod.Un;
                line["prod_criado_em"] = prod.Criado_em;
                
                dtProduct.Rows.Add(line);
            }
            dataBase.Desconecta();

            return (dtProduct);
        }
        public DataTable buscarParaRelatorio()
        {

            DataTable dtProduct = new DataTable();

          

            dataBase.Conecta();
            ProductDB prodDB = new ProductDB(dataBase);
            dtProduct = prodDB.buscarParaRelatorio();
           
            dataBase.Desconecta();

            return (dtProduct);
        }
        public bool removerEstoque(string idProd, double estoque)
        {

            bool res = true;

            dataBase.Conecta();
            ProductDB bd = new ProductDB(dataBase);
            res = bd.subtraitEstoque(idProd, estoque);

            dataBase.Desconecta();
            return res;
        }
        public bool adicionarEstoque(string idProd, double estoque)
        {

            bool res = true;

            dataBase.Conecta();
            ProductDB bd = new ProductDB(dataBase);
            res = bd.incrementarEstoque(idProd, estoque);

            dataBase.Desconecta();
            return res;
        }
        public Produto buscarProdutoPorCod(string filter)
        {

            Produto prod = new Produto();

            dataBase.Conecta();
            ProductDB bd = new ProductDB(dataBase);
            prod = (Produto)bd.BuscarPorCod(filter);

            dataBase.Desconecta();
            return prod;
        }


        public bool removeProduct(string cod)
        {
            bool res = true;
            dataBase.Conecta();
            ProductDB prodDB = new ProductDB(dataBase);
            res = prodDB.Remover(cod);
            dataBase.Desconecta();
            return res;
        }
    }
}
