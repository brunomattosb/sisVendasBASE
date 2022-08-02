using DFe.Classes.Flags;
using DFe.Utils;
using NFe.Classes;
using sisVendas.Controllers;
using sisVendas.Funcoes;
using sisVendas.Models;
using sisVendas.Screens.Create;
using sisVendas.Screens.Sale;
using sisVendas.Telas;
using sisVendas.Telas.Caixa;
using sisVendas.Telas.Compra;
using sisVendas.Telas.Promocao;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace sisVendas
{
    public partial class FormHome : Form
    {
        private Funcionario funcLogado;
        private ctrlCaixa controlCaixa = new ctrlCaixa();
        private Caixa caixaSelecionado = null;
        private ConfiguracaoApp _configApp = new ConfiguracaoApp();
        private NFe.Classes.NFe _nfe;
        public FormHome()
        {
            InitializeComponent();

            _configApp.lerXml();

            
        }

        private void verificarValidadeCertificado()
        {
            int dias = ((int)(_configApp.CfgServico.Certificado.Dt_vencimento - DateTime.Now).TotalDays);

            if (dias < 30)
            {
                MessageBox.Show(String.Format("O Certificado Digital selecionado está perto da data de vencimento!\n{0}", _configApp.CfgServico.Certificado.Dt_vencimento), "Alerta - Certificado Digital!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool validaLogin()
        {
            FormLogin f = new FormLogin(_configApp.Dir_imagem_logo);
            f.ShowDialog();

            funcLogado = f.retornaFuncionario();

            if (funcLogado == null)
            {
                return false;
            }
            else
            {
                //Nome do Form
                string nomeForm = "Automações Brasil - SisVendas V1.0.0";
                if (_configApp.Emitente.xNome != null)
                    nomeForm += String.Format(" - {0}", _configApp.Emitente.xNome);
                this.Text = nomeForm;

                lblNomeFuncLogado.Text = funcLogado.Nome;
                //this.WindowState = FormWindowState.Maximized;

                
                return true;
            }
            
        }

        #region OpenForm
        
        
        private void menuBtnFuncionario_Click(object sender, EventArgs e)
        {
                
            FormCriarFuncionario f = new FormCriarFuncionario();
            f.ShowDialog();
        }


        private void menuBtnClient_Click(object sender, EventArgs e)
        {
            FormCriarCliente f = new FormCriarCliente();
            f.ShowDialog();
        }

        private void menuBtnProvider_Click(object sender, EventArgs e)
        {
            FormCreiarFornecedor f = new FormCreiarFornecedor();
            f.ShowDialog();
        }

        private void menuBtnProduct_Click(object sender, EventArgs e)
        {
            FormCreateProduct f = new FormCreateProduct();
            f.ShowDialog();
        }

        private void menuBtnProductCategory_Click(object sender, EventArgs e)
        {
            FormCreateProductCategory f = new FormCreateProductCategory();
            f.ShowDialog();
        }

        private void menuBtnProductBrand_Click(object sender, EventArgs e)
        {
            FormCreateProductBrand f = new FormCreateProductBrand();
            f.ShowDialog();
        }


        private void menuBtnExpenseType_Click(object sender, EventArgs e)
        {
            FormCreateExpenseType f = new FormCreateExpenseType();
            f.ShowDialog();
        }

        private void menuBtnParameterization_Click(object sender, EventArgs e)
        {
            FormParameterization f = new FormParameterization();
            f.ShowDialog();
        }

        private void menuBtnEfetuarVenda_Click(object sender, EventArgs e)
        {
            if(lblCaixaStatus.Text == "FECHADO")
            {
                MessageBox.Show("Abra o caixa para continuar!", "Caixa Fechado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                verificarValidadeCertificado();
                FormVenda f = new FormVenda(caixaSelecionado.Id, caixaSelecionado.Funcionario.Id);
                f.WindowState = FormWindowState.Maximized;
                f.FormBorderStyle = FormBorderStyle.None;
                f.ShowDialog();
            }            
        }
        private void menuBtnAbrirFecharCaixa_Click(object sender, EventArgs e)
        {
            FormControleCaixa f = new FormControleCaixa(funcLogado.Id);
            f.ShowDialog();

            //caixaSelecionado = f.retornaCaixa();

            alterarLabel();
        }
        #endregion

        private void FormHome_Load(object sender, EventArgs e)
        {
            if(validaLogin())
            {
                // Se o login for true, busca o caixa logado aberto.
                buscarCaixaAberto(funcLogado.Id);

                //validar data
                TimeSpan diferenca = GetNetworkTime().Subtract(DateTime.Now);
                if (diferenca.Days != 0 || diferenca.Hours != 0)
                {
                    if (MessageBox.Show("Foi detectada uma difereça consideravel entre a data do Sistema Operacional e a atual.\nEsta diferença ocasionará erros ao realizar operações no sistema.\n\n Deseja continuar?", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else
            {
                Close();
            }
        }
        private void buscarResumo()
        {
            DataTable dttResumoHome = controlCaixa.BuscarResumoFormHome();

            if (double.TryParse(dttResumoHome.Rows[0]["valorAReceber"].ToString(), out double valorAReceber))
            {
                lblValorAReceber.Text = valorAReceber.ToString("C");
            }
            else
            {
                lblValorAReceber.Text = "R$ 0,00";
            }

            double.TryParse(dttResumoHome.Rows[0]["valorDespAPagar"].ToString(), out double valorDespesa);
            double.TryParse(dttResumoHome.Rows[0]["valorParcelaVenda"].ToString(), out double valorParcelasVenda);
            lblValorAPagar.Text = (valorDespesa + valorParcelasVenda).ToString("C");
        }
        private void buscarCaixaAberto(int idFunc)
        {

            caixaSelecionado = controlCaixa.buscarCaixaAberto(idFunc);

            buscarResumo();

            alterarLabel();
        }
        private void alterarLabel()
        {

            if(caixaSelecionado == null)
            {
                lblCaixaStatus.Text = "FECHADO";
                lblCaixaStatus.ForeColor = Color.Red;
            }
            else
            {
                if (caixaSelecionado.Dtfechamento != null) // caixa FECHADO
                {
                    lblCaixaStatus.Text = "FECHADO";
                    lblCaixaStatus.ForeColor = Color.Red;
                }
                else
                {
                    lblCaixaStatus.Text = "ABERTO";
                    lblCaixaStatus.ForeColor = Color.Green;
                }
            }
        }

        private void menuBtnLancarDespesa_Click(object sender, EventArgs e)
        {
            

            if (lblCaixaStatus.Text == "FECHADO.")
            {
                Alerta.notificacao("Caixa Fechado!", "Abra o caixa para continuar!", Alerta.enmType.Warning);
            }
            else
            {

                FormLancarDespesas f = new FormLancarDespesas(caixaSelecionado.Id);
                f.ShowDialog();
            }
        }

        private void menuBtnLancarCompra_Click(object sender, EventArgs e)
        {
            if (lblCaixaStatus.Text == "FECHADO.")
            {
                Alerta.notificacao("Caixa Fechado!", "Abra o caixa para continuar!", Alerta.enmType.Warning);
            }
            else
            {
                FormLancarCompra f = new FormLancarCompra(caixaSelecionado.Id);
                f.ShowDialog();
            }
        }


        private void menuBtnQuitarRecebimento_Click(object sender, EventArgs e)
        {
            if (lblCaixaStatus.Text == "FECHADO.")
            {
                Alerta.notificacao("Caixa Fechado!", "Abra o caixa para continuar!", Alerta.enmType.Warning);
            }
            else
            {
                FormContasAReceber f = new FormContasAReceber(caixaSelecionado.Id);
                f.ShowDialog();
            }
        }

        private void menuBtnQuitarPagamento_Click(object sender, EventArgs e)
        {
            if (lblCaixaStatus.Text == "FECHADO.")
            {
                Alerta.notificacao("Caixa Fechado!", "Abra o caixa para continuar!", Alerta.enmType.Warning);
            }
            else
            {
                FormContasAPagar f = new FormContasAPagar(caixaSelecionado.Id);
                f.ShowDialog();
            }
        }

        private void menuBtnRegistrarPromocao_Click(object sender, EventArgs e)
        {

            FormRegistrarPromocao f = new FormRegistrarPromocao(funcLogado.Id);
            f.ShowDialog();

        }

        private void FormHome_Activated(object sender, EventArgs e)
        {
            buscarResumo();
        }


        private void btnGerarXml_Click(object sender, EventArgs e)
        {
            /*
            Boletos objBoletos = new Boletos();
            string strImpressora = "";
            bool blnImprimir = false;
            int intCopias = 1;


            try
            {
                //CRIAÇÃO DA PARTE DO CEDENTE
                //Cabeçalho do Banco
                objBoletos.Banco = Banco.Instancia(756);
                objBoletos.Banco.Cedente = new Cedente();
                objBoletos.Banco.Cedente.CPFCNPJ = "24.368.434/0001-07";
                objBoletos.Banco.Cedente.Nome = "EMPRESA COBRADORA";
                objBoletos.Banco.Cedente.Observacoes = "Primeiro boleto teste!";

                ContaBancaria conta = new ContaBancaria();
                conta.Agencia = "1234";
                conta.DigitoAgencia = "0";
                conta.OperacaoConta = "";
                conta.Conta = "12345";
                conta.DigitoConta = "0";
                conta.CarteiraPadrao = "1";

                conta.VariacaoCarteiraPadrao = "01";
                conta.TipoCarteiraPadrao = TipoCarteira.CarteiraCobrancaSimples;
                conta.TipoFormaCadastramento = TipoFormaCadastramento.ComRegistro;
                conta.TipoImpressaoBoleto = TipoImpressaoBoleto.Empresa;
                conta.TipoDocumento = TipoDocumento.Tradicional;

                Endereco ender = new Endereco();
                ender.LogradouroEndereco = "Av. das Pitangas";
                ender.LogradouroNumero = "569";
                ender.LogradouroComplemento = "Logo Ali Meu Irmão";
                ender.Bairro = "São João";
                ender.Cidade = "Sertãozinho";
                ender.UF = "SP";
                ender.CEP = "14170230";

                objBoletos.Banco.Cedente.Codigo = "123456";
                objBoletos.Banco.Cedente.CodigoDV = "6";
                objBoletos.Banco.Cedente.CodigoTransmissao = "000000";
                objBoletos.Banco.Cedente.ContaBancaria = conta;
                objBoletos.Banco.Cedente.Endereco = ender;

                objBoletos.Banco.FormataCedente();
                int I;
                for (I = 1; I <= 1; I++)
                {
                    // CRIAÇÃO DO TITULO
                    Boleto Titulo = new Boleto(objBoletos.Banco);
                    Titulo.Sacado = new Sacado();
                    Titulo.Sacado.CPFCNPJ = "03861018250";
                    Titulo.Sacado.Endereco = new Endereco();
                    Titulo.Sacado.Endereco.Bairro = "Bairro";
                    Titulo.Sacado.Endereco.CEP = "19470000";
                    Titulo.Sacado.Endereco.Cidade = "Cidade";
                    Titulo.Sacado.Endereco.LogradouroComplemento = "";
                    Titulo.Sacado.Endereco.LogradouroEndereco = "Rua Da Esquina Perdida Logo Ali";
                    Titulo.Sacado.Endereco.LogradouroNumero = "569";
                    Titulo.Sacado.Endereco.UF = "SP";

                    Titulo.Sacado.Nome = "Nome do pagador";
                    Titulo.Sacado.Observacoes = "Pagar com urgência para não ser protestado.";

                    Titulo.CodigoOcorrencia = "01";
                    Titulo.DescricaoOcorrencia = "Remessa Registrar";
                    Titulo.NumeroDocumento = I.ToString();
                    Titulo.NumeroControleParticipante = "12";
                    Titulo.NossoNumero = "123456" + I;
                    Titulo.DataEmissao = DateTime.Now;
                    Titulo.DataVencimento = DateTime.Now.AddDays(15);
                    Titulo.ValorTitulo = decimal.Parse(200.0.ToString()); // rever aq
                    Titulo.Aceite = "N";
                    Titulo.EspecieDocumento = TipoEspecieDocumento.DM;
                    Titulo.DataDesconto = DateTime.Now.AddDays(15);
                    Titulo.ValorDesconto = 45;


                    //PARTE DA MULTA
                    Titulo.DataMulta = DateTime.Now.AddDays(15);
                    Titulo.PercentualMulta = 2;
                    Titulo.ValorMulta = Titulo.ValorTitulo * Titulo.PercentualMulta / 100;
                    Titulo.MensagemInstrucoesCaixa = $"Cobrar multa de {Titulo.ValorMulta,2} após a data de vencimento.";

                    //PARTE JUROS DE MORA
                    Titulo.DataJuros = DateTime.Now.AddDays(15);
                    Titulo.PercentualJurosDia = 10 / 30;
                    Titulo.ValorJurosDia = Titulo.ValorTitulo * Titulo.PercentualJurosDia / 100;

                    string instrucoes = $"Cobrar juros de {Titulo.PercentualJurosDia,2} por dia.";

                    if (string.IsNullOrEmpty(Titulo.MensagemInstrucoesCaixa))
                        Titulo.MensagemInstrucoesCaixa = instrucoes;
                    else
                        Titulo.MensagemInstrucoesCaixa += Environment.NewLine + instrucoes;

                    
                    //Titulo.CodigoInstrucao1 = String.Empty
                    //Titulo.ComplementoInstrucao1 = String.Empty

                    //Titulo.CodigoInstrucao2 = String.Empty
                    //Titulo.ComplementoInstrucao2 = String.Empty

                    //Titulo.CodigoInstrucao3 = String.Empty
                    //Titulo.ComplementoInstrucao3 = String.Empty
                    
                    Titulo.CodigoProtesto = TipoCodigoProtesto.NaoProtestar;
                    Titulo.DiasProtesto = 0;
                    Titulo.CodigoBaixaDevolucao = TipoCodigoBaixaDevolucao.NaoBaixarNaoDevolver;
                    Titulo.DiasBaixaDevolucao = 0;
                    Titulo.ValidarDados();
                    objBoletos.Add(Titulo);
                }



                //if (File.Exists(Application.StartupPath & "\remessa.txt") )
                //    File.Delete(Application.StartupPath & "\remessa.txt")

                //GERA ARQUIVO DE REMESSA
                MemoryStream st = new MemoryStream();
                ArquivoRemessa remessa = new ArquivoRemessa(objBoletos.Banco, TipoArquivo.CNAB240, 1);
                remessa.GerarArquivoRemessa(objBoletos, st);

                FileStream arquivo = new FileStream(@"C:\Users\Bruno\Desktop\TesteBoleto\remessa.txt", FileMode.Create, FileAccess.ReadWrite);

                st.WriteTo(arquivo);
                arquivo.Close();
                st.Close();


                StreamReader LerArquivo = new StreamReader(@"C:\Users\Bruno\Desktop\TesteBoleto\remessa.txt");

                StreamWriter RefazArquivo = new StreamWriter(@"C:\Users\Bruno\Desktop\TesteBoleto\remessa2.txt"); //Arquivo verificado para ser enviado ao banco
                string strTexto = "";
                int conta1 = 0;



                do
                {
                    strTexto = LerArquivo.ReadLine();
                    conta1 = strTexto.Length;

                    if (conta1 < 240)
                    {
                        conta1 = 240 - conta1;
                        string strEspaco = "";
                        for (I = 1; I < conta1; I++)
                        {
                            strEspaco = strEspaco + " ";
                        }
                        RefazArquivo.WriteLine(strTexto + strEspaco);
                    }
                    else
                    {
                        RefazArquivo.WriteLine(strTexto);
                    }

                } while (LerArquivo.Peek() != -1);



                RefazArquivo.Close();
                LerArquivo.Close();

                //Solicita se vai imprimir os boletos
                //if MessageBox.Show("Deseja imprimir os boletos agora?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                //    Dim imp As New PrintDialog
                //    If imp.ShowDialog = DialogResult.OK Then
                //        strImpressora = imp.PrinterSettings.PrinterName
                //        intCopias = imp.PrinterSettings.Copies
                //        blnImprimir = True
                //    End If
                //End If

                //Gera boletos
                int numBoletos = 0;
                foreach (Boleto linha in objBoletos)
                {
                    numBoletos += 1;
                    BoletoBancario NovoBoleto = new BoletoBancario();
                    NovoBoleto.Boleto = linha;
                    var pdf = NovoBoleto.MontaBytesPDF();
                    File.WriteAllBytes(@"C:\Users\Bruno\Desktop\TesteBoleto\boleto" + numBoletos + ".pdf", pdf);

                    //'Parte da impressão do boleto
                    if (blnImprimir = true)
                    {
                        
                        //Dim MyProcess As New Process
                        //MyProcess.StartInfo.CreateNoWindow = False
                        //MyProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                        //MyProcess.StartInfo.Verb = "print"
                        //MyProcess.StartInfo.Arguments = strImpressora

                        //MyProcess.StartInfo.FileName = Application.StartupPath & "\boleto" & numBoletos & ".pdf"
                        //MyProcess.Start()
                        //'MyProcess.WaitForExit(10000)
                        //MyProcess.WaitForInputIdle()

                        //If MyProcess.Responding Then
                        //    MyProcess.CloseMainWindow()
                        //Else
                        //    MyProcess.Kill()
                        //End If

                        //MyProcess.Close()
                    }
                        
                }

                MessageBox.Show("Boleto Gerado.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
             

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("coluna");
            dt.Columns.Add("coluna1");
            dt.Columns.Add("coluna2");
            dt.Columns.Add("coluna3");

            for(int i = 0; i < 1000; i++)
            {
                DataRow linha = dt.NewRow();

                linha["coluna"] = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
                linha["coluna1"] = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
                linha["coluna2"] = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
                linha["coluna3"] = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";

                dt.Rows.Add(linha);
            }

            DateTime inicio = DateTime.Now;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string teste1 = dt.Rows[i]["coluna"].ToString();
                string teste2 = dt.Rows[i]["coluna1"].ToString();
                string teste3 = dt.Rows[i]["coluna2"].ToString();
                string teste4 = dt.Rows[i]["coluna3"].ToString();
            }
            DateTime fim = DateTime.Now;
        }
        
        public static DateTime GetNetworkTime()
        {
            //Servidor nacional para melhor latência
            const string ntpServer = "a.ntp.br";

            // Tamanho da mensagem NTP - 16 bytes (RFC 2030)
            var ntpData = new byte[48];

            //Indicador de Leap (ver RFC), Versão e Modo
            ntpData[0] = 0x1B; //LI = 0 (sem warnings), VN = 3 (IPv4 apenas), Mode = 3 (modo cliente)

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;

            //123 é a porta padrão do NTP
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            //NTP usa UDP
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            socket.Connect(ipEndPoint);

            //Caso NTP esteja bloqueado, ao menos nao trava o app
            socket.ReceiveTimeout = 3000;

            socket.Send(ntpData);
            socket.Receive(ntpData);
            socket.Close();

            //Offset para chegar no campo "Transmit Timestamp" (que é
            //o do momento da saída do servidor, em formato 64-bit timestamp
            const byte serverReplyTime = 40;

            //Pegando os segundos
            ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

            //e a fração de segundos
            ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

            //Passando de big-endian pra little-endian
            intPart = SwapEndianness(intPart);
            fractPart = SwapEndianness(fractPart);

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

            //Tempo em **UTC**
            var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

            return networkDateTime.ToLocalTime();
        }
        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }

        public static string BuscarArquivo(string titulo, string extensaoPadrao, string filtro, string arquivoPadrao = null)
        {
            var dlg = new OpenFileDialog
            {
                Title = titulo,
                FileName = arquivoPadrao,
                DefaultExt = extensaoPadrao,
                Filter = filtro
            };
            dlg.ShowDialog();
            return dlg.FileName;
        }

        /*


        #region Criar NFe

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

            for (var i = 0; i < 5; i++)
            {
                infNFe.det.Add(GetDetalhe(i, infNFe.emit.CRT, modelo));
            }

            infNFe.total = GetTotal(versao, infNFe.det);

            if (infNFe.ide.mod == ModeloDocumento.NFe & (versao == VersaoServico.Versao310 || versao == VersaoServico.Versao400))
                infNFe.cobr = GetCobranca(infNFe.total.ICMSTot); //V3.00 e 4.00 Somente
            if (infNFe.ide.mod == ModeloDocumento.NFCe || (infNFe.ide.mod == ModeloDocumento.NFe & versao == VersaoServico.Versao400))
                infNFe.pag = GetPagamento(infNFe.total.ICMSTot, versao); //NFCe Somente  

            if (infNFe.ide.mod == ModeloDocumento.NFCe & versao != VersaoServico.Versao400)
                infNFe.infAdic = new infAdic() { infCpl = "Troco: 10,00" }; //Susgestão para impressão do troco em NFCe

            return infNFe;
        }

        protected virtual ide GetIdentificacao(int numero, ModeloDocumento modelo, VersaoServico versao)
        {
            var ide = new ide
            {
                cUF = _configApp.Emitente.Uf,
                natOp = "VENDA",
                mod = modelo,
                serie = 1,
                nNF = numero,
                tpNF = TipoNFe.tnSaida,
                cMunFG = _configuracoes.EnderecoEmitente.cMun,
                tpEmis = _configuracoes.CfgServico.tpEmis,
                tpImp = TipoImpressao.tiRetrato,
                cNF = "1234",
                tpAmb = _configuracoes.CfgServico.tpAmb,
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

            if (versao == VersaoServico.Versao200) return ide;

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
            var emit = _configuracoes.Emitente; // new emit
            //{
            //    //CPF = "12345678912",
            //    CNPJ = "12345678000189",
            //    xNome = "RAZAO SOCIAL LTDA",
            //    xFant = "FANTASIA LTRA",
            //    IE = "123456789",
            //};
            emit.enderEmit = GetEnderecoEmitente();
            return emit;
        }

        protected virtual enderEmit GetEnderecoEmitente()
        {
            var enderEmit = _configuracoes.EnderecoEmitente; // new enderEmit
            //{
            //    xLgr = "RUA TESTE DE ENREREÇO",
            //    nro = "123",
            //    xCpl = "1 ANDAR",
            //    xBairro = "CENTRO",
            //    cMun = 2802908,
            //    xMun = "ITABAIANA",
            //    UF = "SE",
            //    CEP = 49500000,
            //    fone = 79123456789
            //};
            enderEmit.cPais = 1058;
            enderEmit.xPais = "BRASIL";
            return enderEmit;
        }

        protected virtual dest GetDestinatario(VersaoServico versao, ModeloDocumento modelo)
        {
            var dest = new dest(versao)
            {
                CNPJ = "99999999000191",
                //CPF = "99999999999",
            };
            dest.xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL"; //Obrigatório para NFe e opcional para NFCe
            dest.enderDest = GetEnderecoDestinatario(); //Obrigatório para NFe e opcional para NFCe

            //if (versao == VersaoServico.Versao200)
            //    dest.IE = "ISENTO";
            if (versao == VersaoServico.Versao200) return dest;

            dest.indIEDest = indIEDest.NaoContribuinte; //NFCe: Tem que ser não contribuinte V3.00 Somente
            dest.email = "teste@gmail.com"; //V3.00 Somente
            return dest;
        }

        protected virtual enderDest GetEnderecoDestinatario()
        {
            var enderDest = new enderDest
            {
                xLgr = "RUA ...",
                nro = "S/N",
                xBairro = "CENTRO",
                cMun = 2802908,
                xMun = "ITABAIANA",
                UF = "SE",
                CEP = "49500000",
                cPais = 1058,
                xPais = "BRASIL"
            };
            return enderDest;
        }

        protected virtual det GetDetalhe(int i, CRT crt, ModeloDocumento modelo)
        {
            var det = new det
            {
                nItem = i + 1,
                prod = GetProduto(i + 1),
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

        protected virtual prod GetProduto(int i)
        {
            var p = new prod
            {
                cProd = i.ToString().PadLeft(5, '0'),
                cEAN = "7770000000012",
                xProd = i == 1 ? "NOTA FISCAL EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL" : "ABRACADEIRA NYLON 6.6 BRANCA 91X92 " + i,
                NCM = "84159090",
                CFOP = 5102,
                uCom = "UNID",
                qCom = 1,
                vUnCom = 1.1m,
                vProd = 1.1m,
                vDesc = 0.10m,
                cEANTrib = "7770000000012",
                uTrib = "UNID",
                qTrib = 1,
                vUnTrib = 1.1m,
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

        protected virtual ICMSBasico ObterIcmsBasico(CRT crt)
        {
            //Leia os dados de seu banco de dados e em seguida alimente o objeto ICMSGeral, como no exemplo abaixo.
            var icmsGeral = new ICMSGeral
            {
                orig = OrigemMercadoria.OmNacional,
                CST = Csticms.Cst00,
                modBC = DeterminacaoBaseIcms.DbiValorOperacao,
                vBC = 1.1m,
                pICMS = 18,
                vICMS = 0.20m,
                motDesICMS = MotivoDesoneracaoIcms.MdiTaxi
            };
            return icmsGeral.ObterICMSBasico(crt);
        }

        private PISBasico ObterPisBasico()
        {
            //Leia os dados de seu banco de dados e em seguida alimente o objeto PISGeral, como no exemplo abaixo.
            var pisGeral = new PISGeral()
            {
                CST = CSTPIS.pis01,
                vBC = 1.1m,
                pPIS = 1.65m,
                vPIS = 0.01m,
                vAliqProd = 0
            };

            return pisGeral.ObterPISBasico();
        }

        private COFINSBasico ObterCofinsBasico()
        {
            //Leia os dados de seu banco de dados e em seguida alimente o objeto COFINSGeral, como no exemplo abaixo.
            var cofinsGeral = new COFINSGeral()
            {
                CST = CSTCOFINS.cofins01,
                vBC = 1.1m,
                pCOFINS = 1.65m,
                vCOFINS = 0.01m,
                vAliqProd = 0
            };

            return cofinsGeral.ObterCOFINSBasico();
        }

        private IPIBasico ObterIPIBasico()
        {
            //Leia os dados de seu banco de dados e em seguida alimente o objeto IPIGeral, como no exemplo abaixo.
            var ipiGeral = new IPIGeral()
            {
                CST = CSTIPI.ipi01,
                vBC = 1.1m,
                pIPI = 5m,
                vIPI = 0.05m
            };

            return ipiGeral.ObterIPIBasico();
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

            // Regra de validação W16-10 que rege sobre o Total da NF
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

        protected virtual vol GetVolume()
        {
            var v = new vol
            {
                esp = "teste de espécie",
                lacres = new List<lacres> { new lacres { nLacre = "123456" } }
            };

            return v;
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

        #endregion*/


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                #region Carrega um XML para a variável

                var arquivoXml = @"C:\Users\Bruno\Desktop\XMLS\Nova pasta\2022\7\35220730600121000135650010000000011000012344-procNfe.xml";

                nfeProc nfeProc;

                try // Tenta carregar NFeProc
                {
                    nfeProc = FuncoesXml.ArquivoXmlParaClasse<nfeProc>(arquivoXml);
                }
                catch (Exception)  // Carrega NFCe sem protocolo
                {
                    NFe.Classes.NFe nfeContingenciaSemProc = FuncoesXml.ArquivoXmlParaClasse<NFe.Classes.NFe>(arquivoXml);
                    nfeProc = new nfeProc() { NFe = nfeContingenciaSemProc };
                }

                if (nfeProc.NFe.infNFe.ide.mod != ModeloDocumento.NFCe)
                    throw new Exception("O XML informado não é um NFCe!");

                #endregion

                #region Abre a visualização do relatório para impressão

                //var danfe = new DanfeFrNfce(proc: nfeProc, configuracaoDanfeNfce: _configApp.ConfiguracaoDanfeNfce, cIdToken: _configApp.ConfiguracaoCsc.CIdToken, csc: _configApp.ConfiguracaoCsc.Csc, arquivoRelatorio: string.Empty);
                //danfe.Visualizar();
                //danfe.Imprimir();
                //danfe.ExibirDesign();
                //danfe.ExportarPdf(@"d:\teste.pdf");

                #endregion

            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                    MessageBox.Show(ex.Message);
            }

        }
    }
}
