using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using DFe.Classes.Entidades;
using DFe.Classes.Flags;
using DFe.Utils;
using NFe.Classes.Informacoes.Emitente;
using NFe.Servicos;
using NFe.Utils;
using NFe.Utils.Excecoes;
using sisVendas.Funcoes;

namespace sisVendas.Screens.Create
{
    public partial class FormParameterization : Form
    {
        private string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "configApp.xml");
        private ConfiguracaoApp _configApp = new ConfiguracaoApp();
        
        public FormParameterization()
        {
            InitializeComponent();
            CarregarImpressoras();
        }
        private void CarregarImpressoras()
        {
            foreach (var impressora in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbbImpressora.Items.Add(impressora);
            }
            if (cbbImpressora.Items.Count > 0)
                cbbImpressora.SelectedIndex = 0;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void preencherParametrosNoForm()
        {

            //ImpressoraCODBATTAS
            if(_configApp.ImpressoraCodBarras.NomeImpressora != "")
                cbbImpressora.Text = _configApp.ImpressoraCodBarras.NomeImpressora;
            numericCodBarrasX.Value = _configApp.ImpressoraCodBarras.XCodigo;
            numericCodBarrasY.Value = _configApp.ImpressoraCodBarras.YCodigo;
            numericTextoX.Value = _configApp.ImpressoraCodBarras.XTexto;
            numericTextoY.Value = _configApp.ImpressoraCodBarras.YTexto;
            try
            {
                numericAltura.Value = _configApp.ImpressoraCodBarras.Altura;
            }
            catch{ }
            


            //EMITENTE
            tbRazao.Text= _configApp.Emitente.xNome;
            tbCnpj.Text= _configApp.Emitente.CNPJ;
            tbIE.Text= _configApp.Emitente.IE;
            tbFantasia.Text= _configApp.Emitente.xFant;
            tbTelefone.Text = _configApp. EnderecoEmitente.fone+"";
            tbCep.Text= _configApp.EnderecoEmitente.CEP;
            cbbEstado.Text= _configApp.EnderecoEmitente.UF.ToString();
            tbLogradouro.Text = _configApp.EnderecoEmitente.xLgr;
            tbNumero.Text = _configApp.EnderecoEmitente.nro;
            tbComplemento.Text = _configApp.EnderecoEmitente.xCpl;
            tbBairro.Text = _configApp.EnderecoEmitente.xBairro;
            cbbCrt.Text = _configApp.Emitente.CRT.ToString();
            tbCidade.Text = _configApp.EnderecoEmitente.xMun;
            tbCodigoCidade.Text = _configApp.EnderecoEmitente.cMun.ToString();
            //CERTIFICADO
            tbNumeroDeSerieCertificado.Text = _configApp.CfgServico.Certificado.Serial + "";
            tbArquivoCertificado.Text = _configApp.CfgServico.Certificado.Arquivo;
            tbSenhaCertificado.Text = _configApp.CfgServico.Certificado.Senha;
            cbManterCertificadoNoCache.Checked = _configApp.CfgServico.Certificado.ManterDadosEmCache;
            dtpCertificadoDataVencimento.Value = _configApp.CfgServico.Certificado.Dt_vencimento;

            //GERAL
            tbSchemas.Text = _configApp.CfgServico.DiretorioSchemas;
            cbValidarCertNoCervidor.Checked = _configApp.CfgServico.ValidarCertificadoDoServidor;
            tbDiretorioSalvarXml.Text = _configApp.CfgServico.DiretorioSalvarXml;
            rbSalvarXmlServicos.Checked = _configApp.CfgServico.SalvarXmlServicos;
            //cbEmitirNFCe.Checked = _configApp.CfgServico.;

            tbIdentificadorCsc.Text = _configApp.ConfiguracaoCsc.CIdToken;
            tbCsc.Text = _configApp.ConfiguracaoCsc.Csc;




            if (_configApp.CfgServico.TimeOut != 0)
            tbTimeOut.Text = _configApp.CfgServico.TimeOut.ToString();

            
            if (_configApp.CfgServico.tpAmb.Equals(TipoAmbiente.Producao))
            {
                rbProducao.Checked = true;
                tbHomologacao.Checked = false;
            }
            else
            {

                rbProducao.Checked = false;
                tbHomologacao.Checked = true;
            }
            

            switch (_configApp.CfgServico.Certificado.TipoCertificado)
            {
                case enumTipoCertificado.A1Repositorio:
                    rbA1.Checked = true;
                    break;

                case enumTipoCertificado.A1Arquivo:
                    rbA1EmArquivo.Checked = true;
                    break;

                case enumTipoCertificado.A1ByteArray:
                    rbA1ArrayDeBits.Checked = true;
                    break;

                case enumTipoCertificado.A3:
                    rbA3.Checked = true;
                    break;
            
            }

            if (_configApp.Dir_imagem_logo != null)
            {
                try
                {
                    pictureBox.Image = Image.FromFile(_configApp.Dir_imagem_logo);
                    _configApp.Dir_imagem_logo = _configApp.Dir_imagem_logo;
                }
                catch {}
            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void btnBuscarImg_Click(object sender, EventArgs e)
        {
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _configApp.Dir_imagem_logo = ofd.FileName;
                    pictureBox.Image = Image.FromFile(_configApp.Dir_imagem_logo);
                }
                catch (Exception err)
                {
                    Alerta.notificacao( "Erro!","Arquivo não compativel! - " + err.Message, Alerta.enmType.Error);
                }
                
            }
        }

        private void salvarDados()
        {
            //EMITENTE
            _configApp.Emitente.xNome = tbRazao.Text;
            _configApp.Emitente.CNPJ = tbCnpj.Text;
            _configApp.Emitente.IE = tbIE.Text;
            _configApp.Emitente.xFant = tbFantasia.Text;
            long.TryParse(tbTelefone.Text, out long tel); _configApp.EnderecoEmitente.fone = tel;
            _configApp.EnderecoEmitente.CEP = tbCep.Text;
            _configApp.EnderecoEmitente.UF = (Estado)Enum.Parse(typeof(Estado), cbbEstado.Text);
            _configApp.EnderecoEmitente.xLgr = tbLogradouro.Text;
            _configApp.EnderecoEmitente.nro = tbNumero.Text;
            _configApp.EnderecoEmitente.xCpl = tbComplemento.Text;
            _configApp.EnderecoEmitente.xBairro = tbBairro.Text;
            _configApp.Emitente.CRT = (CRT)Enum.Parse(typeof(CRT), (cbbCrt.SelectedIndex + 1).ToString());
            _configApp.EnderecoEmitente.xMun = tbCidade.Text;
            long.TryParse(tbCodigoCidade.Text, out long codMun); _configApp.EnderecoEmitente.cMun = codMun;


            //CERTIFICADO
            _configApp.CfgServico.Certificado.Serial = tbNumeroDeSerieCertificado.Text;
            _configApp.CfgServico.Certificado.Arquivo = tbArquivoCertificado.Text;
            _configApp.CfgServico.Certificado.Senha = tbSenhaCertificado.Text;
            _configApp.CfgServico.Certificado.ManterDadosEmCache = cbManterCertificadoNoCache.Checked;
            _configApp.CfgServico.Certificado.Dt_vencimento = dtpCertificadoDataVencimento.Value;
            //GERAL
            _configApp.CfgServico.DiretorioSalvarXml = tbDiretorioSalvarXml.Text;
            //_configApp.CfgServico.EmitirNFCe = cbEmitirNFCe.Checked;
            _configApp.ConfiguracaoCsc.CIdToken = tbIdentificadorCsc.Text;
            _configApp.ConfiguracaoCsc.Csc = tbCsc.Text;
            _configApp.CfgServico.SalvarXmlServicos = rbSalvarXmlServicos.Checked;

            //PADRAO
            _configApp.CfgServico.cUF = (Estado)Enum.Parse(typeof(Estado), cbbEstado.Text);
            _configApp.ConfiguracaoDanfeNfce.VersaoQrCode = VersaoQrCode.QrCodeVersao2;
            _configApp.CfgServico.DiretorioSchemas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Schemas.Nfe");
            _configApp.CfgServico.ProtocoloDeSeguranca = System.Net.SecurityProtocolType.Tls12;


            //ImpressoraCODBATTAS
            if (cbbImpressora.Items.Count > 0)
                _configApp.ImpressoraCodBarras.NomeImpressora = cbbImpressora.SelectedItem.ToString();
            _configApp.ImpressoraCodBarras.XCodigo = int.Parse(numericCodBarrasX.Value.ToString());
            _configApp.ImpressoraCodBarras.YCodigo = int.Parse(numericCodBarrasY.Value.ToString());
            _configApp.ImpressoraCodBarras.XTexto = int.Parse(numericTextoX.Value.ToString());
            _configApp.ImpressoraCodBarras.YTexto = int.Parse(numericTextoY.Value.ToString());
            _configApp.ImpressoraCodBarras.Altura = int.Parse(numericAltura.Value.ToString());

            if (rbProducao.Checked)
            {
                _configApp.CfgServico.tpAmb = TipoAmbiente.Producao;
            }
            else
            {

                _configApp.CfgServico.tpAmb = TipoAmbiente.Homologacao;
            }
            _configApp.CfgServico.ValidarCertificadoDoServidor = cbValidarCertNoCervidor.Checked;


            if (int.TryParse(tbTimeOut.Text, out int mms) && mms != 0)
                _configApp.CfgServico.TimeOut = mms;
            else
            {
                _configApp.CfgServico.TimeOut = 3000;
            }

            if (tbSchemas.Text == "")
            {
                _configApp.CfgServico.DiretorioSalvarXml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Schemas.Nfe");
            }
            XmlSerializer ser = new XmlSerializer(typeof(ConfiguracaoApp));
            FileStream file = new FileStream(caminhoArquivo, FileMode.Create);
            try
            {
                ser.Serialize(file, _configApp);

                Alerta.notificacao("Sucesso!", "Parametros salvos com sucesso!", Alerta.enmType.Success);

            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                    Alerta.notificacao("Erro!", string.Format("{0} \n\nDetalhes: {1}", ex.Message, ex.InnerException), Alerta.enmType.Error);
                MessageBox.Show(ex.Message + " - " + ex.InnerException);
            }
            finally
            {
                file.Close();
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvarDados();
        }

        private void btnBuscarCertificado_Click(object sender, EventArgs e)
        {
            try
            {
                var cert = CertificadoDigital.Utils.ListarEObterDoRepositorio();
                _configApp.CfgServico.Certificado.Serial = cert.SerialNumber;
                tbNumeroDeSerieCertificado.Text = cert.SerialNumber;
            }
            catch (Exception ex)
            {
                Alerta.notificacao("Erro!", ex.Message, Alerta.enmType.Error);
            }
        }

        private void rbA1_Click(object sender, EventArgs e)
        {
            _configApp.CfgServico.Certificado.TipoCertificado = enumTipoCertificado.A1Repositorio;
            
        }

        private void rbA1EmArquivo_Click(object sender, EventArgs e)
        {
            _configApp.CfgServico.Certificado.TipoCertificado = enumTipoCertificado.A1Arquivo;
            
        }

        private void rbA1ArrayDeBits_Click(object sender, EventArgs e)
        {
            _configApp.CfgServico.Certificado.TipoCertificado = enumTipoCertificado.A1ByteArray;
            
        }

        private void rbA3_CheckedChanged(object sender, EventArgs e)
        {
            _configApp.CfgServico.Certificado.TipoCertificado = enumTipoCertificado.A3;
            
        }

        private void btnBuscarCertificadoArquivo_Click(object sender, EventArgs e)
        {

            if (_configApp.CfgServico.Certificado.TipoCertificado == enumTipoCertificado.A1ByteArray)
            {
                var caminhoArquivo = Utils.Utils.BuscarArquivo("Selecione o arquivo de Certificado", ".pfx", "Arquivos PFX (*.pfx)|*.pfx|Todos os Arquivos (*.*)|*.*");
                if (!string.IsNullOrWhiteSpace(caminhoArquivo))
                {
                    _configApp.CfgServico.Certificado.ArrayBytesArquivo = File.ReadAllBytes(caminhoArquivo);
                    _configApp.CfgServico.Certificado.Arquivo = null;
                }
                tbArquivoCertificado.Text = caminhoArquivo;
            }
            else if (_configApp.CfgServico.Certificado.TipoCertificado == enumTipoCertificado.A1Arquivo)
            {
                _configApp.CfgServico.Certificado.Arquivo = Utils.Utils.BuscarArquivo("Selecione o arquivo de Certificado", ".pfx", "Arquivos PFX (*.pfx)|*.pfx|Todos os Arquivos (*.*)|*.*");
                tbArquivoCertificado.Text = _configApp.CfgServico.Certificado.Arquivo;
            }
            else
            {
                Alerta.notificacao("Alerta!", string.Format("Para o {0} utilize a busca do número de série!", _configApp.CfgServico.Certificado.TipoCertificado.Descricao()), Alerta.enmType.Warning);

            }
        }

        private void tbCnpj_Click(object sender, EventArgs e)
        {
            if (Function.replaceAll(tbCnpj.Text).Length == 0)
                tbCnpj.Select(0, 0);
        }

        private void rbProducao_Click(object sender, EventArgs e)
        {
            rbProducao.Checked = true;
            tbHomologacao.Checked = false;
        }

        private void tbHomologacao_Click(object sender, EventArgs e)
        {
            rbProducao.Checked = false;
            tbHomologacao.Checked = true;
        }

        private void FormParameterization_Load(object sender, EventArgs e)
        {
            preencherParametrosNoForm();
        }

        private void btnVerificarServiço_Click(object sender, EventArgs e)
        {
            try
            {
                salvarDados();
                btnVerificarServiço.Enabled = false;
                //Exemplo com using para chamar o método Dispose da classe.
                //Usar dessa forma, especialmente, quando for usar certificado A3 com a senha salva.
                // se usar cache você pode por um id no certificado e salvar mais de um certificado digital também na memoria com o zeus
                //_configuracoes.CfgServico.Certificado.CacheId = "1";
                _configApp.CfgServico.ModeloDocumento = ModeloDocumento.NFe;
                if (rbStatusNFCe.Checked)
                {
                    _configApp.CfgServico.ModeloDocumento = ModeloDocumento.NFCe;
                }
                
                using (var servicoNFe = new ServicosNFe(_configApp.CfgServico))
                {
                    var retornoStatus = servicoNFe.NfeStatusServico();

                    if(retornoStatus.Retorno.cStat == 107)
                    {
                        MessageBox.Show(string.Format("Serviço versão {0}\n{1}\n\nAmbiente de: {2}", retornoStatus.Retorno.versao, retornoStatus.Retorno.xMotivo, retornoStatus.Retorno.tpAmb), "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Não foi possivel validar o certificado!\n\nMotivo:  {0}\n\nAmbiente de: {1}",  retornoStatus.Retorno.xMotivo, retornoStatus.Retorno.tpAmb), "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dtpCertificadoDataVencimento.Value = _configApp.CfgServico.Certificado.Dt_vencimento;
                }
            }
            catch (ComunicacaoException ex)
            {
                Alerta.notificacao("Erro de comunicação!", ex.Message, Alerta.enmType.Error);
            }
            catch (ValidacaoSchemaException ex)
            {
                Alerta.notificacao("Erro de validação!", ex.Message, Alerta.enmType.Error);
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                    Alerta.notificacao("Erro!", ex.Message, Alerta.enmType.Error);
            }
            finally
            {
                btnVerificarServiço.Enabled = true;
            }
        }

        private void btnSchemas_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new FolderBrowserDialog();
                dlg.ShowDialog();
                tbSchemas.Text = dlg.SelectedPath;
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                    Alerta.notificacao("Erro!", ex.Message, Alerta.enmType.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new FolderBrowserDialog();
                dlg.ShowDialog();
                tbDiretorioSalvarXml.Text = dlg.SelectedPath;
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                    Alerta.notificacao("Erro!", ex.Message, Alerta.enmType.Error);
            }
        }

        private void tbStatusNFe_Click(object sender, EventArgs e)
        {
            rbStatusNFCe.Checked = false;
            rbStatusNFe.Checked = true;

        }

        private void tbStatusNFCe_Click(object sender, EventArgs e)
        {
            rbStatusNFCe.Checked = true;
            rbStatusNFe.Checked = false;
        }
    }
}
