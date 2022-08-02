using DFe.Utils;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using sisVendas.Models;
using sisVendas.Persistence;
using System.Data;

namespace sisVendas.Controllers
{
    class ctrlProduct
    {
        private Banco dataBase = new Banco();
        private Produto ProdutoSelecionado = new Produto();


        public bool Salvar(string cod,
                    string cof_barras,
                    string nome,
                    string valor,
                    string id_marca,
                    string id_categoria,
                    string un,
                    string complemento,
                    string estoque,
                    string estoque_min,
                    string localizacao,
                    bool ativo,
                    bool balanca_ativo,
                    string ncm,
                    string cest,
                    object origem,
                    object situacao_tributaria,
                    object grupo_tributario,
                    string cfop_venda_dentro_estado,
                    string cfop_venda_fora_estado,
                    string cfop_entrada_dentro_estado,
                    string cfop_entrada_fora_estado,
                    string aliquota_icms)
        {
            int.TryParse(cod, out int out_codigo);
            ProdutoSelecionado.Id = out_codigo;
            ProdutoSelecionado.Codigo_barras = cof_barras;
            ProdutoSelecionado.Nome = nome;
            ProdutoSelecionado.Valor = double.Parse(valor.Replace("R$ ", ""));
            ProdutoSelecionado.Un = un;
            ProdutoSelecionado.Complemento = complemento;
            ProdutoSelecionado.Estoque = double.Parse(estoque);
            ProdutoSelecionado.Estoque_min = double.Parse(estoque_min);
            ProdutoSelecionado.Localizacao = localizacao;
            ProdutoSelecionado.Ativo = ativo;
            ProdutoSelecionado.Balanca = balanca_ativo;
            ProdutoSelecionado.Ncm = ncm;
            ProdutoSelecionado.Cest = cest;
            ProdutoSelecionado.Origem = EnumParaLista.GetEnumByDescription<OrigemMercadoria>(origem.ToString());
            ProdutoSelecionado.Situacao_tributaria = EnumParaLista.GetEnumByDescription<Csticms>(situacao_tributaria.ToString());
            ProdutoSelecionado.Grupo_tributacao = EnumParaLista.GetEnumByDescription<Csosnicms>(grupo_tributario.ToString());
            ProdutoSelecionado.Cfop_venda_dentro_estado = int.Parse(cfop_venda_dentro_estado);
            ProdutoSelecionado.Cfop_venda_fora_estado = int.Parse(cfop_venda_fora_estado);
            ProdutoSelecionado.Cfop_compra_dentro_estado = int.Parse(cfop_entrada_dentro_estado);
            ProdutoSelecionado.Cfop_compra_fora_estado = int.Parse(cfop_entrada_fora_estado);
            ProdutoSelecionado.Aliq_icms = double.Parse(aliquota_icms.Replace("%", ""));
            ProdutoSelecionado.Marca = new ProdutoMarca(int.Parse(id_marca)); 
            ProdutoSelecionado.Categoria = new ProdutoCategoria(int.Parse(id_categoria));

            dataBase.Conecta();
            bool result = false;

            ProductDB prodDB = new ProductDB(dataBase);

            if (out_codigo == 0)
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
        public bool verificarSeCodigoDeBarrasExiste(string codigo_barras, string cod)
        {

            dataBase.Conecta();
            ProductDB prodDB = new ProductDB(dataBase);
            bool res = true;
            if (prodDB.BuscarProduto("where prod_codigo_barras = '" + codigo_barras+"' AND prod_id != '"+cod+"'" ) == null)
                res = false;

            dataBase.Desconecta();

            return (res);
        }

        public DataTable buscarProdutosParaDGV(string filter)
        {

            dataBase.Conecta();
            ProductDB prodDB = new ProductDB(dataBase);
            DataTable dttProdutos = prodDB.BuscarParaDGV(filter);
            dataBase.Desconecta();

            return (dttProdutos);
        }
        public Produto buscarProdutoPorCodigo(string codigo)
        {


            dataBase.Conecta();
            ProductDB prodDB = new ProductDB(dataBase);
            Produto prod = prodDB.BuscarProduto("where prod_id = " + codigo +" or prod_codigo_barras like " + codigo);
            
            dataBase.Desconecta();

            return (prod);
        }
        //    public DataTable searthProduct(string filter)
        //    {

        //        DataTable dtProduct = new DataTable();

        //        dtProduct.Columns.Add("prod_id");
        //        dtProduct.Columns.Add("prod_nome");
        //        dtProduct.Columns.Add("prod_complemento");
        //        dtProduct.Columns.Add("prod_un");
        //        dtProduct.Columns.Add("prod_estoque", typeof(int));
        //        dtProduct.Columns.Add("prod_categoria", typeof(int));
        //        dtProduct.Columns.Add("prod_marca", typeof(int));
        //        dtProduct.Columns.Add("prod_valor", typeof(double));
        //        dtProduct.Columns.Add("prod_criado_em", typeof(DateTime));

        //        dataBase.Conecta();
        //        ProductDB prodDB = new ProductDB(dataBase);
        //        foreach (Produto prod in prodDB.Buscar(filter))
        //        {

        //            DataRow line = dtProduct.NewRow();

        //            line["prod_id"] = prod.Id;
        //            line["prod_nome"] = prod.Nome;
        //            line["prod_complemento"] = prod.Descricao;
        //            line["prod_estoque"] = prod.Estoque;
        //            line["prod_categoria"] = prod.Prod_Categoria;
        //            line["prod_marca"] = prod.Prod_Marca;
        //            line["prod_valor"] = prod.Valor;
        //            line["prod_un"] = prod.Un;
        //            line["prod_criado_em"] = prod.Criado_em;

        //            dtProduct.Rows.Add(line);
        //        }
        //        dataBase.Desconecta();

        //        return (dtProduct);
        //    }
        //    public DataTable buscarParaPromocao()
        //    {

        //        DataTable dtProduct = new DataTable();



        //        dataBase.Conecta();
        //        ProductDB prodDB = new ProductDB(dataBase);
        //        dtProduct = prodDB.buscarParaPromocao();

        //        dataBase.Desconecta();

        //        return (dtProduct);
        //    }
        //    public DataTable buscarParaRelatorio()
        //    {

        //        DataTable dtProduct = new DataTable();



        //        dataBase.Conecta();
        //        ProductDB prodDB = new ProductDB(dataBase);
        //        dtProduct = prodDB.buscarParaRelatorio();

        //        dataBase.Desconecta();

        //        return (dtProduct);
        //    }
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

        //    public Produto buscarProdutoPorCod(string filter)
        //    {

        //        Produto prod = new Produto();

        //        dataBase.Conecta();
        //        ProductDB bd = new ProductDB(dataBase);
        //        prod = (Produto)bd.BuscarPorCod(filter);

        //        dataBase.Desconecta();
        //        return prod;
        //    }


        public bool RemoverProduto(string cod)
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
