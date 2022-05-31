using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace sisVendas.Persistence
{
    internal class BancoDB
    {
        private Banco db = null;
        public BancoDB(Banco db)
        {
            this.db = db;
        }

		//Producao
		//FILENAME = '"+Directory.GetCurrentDirectory() + @"\DataBase\dbSis.mdf',
		//Desenvolvimento
		//FILENAME = 'C:\Users\Bruno\Documents\sisVendas\sisVendas\DataBase\dbSis.mdf',
		public bool CriarDataBase()
        {
            bool res = false;
            
            String str;
            SqlConnection myConn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated security=SSPI;database=master");

            str = @"DROP DATABASE dbSis;";
			SqlCommand myCommand = new SqlCommand(str, myConn);
			myConn.Open();
			try
			{
				myCommand.ExecuteNonQuery();
			}
			catch{ }



			str = @"CREATE DATABASE dbSis ON PRIMARY 
            (NAME = dbSis,
            FILENAME = '" + Directory.GetCurrentDirectory() + @"\DataBase\dbSis.mdf',
            FILEGROWTH = 10 %)";

			myCommand = new SqlCommand(str, myConn);
            try
            {
                myCommand.ExecuteNonQuery();
                res = true;
                MessageBox.Show("DataBase criada com sucesso!", "SisVendas Automações Brasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Erro ao criar DataBase: "+ex.ToString(), "SisVendas Automações Brasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }

            return res;
        }
        public bool InserirTabelas()
        {
            bool res = false;
            string SQL = @"
CREATE TABLE [dbo].[Cliente] (
    [cli_id]           		INT             IDENTITY (1, 1) NOT NULL,
    [cli_nome]         		VARCHAR (50)    DEFAULT ('Sem nome') NULL,
    [cli_nome_fansasia] 	VARCHAR (50)    NULL,
    [cli_cpf_cnpj]     		VARCHAR (19)    UNIQUE NOT NULL,
    [cli_cep]     			VARCHAR (10)    NULL,
    [cli_endereco]      	VARCHAR (50)    NULL,
    [cli_bairro]    		VARCHAR (50)    NULL,
    [cli_cidade]         	VARCHAR (30)    NULL,
    [cli_telefone]    		VARCHAR (15)    NULL,
    [cli_rg_ie]        		VARCHAR (19)    NULL,
    [cli_uf]           		VARCHAR (3)     NULL,
    [cli_dt_aniversario]    DATETIME        NULL,
    [cli_sexo]          	CHAR (2)        NULL,
    [cli_saldo]      		NUMERIC (15, 2) DEFAULT ((0)) NULL,
    [cli_email]        		VARCHAR (100)   NULL,
	[cli_created_at]   		DATETIME        DEFAULT (getdate()) NULL,
	
    CONSTRAINT [PK_ID_CLIENTE] PRIMARY KEY CLUSTERED ([cli_id] ASC)
);
CREATE TABLE [dbo].[Funcionario] (
    [func_id]           	INT             IDENTITY (1, 1) NOT NULL,
    [func_nome]         	VARCHAR (50)    DEFAULT ('Sem nome') NULL,
    [func_cpf]          	VARCHAR (19)    NOT NULL,
    [func_cep]     			VARCHAR (10)    NULL,
    [func_endereco]       	VARCHAR (50)    NULL,
    [func_bairro]     		VARCHAR (50)    NULL,
    [func_cidade]         	VARCHAR (30)    NULL,
    [func_telefone]    		VARCHAR (15)    NULL,
    [func_rg]           	VARCHAR (19)    NULL,
    [func_uf]           	VARCHAR (3)     NULL,
    [func_dt_aniversario]   DATETIME        NULL,
	[func_sexo]          	CHAR (2)        NULL,
    [func_email]        	VARCHAR (100)   NULL,
	[func_salario_base]		NUMERIC (15,2) 	DEFAULT 0 NULL,
	[func_usuario]      	VARCHAR (50)   	NULL,
	[func_senha]     	 	VARCHAR (50)   	NULL,
	[func_licenca]       	VARCHAR (50)   	NULL,
	[func_admissao]     	DATETIME       	NULL,
	[func_demissao]   		DATETIME	  	NULL,
	[func_ativo]			BIT 			DEFAULT 0,
	[func_criado_em]   		DATETIME        DEFAULT (getdate()) NULL,
	
    CONSTRAINT [PK_ID_FUNCIONARIO_ID] PRIMARY KEY CLUSTERED ([func_id] ASC)
);
CREATE TABLE [dbo].[Fornecedor] (
    
	[forn_id]          		INT             IDENTITY (1, 1) NOT NULL,
	[forn_cpf_cnpj]    		VARCHAR (19)    NOT NULL,
	[forn_rg_ie]       		VARCHAR (19)    NULL,
    [forn_nome]        		VARCHAR (50)    DEFAULT ('Sem nome'),
	[forn_nome_fantasia] 	VARCHAR (50)    NULL,
	[forn_endereco]       	VARCHAR (50)    NULL,
	[forn_cidade]         	VARCHAR (30)    NULL,
	[forn_bairro]     		VARCHAR (50)    NULL,
	[forn_cep]     			VARCHAR (10)    NULL,
	[forn_uf]           	VARCHAR (3)     NULL,
	[forn_telefone]    		VARCHAR (15)    NULL,
	[forn_email]        	VARCHAR (100)   NULL,
	[forn_criado_em]   		DATETIME        DEFAULT (getdate()) NULL,
		
	
    CONSTRAINT [PK_ID_FORNECEDOR] PRIMARY KEY CLUSTERED ([forn_id] ASC)
);
CREATE TABLE [dbo].[DespesaTipo] (
    [desp_tipo_id]       	INT             IDENTITY (1, 1) NOT NULL,
    [desp_tipo_nome]     	VARCHAR (50)    DEFAULT ('Sem nome') NULL,
    [desp_tipo_criado_em]   DATETIME        DEFAULT (getdate()) NULL,

    CONSTRAINT [PK_ID_DESPESA_TIPO] PRIMARY KEY CLUSTERED ([desp_tipo_id] ASC)
);
CREATE TABLE [dbo].[ProdutoMarca] (
    [prod_marca_id]       	INT             IDENTITY (1, 1) NOT NULL,
    [prod_marca_nome]     	VARCHAR (50)    DEFAULT ('Sem nome') NULL,
    [prod_marca_criado_em]	DATETIME        DEFAULT (getdate()) NULL,

    CONSTRAINT [PK_ID_PRODUTO_MARCA] PRIMARY KEY CLUSTERED ([prod_marca_id] ASC)
);
CREATE TABLE [dbo].[ProdutoCategoria] (
    [prod_categoria_id]       INT             IDENTITY (1, 1) NOT NULL,
    [prod_categoria_nome]     VARCHAR (50)    DEFAULT ('Sem nome') NULL,
    [prod_categoria_criado_em]DATETIME        DEFAULT (getdate()) NULL,

    CONSTRAINT [PK_ID_PRODUTO_CATEGORIA] PRIMARY KEY CLUSTERED ([prod_categoria_id] ASC)
);
CREATE TABLE [dbo].[Produto] (
    [prod_id]           VARCHAR (40)    NOT NULL,
    [prod_nome]         VARCHAR (40)    DEFAULT ('Sem nome') NULL,
    [prod_complemento]   VARCHAR (200)   NOT NULL,
	[prod_estoque]    NUMERIC (15,2)  DEFAULT 0 NULL,
	[prod_un]           VARCHAR (3)    	NOT NULL,
	[prod_marca]        INT             NOT NULL,
	[prod_categoria]     INT             NOT NULL,
	[prod_valor]    	NUMERIC (15,2)  DEFAULT 0 NULL,
	[prod_criado_em]   DATETIME        DEFAULT (getdate()) NULL,
	
    CONSTRAINT [PK_ID_PRODUTO] PRIMARY KEY CLUSTERED ([prod_id] ASC),
	CONSTRAINT [FK_ID_PRODUCTBRAND] FOREIGN KEY ([prod_marca]) references ProdutoMarca(prod_marca_id),
	CONSTRAINT [FK_ID_PRODUCTCATEGORY	] FOREIGN KEY ([prod_categoria]) references ProdutoCategoria(prod_categoria_id)
);
CREATE TABLE [dbo].[Caixa] (
	[caixa_id]       		INT					IDENTITY (1, 1) NOT NULL,
	[caixa_idFunc]			INT				  	NOT NULL,
	[caixa_dtAbertura]      DATETIME         	DEFAULT (getdate()) NULL,
	[caixa_dtFechamento] 	DATETIME         	DEFAULT NULL,
	[caixa_saldoAnterior]	NUMERIC (15,2)  	DEFAULT 0 NULL,
	[caixa_entradas]		NUMERIC (15,2)  	DEFAULT 0 NULL,
	[caixa_saidas]			NUMERIC (15,2)  	DEFAULT 0 NULL,
	
	CONSTRAINT [PK_ID_CAIXAID] PRIMARY KEY CLUSTERED ([caixa_id] ASC),
	CONSTRAINT [FK_ID_CAIXA_FUNC] FOREIGN KEY ([caixa_idFunc]) references Funcionario(func_id),
);
CREATE TABLE [dbo].[Venda] (
	[venda_id]           	INT            		IDENTITY (1, 1) NOT NULL,
	[venda_idCliente]  	 	INT			    	NULL,
	[venda_idFunc]  	 	INT			    	NULL,
	[venda_desconto] 	 	NUMERIC (15,2) 		DEFAULT 0 NULL,
	[venda_cancelada] 	 	BIT 				DEFAULT 0,
	[venda_criado_em]  	 	DATETIME         	DEFAULT (getdate()),
	
    CONSTRAINT [PK_ID_VENDA] PRIMARY KEY CLUSTERED ([venda_id] ASC),
	CONSTRAINT [FK_ID_VENDA_CLIENT] FOREIGN KEY ([venda_idCliente]) references Cliente(cli_id),
	CONSTRAINT [FK_ID_VENDA_FUNC] FOREIGN KEY ([venda_idFunc]) references Funcionario(func_id),
);
CREATE TABLE [dbo].[ItenVenda] (
	[iten_quantidade] 		NUMERIC (15,2) 		DEFAULT 0 NULL,
	[iten_idVenda]         	INT					NOT NULL,
	[iten_idProduto]        VARCHAR (40)		NOT NULL,
	
	CONSTRAINT [FK_ID_PRODUTO_VENDA] FOREIGN KEY ([iten_idProduto]) references produto(prod_id),
	CONSTRAINT [FK_ID_VENDA] FOREIGN KEY ([iten_idVenda]) references Venda(venda_id),
);
CREATE TABLE [dbo].[ParcelaVenda] (
	[parcela_id]       		INT					IDENTITY (1, 1) NOT NULL,
	[parcela_idVenda]       INT					NOT NULL,
	[parcela_valor]			NUMERIC (15,2)  	DEFAULT 0 NULL,
	[parcela_tipo]         	VARCHAR (1)   	 	NOT NULL,
	[parcela_dataPagamento] DATETIME         	DEFAULT (getdate()) NULL,
	[parcela_dataVencimento]DATETIME         	DEFAULT (getdate()) NULL,
	[parcela_idCaixa]		INT				  	NOT NULL,
	
	CONSTRAINT [PK_ID_PARCELA_VENDA] PRIMARY KEY CLUSTERED ([parcela_id] ASC),
	CONSTRAINT [FK_ID_PARCELA_VENDA_ID] FOREIGN KEY ([parcela_idVenda]) references Venda(venda_id),
	CONSTRAINT [FK_ID_PARCELA_VENDA_ID_CAIXA] FOREIGN KEY ([parcela_idCaixa]) references Caixa(caixa_id),
);
CREATE TABLE [dbo].[Compra] (
	[compra_id]           	INT            		IDENTITY (1, 1) NOT NULL,
	[compra_idFornecedor]  	INT			    	NULL,
	[compra_idCaixa]  	INT			    	NOT NULL,
	[compra_desconto] 	 	NUMERIC (15,2) 		DEFAULT 0 NULL,
	[compra_cancelada] 	 	BIT 				DEFAULT 0,
	[compra_chave]        	VARCHAR (56)		NOT NULL,
	[compra_data]  			DATETIME         	DEFAULT (getdate()),
	[compra_criado_em]  	DATETIME         	DEFAULT (getdate()),
	
    CONSTRAINT [PK_ID_COMPRA] PRIMARY KEY CLUSTERED ([compra_id] ASC),
	CONSTRAINT [FK_ID_COMPRA_FORNECEDOR] FOREIGN KEY ([compra_idFornecedor]) references Fornecedor(forn_id),
	
);
CREATE TABLE [dbo].[ItenCompra] (
	[iten_quantidade] 		NUMERIC (15,2) 		DEFAULT 0 NULL,
	[iten_idCompra]         INT					NOT NULL,
	[iten_idProduto]        VARCHAR (40)		NOT NULL,
	[iten_valor] 			NUMERIC (15,2) 		DEFAULT 0 NULL,
	
	CONSTRAINT [FK_ID_PRODUTOCOMPRA] FOREIGN KEY ([iten_idProduto]) references Produto(prod_id),
	CONSTRAINT [FK_ID_COMPRAID] FOREIGN KEY ([iten_idCompra]) references Compra(compra_id),
);
CREATE TABLE [dbo].[ParcelaCompra] (
	[parcela_id]       		INT					IDENTITY (1, 1) NOT NULL,
	[parcela_idCompra]      INT					NOT NULL,
	[parcela_valor]			NUMERIC (15,2)  	DEFAULT 0 NULL,
	[parcela_tipo]         	VARCHAR (1)   	 	NOT NULL,
	[parcela_dataPagamento] DATETIME         	DEFAULT (getdate()) NULL,
	[parcela_dataVencimento]DATETIME         	DEFAULT (getdate()) NULL,
	[parcela_idcaixa]		INT				  	NOT NULL,
	
	CONSTRAINT [PK_ID_PARCELA_COMPRA] PRIMARY KEY CLUSTERED ([parcela_id] ASC),
	CONSTRAINT [FK_ID_PARCELA_COMPRA_ID] FOREIGN KEY ([parcela_idCompra]) references Compra(compra_id),
	CONSTRAINT [FK_ID_PARCELA_COMPRA_CAIXA] FOREIGN KEY ([parcela_idcaixa]) references Caixa(caixa_id),

);
CREATE TABLE [dbo].[Despesa] (
    [desp_id]           	INT             IDENTITY (1, 1) NOT NULL,
	[desp_idTipo]        	INT             NOT NULL,
    [desp_descricao]  		VARCHAR (200)   NULL,
	[desp_valor]        	NUMERIC (15, 2) DEFAULT ((0)) NULL,
	[desp_idCaixa]       	INT             NOT NULL,
	[desp_desconto]      	NUMERIC (15, 2) DEFAULT ((0)) NULL,
    [desp_formaPagamento]  	VARCHAR (1)		NULL,
    [desp_dataPagamento]   	DATETIME        DEFAULT (getdate()) NULL,
    [desp_dataReferencia]   DATETIME        DEFAULT (getdate()) NULL,
    [desp_dataVencimento]   DATETIME        DEFAULT (getdate()) NULL,

    CONSTRAINT [PK_ID_DESPESA] PRIMARY KEY CLUSTERED ([desp_id] ASC),
	CONSTRAINT [FK_ID_TIPO] FOREIGN KEY ([desp_idTipo]) references DespesaTipo(desp_tipo_id),
	CONSTRAINT [FK_ID_DESPESA_CAIXA] FOREIGN KEY ([desp_idCaixa]) references Caixa(caixa_id),
);
CREATE TABLE [dbo].[Promocao] (
    [promo_id]           	INT             IDENTITY (1, 1) NOT NULL,
	[promo_idFunc]           INT            NOT NULL,
    [promo_nome]  			VARCHAR (50)   	NOT NULL,
	[promo_inicio]   		DATETIME        NOT NULL,
	[promo_fim]   			DATETIME        NOT NULL,
	[promo_criado_em]   			DATETIME        NOT NULL,
	
    CONSTRAINT [PK_ID_PROMOCAO] PRIMARY KEY CLUSTERED ([promo_id] ASC),
	CONSTRAINT [FK_ID_FUNCIONARIO_PROMOCAO] FOREIGN KEY ([promo_idFunc]) references Funcionario(func_id),

);
CREATE TABLE [dbo].[TransacaoCaixa] (
	[transacao_id]       		INT					IDENTITY (1, 1) NOT NULL,
	[transacao_idCaixa]			INT				  	NOT NULL,
	[transacao_tipo] 			VARCHAR (1)         DEFAULT NULL,
	[transacao_descricao]		VARCHAR (50)        DEFAULT NULL,
	[transacao_valor]			NUMERIC (15,2)  	DEFAULT 0 NULL,	
	[transacao_criado_em]      	DATETIME         	DEFAULT (getdate()) NULL,
	
	CONSTRAINT [PK_ID_TRANSACAO] PRIMARY KEY CLUSTERED ([transacao_id] ASC),
	CONSTRAINT [FK_ID_TRANSACAO_CAIXA] FOREIGN KEY ([transacao_idCaixa]) references Caixa(caixa_id),
);
INSERT INTO Funcionario(func_nome,func_cpf,func_cep,func_endereco,func_bairro,func_cidade,func_telefone,func_rg,func_uf,func_dt_aniversario,
                        func_sexo,func_email,func_salario_base,func_usuario,func_senha,func_licenca, func_admissao, func_demissao, func_ativo)
                        VALUES ('Nome','99999999999','19470000','Endereço','Bairro','Epitácio','18998090748','9999999','SP',getdate(),
                        'M','Email@Email',0,'admin','admin','Master', getdate(), getdate(), 1)
";

			res = db.ExecuteNonQuery(SQL);
            

            return res;
        }
    }
}
