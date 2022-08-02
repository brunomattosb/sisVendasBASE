using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using System;

namespace sisVendas.Models
{
    class Produto 
    {
		private int id;
		private string codigo_barras;
		private string nome;
		private string un;
		private string complemento;
		private string cest;
		private string ncm;
		private string localizacao;
		private double valor;
		private double estoque;
		private double estoque_min;
		private double aliq_icms;
		private ProdutoMarca marca;
		private ProdutoCategoria categoria;
		private OrigemMercadoria origem;
		private Csosnicms grupo_tributacao;
		private Csticms situacao_tributaria;
		private int cfop_venda_dentro_estado;
		private int cfop_compra_fora_estado;
		private int cfop_compra_dentro_estado;
		private int cfop_venda_fora_estado;
		private DateTime criado_em;
		private bool ativo;
		private bool balanca;

        public Produto()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Codigo_barras { get => codigo_barras; set => codigo_barras = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Un { get => un; set => un = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cest { get => cest; set => cest = value; }
        public string Ncm { get => ncm; set => ncm = value; }
        public string Localizacao { get => localizacao; set => localizacao = value; }
        public double Valor { get => valor; set => valor = value; }
        public double Estoque { get => estoque; set => estoque = value; }
        public double Estoque_min { get => estoque_min; set => estoque_min = value; }
        public double Aliq_icms { get => aliq_icms; set => aliq_icms = value; }
        public OrigemMercadoria Origem { get => origem; set => origem = value; }
        public Csosnicms Grupo_tributacao { get => grupo_tributacao; set => grupo_tributacao = value; }
        public Csticms Situacao_tributaria { get => situacao_tributaria; set => situacao_tributaria = value; }
        public int Cfop_venda_dentro_estado { get => cfop_venda_dentro_estado; set => cfop_venda_dentro_estado = value; }
        public int Cfop_compra_fora_estado { get => cfop_compra_fora_estado; set => cfop_compra_fora_estado = value; }
        public int Cfop_compra_dentro_estado { get => cfop_compra_dentro_estado; set => cfop_compra_dentro_estado = value; }
        public int Cfop_venda_fora_estado { get => cfop_venda_fora_estado; set => cfop_venda_fora_estado = value; }
        public DateTime Criado_em { get => criado_em; set => criado_em = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public bool Balanca { get => balanca; set => balanca = value; }
        internal ProdutoMarca Marca { get => marca; set => marca = value; }
        internal ProdutoCategoria Categoria { get => categoria; set => categoria = value; }
    }
}
