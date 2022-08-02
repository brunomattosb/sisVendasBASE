using DFe.Classes.Flags;
using DFe.Utils;
using NFe.Classes;
using NFe.Classes.Informacoes;
using NFe.Classes.Informacoes.Cobranca;
using NFe.Classes.Informacoes.Destinatario;
using NFe.Classes.Informacoes.Detalhe;
using NFe.Classes.Informacoes.Detalhe.Tributacao;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal.Tipos;
using NFe.Classes.Informacoes.Emitente;
using NFe.Classes.Informacoes.Identificacao;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Classes.Informacoes.Observacoes;
using NFe.Classes.Informacoes.Pagamento;
using NFe.Classes.Informacoes.Total;
using NFe.Classes.Informacoes.Transporte;
using NFe.Classes.Servicos.Tipos;
using NFe.Servicos;
using NFe.Servicos.Retorno;
using NFe.Utils;
using NFe.Utils.InformacoesSuplementares;
using NFe.Utils.NFe;
using sisVendas.Models;
using sisVendas.Telas.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace sisVendas.Telas.Sale
{
    public class EmitirNFCe
    {
        private ConfiguracaoApp _configApp = new ConfiguracaoApp();
        private NFe.Classes.NFe _nfe;
        private Cliente cli;
        private DataTable dtProdutos;
        private double desconto;
        private double txEntraga;
        private double troco;

        public EmitirNFCe()
        {

        }

        public RetornoNFeAutorizacao gerarNFCe(Cliente cliente, DataTable dtParcelas, DataTable dtProdutos, int numero, int lote, double desconto = 30, double txEntraga = 5, double troco = 50)
        {
            this.cli = cliente;
            this.dtProdutos = dtProdutos;
            this.desconto = desconto;
            this.txEntraga = txEntraga;
            this.troco = troco;

            _nfe = ObterNfeValidada(_configApp.CfgServico.VersaoNFeAutorizacao, _configApp.CfgServico.ModeloDocumento, numero, _configApp.ConfiguracaoCsc);

            var servicoNFe = new ServicosNFe(_configApp.CfgServico);
            // assincrono
            var retornoEnvio = servicoNFe.NFeAutorizacao(Convert.ToInt32(lote), IndicadorSincronizacao.Sincrono, new List<NFe.Classes.NFe> { _nfe }, true);//Envia a mensagem compactada para a SEFAZ;

            //X Para consumir o serviço de forma síncrona, use a linha abaixo: 
            //var retornoEnvio = servicoNFe.NFeAutorizacao(Convert.ToInt32(lote), IndicadorSincronizacao.Sincrono, new List<NFe.Classes.NFe> { _nfe }, true//Envia a mensagem compactada para a SEFAZ);


            var nfeproc = new nfeProc
            {
                NFe = _nfe,
                protNFe = retornoEnvio.Retorno.protNFe,
                versao = retornoEnvio.Retorno.versao
            };
            if (nfeproc.protNFe != null)
            {
                
                DateTime dt = DateTime.Now;
                var dir = string.IsNullOrEmpty(_configApp.CfgServico.DiretorioSalvarXml) ? AppDomain.CurrentDomain.BaseDirectory : (_configApp.CfgServico.DiretorioSalvarXml);
                dir = Path.Combine(dir, dt.Year.ToString(), dt.Month.ToString());
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                var filename = Path.Combine(dir, nfeproc.protNFe.infProt.chNFe +"-procNfe.xml");
                switch (retornoEnvio.Retorno.protNFe.infProt.cStat)
                {
                    case 100:
                    case 110:
                    case 150:
                    case 205:
                    case 301:
                    case 302:
                    case 303:
                        retornoEnvio.XmlProc = FuncoesXml.ClasseParaArquivoXml(nfeproc, filename);
                        retornoEnvio.Dir_xml = filename;
                        break;

                }



            }

            return retornoEnvio;

        }

        private NFe.Classes.NFe ObterNfeValidada(VersaoServico versaoServico, ModeloDocumento modelo, int numero, ConfiguracaoCsc configuracaoCsc)
        {
            var nfe = GetNf(numero, modelo, versaoServico);
            
            nfe.Assina();

            if (nfe.infNFe.ide.mod == ModeloDocumento.NFCe)
            {
                nfe.infNFeSupl = new infNFeSupl();
                if (versaoServico == VersaoServico.Versao400)
                    nfe.infNFeSupl.urlChave = nfe.infNFeSupl.ObterUrlConsulta(nfe, _configApp.ConfiguracaoDanfeNfce.VersaoQrCode);
                nfe.infNFeSupl.qrCode = nfe.infNFeSupl.ObterUrlQrCode(nfe, _configApp.ConfiguracaoDanfeNfce.VersaoQrCode, configuracaoCsc.CIdToken, configuracaoCsc.Csc);
            }

            nfe.Valida(_configApp.CfgServico);

            return nfe;
        }
        protected virtual NFe.Classes.NFe GetNf(int numero, ModeloDocumento modelo, VersaoServico versao)
        {
            var nf = new NFe.Classes.NFe { infNFe = GetInf(numero, modelo, versao) };
            return nf;
        }
        protected virtual infNFe GetInf(int numero, ModeloDocumento modelo, VersaoServico versao) 
        {

            var infNFe = new infNFe
            {
                versao = versao.VersaoServicoParaString(),
                ide = GetIdentificacao(numero, modelo, versao),
                emit = GetEmitente(),
                dest = GetDestinatario(versao, modelo),
                transp = GetTransporte()
            };

            desconto = desconto / dtProdutos.Rows.Count;
            int i = 0;
            foreach (DataRow row in dtProdutos.Rows)
            {
                
                infNFe.det.Add(GetDetalhe(row, i,infNFe.emit.CRT, modelo));
                i++;
            }

            
            infNFe.total = GetTotal(versao, infNFe.det);

            //NF-e
            if (infNFe.ide.mod == ModeloDocumento.NFe & (versao == VersaoServico.Versao310 || versao == VersaoServico.Versao400))
                infNFe.cobr = GetCobranca(infNFe.total.ICMSTot); //V3.00 e 4.00 Somente
            //NF-e E NFC-e
            if (infNFe.ide.mod == ModeloDocumento.NFCe || (infNFe.ide.mod == ModeloDocumento.NFe & versao == VersaoServico.Versao400))
                infNFe.pag = GetPagamento(infNFe.total.ICMSTot, versao); //NFCe Somente  
            //NFC-e
            if (infNFe.ide.mod == ModeloDocumento.NFCe & versao != VersaoServico.Versao400)
                infNFe.infAdic = new infAdic() { infCpl = string.Format("Troco: {0}", troco) }; //Susgestão para impressão do troco em NFCe

            return infNFe;
        }
        protected virtual ide GetIdentificacao(int numero, ModeloDocumento modelo, VersaoServico versao)
        {

            var ide = new ide
            {
                cUF = _configApp.EnderecoEmitente.UF,
                natOp = "VENDA",
                mod = modelo,
                serie = 1,
                nNF = numero,
                tpNF = TipoNFe.tnSaida,
                cMunFG = _configApp.EnderecoEmitente.cMun,
                tpEmis = _configApp.CfgServico.tpEmis,
                tpImp = TipoImpressao.tiRetrato,
                cNF = "1234",
                tpAmb = _configApp.CfgServico.tpAmb,
                finNFe = FinalidadeNFe.fnNormal,
                verProc = "3.000",
                indIntermed = IndicadorIntermediador.iiSemIntermediador
            };
            if (ide.tpEmis != TipoEmissao.teNormal)
            {
                ide.dhCont = DateTime.Now;
                ide.xJust = "TESTE DE CONTIGÊNCIA PARA NFe/NFCe";
            }

            #region V2.00

            if (versao == VersaoServico.Versao200)
            {
                ide.dEmi = DateTime.Today; //Mude aqui para enviar a nfe vinculada ao EPEC, V2.00
                ide.dSaiEnt = DateTime.Today;
            }

            #endregion

            #region V3.00

            if (versao == VersaoServico.Versao200)
                return ide;

            if (versao == VersaoServico.Versao310)
            {
                ide.indPag = IndicadorPagamento.ipVista;
            }


            ide.idDest = DestinoOperacao.doInterna;
            ide.dhEmi = DateTime.Now;
            //Mude aqui para enviar a nfe vinculada ao EPEC, V3.10
            if (ide.mod == ModeloDocumento.NFe)
                ide.dhSaiEnt = DateTime.Now;
            else
                ide.tpImp = TipoImpressao.tiNFCe;
            ide.procEmi = ProcessoEmissao.peAplicativoContribuinte;
            ide.indFinal = ConsumidorFinal.cfConsumidorFinal; //NFCe: Tem que ser consumidor Final
            ide.indPres = PresencaComprador.pcPresencial; //NFCe: deve ser 1 ou 4

            #endregion

            return ide;
        }
        
        
        protected virtual emit GetEmitente()
        {
            var emit = _configApp.Emitente; // new emit
            //{
            //    //CPF = "12345678912",
            //    CNPJ = "12345678000189",
            //    xNome = "RAZAO SOCIAL LTDA",
            //    xFant = "FANTASIA LTRA",
            //    IE = "123456789",
            //};

            emit.enderEmit = _configApp.EnderecoEmitente; // new enderEmit
            emit.enderEmit.cPais = 1058;
            emit.enderEmit.xPais = "BRASIL";
            return emit;
        }

        protected virtual dest GetDestinatario(VersaoServico versao, ModeloDocumento modelo)
        {
            var dest = new dest(versao);

            if (cli != null)
            {

                int qtdeCpfCnpj = cli.Cpf_cnpj.Count();
                if (qtdeCpfCnpj == 11)
                {
                    dest.CPF = cli.Cpf_cnpj;
                }
                else if(qtdeCpfCnpj == 14)
                {
                    dest.CNPJ = cli.Cpf_cnpj;
                }
                if (txEntraga > 0)
                    dest.enderDest = GetEnderecoDestinatario(); //Obrigatório para NFe e opcional para NFCe
                else dest.enderDest = null;
                
                if (_configApp.CfgServico.tpAmb == TipoAmbiente.Homologacao)
                    dest.xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL"; //Obrigatório para NFe e opcional para NFCe
                else
                {
                    dest.xNome = cli.Nome == ""? null:cli.Nome; //Obrigatório para NFe e opcional para NFCe
                }

                //if (versao == VersaoServico.Versao200)
                //    dest.IE = "ISENTO";
                if (versao == VersaoServico.Versao200)
                    return dest;

                dest.indIEDest = indIEDest.NaoContribuinte; //NFCe: Tem que ser não contribuinte V3.00 Somente
                dest.email = cli.Email == ""? null:cli.Email; //V3.00 Somente
            }
            else
            {
                return null;
            }
            return dest;
            
        }

        protected virtual enderDest GetEnderecoDestinatario()
        {
            cli.Endereco.cPais = 1058;
            cli.Endereco.xPais = "BRASIL";


            if (cli.Endereco.xLgr.Length == 0 )
            {
                FormMessageBox f = new FormMessageBox("Informe o Logradouro onde sera realizado a entrega:");
                f.ShowDialog();

                string lgr = f.retornaMsg();
                if (lgr != null)
                {
                    cli.Endereco.xLgr = lgr;
                }
                else
                {
                    cli.Endereco.xLgr = "Não informado!";
                }
            }

            if (cli.Endereco.nro.Length == 0)
            {
                FormMessageBox f = new FormMessageBox("Informe o Numero do Logradouro");
                f.ShowDialog();

                string lgr = f.retornaMsg();
                if (lgr != null)
                {
                    cli.Endereco.nro = lgr;
                }
                else
                {
                    cli.Endereco.nro = "S/N!";
                }
            }

            cli.Endereco.xBairro = cli.Endereco.xBairro == "" ? "Não informado" : cli.Endereco.xBairro;
            cli.Endereco.CEP = cli.Endereco.CEP == "" ? "99999999" : cli.Endereco.CEP;

            //var test =new enderDest
            //{
                //xLgr = cli.Endereco,
                //nro = cli.EndNumero,
                //xBairro = cli.Bairro,
                //cMun = 3541307,
                //xMun = "Presidente Epitácio",
                //UF = "SP",
                //CEP = cli.Cep,
                //cPais = 1058,
                //xPais = "BRASIL"
            //};
            return cli.Endereco;
        }

        protected virtual transp GetTransporte()
        {
            //var volumes = new List<vol> {GetVolume(), GetVolume()};

            var t = new transp
            {

                modFrete = ModalidadeFrete.mfSemFrete //NFCe: Não pode ter frete
                //vol = volumes 
            };

            return t;
        }
        protected virtual det GetDetalhe(DataRow row, int i, CRT crt, ModeloDocumento modelo)
        {
            var det = new det
            {
                nItem = i + 1,
                prod = GetProduto(i + 1, row),
                imposto = new imposto
                {
                    vTotTrib = 0.17m,

                    ICMS = new ICMS
                    {
                        //Se você já tem os dados de toda a tributação persistida no banco em uma única tabela, utilize a linha comentada abaixo para preencher as tags do ICMS
                        //TipoICMS = ObterIcmsBasico(crt),

                        //Caso você resolva utilizar método ObterIcmsBasico(), comente esta proxima linha
                        TipoICMS =
                            crt == CRT.SimplesNacional
                                ? InformarCSOSN(Csosnicms.Csosn102)
                                : InformarICMS(Csticms.Cst00, VersaoServico.Versao310)
                    },

                    //ICMSUFDest = new ICMSUFDest()
                    //{
                    //    pFCPUFDest = 0,
                    //    pICMSInter = 12,
                    //    pICMSInterPart = 0,
                    //    pICMSUFDest = 0,
                    //    vBCUFDest = 0,
                    //    vFCPUFDest = 0,
                    //    vICMSUFDest = 0,
                    //    vICMSUFRemet = 0
                    //},

                    COFINS = new COFINS
                    {
                        //Se você já tem os dados de toda a tributação persistida no banco em uma única tabela, utilize a linha comentada abaixo para preencher as tags do COFINS
                        //TipoCOFINS = ObterCofinsBasico(),

                        //Caso você resolva utilizar método ObterCofinsBasico(), comente esta proxima linha
                        TipoCOFINS = new COFINSOutr { CST = CSTCOFINS.cofins99, pCOFINS = 0, vBC = 0, vCOFINS = 0 }
                    },

                    PIS = new PIS
                    {
                        //Se você já tem os dados de toda a tributação persistida no banco em uma única tabela, utilize a linha comentada abaixo para preencher as tags do PIS
                        //TipoPIS = ObterPisBasico(),

                        //Caso você resolva utilizar método ObterPisBasico(), comente esta proxima linha
                        TipoPIS = new PISOutr { CST = CSTPIS.pis99, pPIS = 0, vBC = 0, vPIS = 0 }
                    }
                }
            };

            if (modelo == ModeloDocumento.NFe) //NFCe não aceita grupo "IPI"
            {
                det.imposto.IPI = new IPI()
                {
                    cEnq = 999,

                    //Se você já tem os dados de toda a tributação persistida no banco em uma única tabela, utilize a linha comentada abaixo para preencher as tags do IPI
                    //TipoIPI = ObterIPIBasico(),

                    //Caso você resolva utilizar método ObterIPIBasico(), comente esta proxima linha
                    TipoIPI = new IPITrib() { CST = CSTIPI.ipi00, pIPI = 5, vBC = 1, vIPI = 0.05m }
                };
            }
            
            //det.impostoDevol = new impostoDevol() { IPI = new IPIDevolvido() { vIPIDevol = 10 }, pDevol = 100 };

            return det;
        }
        protected virtual prod GetProduto(int i, DataRow row)
        {

            int CFOP = int.Parse(row["cfop_dentro"].ToString()) ;
            if(cli != null && cli.Endereco.UF != _configApp.Emitente.enderEmit.UF.ToString())
            {
                CFOP = int.Parse(row["cfop_fora"].ToString());
            }

            var p = new prod
            {
                cProd = i.ToString().PadLeft(5, '0'),
                cEAN = row["cod_barras"].ToString(), //código de barras
                xProd = (i == 1 & _configApp.CfgServico.tpAmb == TipoAmbiente.Homologacao) ? "NOTA FISCAL EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL" : row["cod_barras"].ToString() + " " + i,
                NCM = row["ncm"].ToString(),
                CFOP = CFOP,
                uCom = row["un"].ToString(),
                qCom = decimal.Parse(row["quantidade"].ToString()),
                vUnCom = decimal.Parse(row["valor_un"].ToString().Replace("R$ ", "")),
                vProd = decimal.Parse(row["valor_total"].ToString().Replace("R$ ", "")),
                vDesc = (decimal)desconto,
                cEANTrib = row["cod_barras"].ToString(),
                uTrib = row["un"].ToString(),
                qTrib = decimal.Parse(row["quantidade"].ToString()),
                vUnTrib = decimal.Parse(row["valor_un"].ToString().Replace("R$ ", "")),
                indTot = IndicadorTotal.ValorDoItemCompoeTotalNF,
                //NVE = {"AA0001", "AB0002", "AC0002"},
                //CEST = ?


                //ProdutoEspecifico = new arma
                //{
                //    tpArma = TipoArma.UsoPermitido,
                //    nSerie = "123456",
                //    nCano = "123456",
                //    descr = "TESTE DE ARMA"
                //}
            };
            return p;
        }
        protected virtual ICMSBasico InformarCSOSN(Csosnicms CST)
        {
            switch (CST)
            {
                case Csosnicms.Csosn101:
                    return new ICMSSN101
                    {
                        CSOSN = Csosnicms.Csosn101,
                        orig = OrigemMercadoria.OmNacional
                    };
                case Csosnicms.Csosn102:
                    return new ICMSSN102
                    {
                        CSOSN = Csosnicms.Csosn102,
                        orig = OrigemMercadoria.OmNacional
                    };
                //Outros casos aqui
                default:
                    return new ICMSSN201();
            }
        }

        protected virtual ICMSBasico InformarICMS(Csticms CST, VersaoServico versao)
        {
            var icms20 = new ICMS20
            {
                orig = OrigemMercadoria.OmNacional,
                CST = Csticms.Cst20,
                modBC = DeterminacaoBaseIcms.DbiValorOperacao,
                vBC = 1.1m,
                pICMS = 18,
                vICMS = 0.20m,
                motDesICMS = MotivoDesoneracaoIcms.MdiTaxi
            };
            if (versao == VersaoServico.Versao310)
                icms20.vICMSDeson = 0.10m; //V3.00 ou maior Somente

            switch (CST)
            {
                case Csticms.Cst00:
                    return new ICMS00
                    {
                        CST = Csticms.Cst00,
                        modBC = DeterminacaoBaseIcms.DbiValorOperacao,
                        orig = OrigemMercadoria.OmNacional,
                        pICMS = 18,
                        vBC = 1.1m,
                        vICMS = 0.20m
                    };
                case Csticms.Cst20:
                    return icms20;
                    //Outros casos aqui
            }

            return new ICMS10();
        }
        
        protected virtual List<pag> GetPagamento(ICMSTot icmsTot, VersaoServico versao)
        {
            var valorPagto = (icmsTot.vNF / 2).Arredondar(2);

            if (versao != VersaoServico.Versao400) // difernte de versão 4 retorna isso
            {
                var p = new List<pag>
                {
                    new pag {tPag = FormaPagamento.fpDinheiro, vPag = valorPagto},
                    new pag {tPag = FormaPagamento.fpCheque, vPag = icmsTot.vNF - valorPagto}
                };
                return p;
            }


            // igual a versão 4 retorna isso
            var p4 = new List<pag>
            {
                //new pag {detPag = new detPag {tPag = FormaPagamento.fpDinheiro, vPag = valorPagto}},
                //new pag {detPag = new detPag {tPag = FormaPagamento.fpCheque, vPag = icmsTot.vNF - valorPagto}}
                new pag
                {
                    detPag = new List<detPag>
                    {
                        new detPag {tPag = FormaPagamento.fpCreditoLoja, vPag = valorPagto},
                        new detPag {tPag = FormaPagamento.fpCreditoLoja, vPag = icmsTot.vNF - valorPagto}
                    }
                }
            };


            return p4;
        }
        protected virtual cobr GetCobranca(ICMSTot icmsTot)
        {
            var valorParcela = (icmsTot.vNF / 2).Arredondar(2);
            var c = new cobr
            {
                fat = new fat { nFat = "12345678910", vLiq = icmsTot.vNF, vOrig = icmsTot.vNF, vDesc = 0m },
                dup = new List<dup>
                {
                    new dup {nDup = "001", dVenc = DateTime.Now.AddDays(30), vDup = valorParcela},
                    new dup {nDup = "002", dVenc = DateTime.Now.AddDays(60), vDup = icmsTot.vNF - valorParcela}
                }
            };

            return c;
        }
        
       

        protected virtual total GetTotal(VersaoServico versao, List<det> produtos)
        {
            var icmsTot = new ICMSTot
            {
                vProd = produtos.Sum(p => p.prod.vProd),
                vDesc = produtos.Sum(p => p.prod.vDesc ?? 0),
                vTotTrib = produtos.Sum(p => p.imposto.vTotTrib ?? 0),
            };

            if (versao == VersaoServico.Versao310 || versao == VersaoServico.Versao400)
                icmsTot.vICMSDeson = 0;

            if (versao == VersaoServico.Versao400)
            {
                icmsTot.vFCPUFDest = 0;
                icmsTot.vICMSUFDest = 0;
                icmsTot.vICMSUFRemet = 0;
                icmsTot.vFCP = 0;
                icmsTot.vFCPST = 0;
                icmsTot.vFCPSTRet = 0;
                icmsTot.vIPIDevol = 0;
            }

            foreach (var produto in produtos)
            {
                if (produto.imposto.IPI != null && produto.imposto.IPI.TipoIPI.GetType() == typeof(IPITrib))
                    icmsTot.vIPI = icmsTot.vIPI + ((IPITrib)produto.imposto.IPI.TipoIPI).vIPI ?? 0;
                if (produto.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS00))
                {
                    icmsTot.vBC = icmsTot.vBC + ((ICMS00)produto.imposto.ICMS.TipoICMS).vBC;
                    icmsTot.vICMS = icmsTot.vICMS + ((ICMS00)produto.imposto.ICMS.TipoICMS).vICMS;
                }
                if (produto.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS20))
                {
                    icmsTot.vBC = icmsTot.vBC + ((ICMS20)produto.imposto.ICMS.TipoICMS).vBC;
                    icmsTot.vICMS = icmsTot.vICMS + ((ICMS20)produto.imposto.ICMS.TipoICMS).vICMS;
                }
                //Outros Ifs aqui, caso vá usar as classes ICMS00, ICMS10 para totalizar
            }

            //Regra de validação W16-10 que rege sobre o Total da NF
            icmsTot.vNF =
                icmsTot.vProd
                - icmsTot.vDesc
                - icmsTot.vICMSDeson.GetValueOrDefault()
                + icmsTot.vST
                + icmsTot.vFCPST.GetValueOrDefault()
                + icmsTot.vFrete
                + icmsTot.vSeg
                + icmsTot.vOutro
                + icmsTot.vII
                + icmsTot.vIPI
                + icmsTot.vIPIDevol.GetValueOrDefault();

            var t = new total { ICMSTot = icmsTot };
            return t;
        }
        
        
        
    }
}
