

using NFe.Utils;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System;
using sisVendas.Models;
using NFe.Danfe.Base;
using NFe.Danfe.Base.NFCe;
using NFe.Classes.Informacoes.Emitente;

namespace sisVendas
{
    public class ConfiguracaoApp
    {
        private static string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "configApp.xml");
        private static string dir_imagem_logo;
        private static bool emitirNFCe;
        private static ConfiguracaoServico _cfgServico = new ConfiguracaoServico();
        private static emit emitente = new emit { CPF = "", CRT = CRT.SimplesNacional };
        private static enderEmit enderecoEmitente = new enderEmit();
        private static ConfiguracaoCsc configuracaoCsc = new ConfiguracaoCsc("000001", "");
        private static ConfiguracaoDanfeNfce configuracaoDanfeNfce = new ConfiguracaoDanfeNfce(NfceDetalheVendaNormal.UmaLinha, NfceDetalheVendaContigencia.UmaLinha);
        private static ConfigImpressoraCodBarras impressoraCodBarras= new ConfigImpressoraCodBarras();
        //private static ConfiguracaoEmail configuracaoEmail = new ConfiguracaoEmail("email@dominio.com", "senha", "Envio de NFE", Resources.MensagemHtml, "smtp.dominio.com", 587, true, true);


        public string Dir_imagem_logo { get => dir_imagem_logo; set => dir_imagem_logo = value; }
        public ConfiguracaoServico CfgServico { get => _cfgServico; set => _cfgServico = value; }
        public emit Emitente { get => emitente; set => emitente = value; }
        public enderEmit EnderecoEmitente { get => enderecoEmitente; set => enderecoEmitente = value; }
        public ConfiguracaoCsc ConfiguracaoCsc { get => configuracaoCsc; set => configuracaoCsc = value; }
        public ConfiguracaoDanfeNfce ConfiguracaoDanfeNfce { get => configuracaoDanfeNfce; set => configuracaoDanfeNfce = value; }
        public bool EmitirNFCe { get => emitirNFCe; set => emitirNFCe = value; }
        public ConfigImpressoraCodBarras ImpressoraCodBarras { get => impressoraCodBarras; set => impressoraCodBarras = value; }

        public ConfiguracaoApp()
        {}

        public void lerXml()
        {

            if (File.Exists(caminho))
            {
                XmlSerializer ser = new XmlSerializer(typeof(ConfiguracaoApp));
                TextReader textReader = (TextReader)new StreamReader(caminho);
                XmlTextReader reader = new XmlTextReader(textReader);

                try
                {
                    reader.Read();

                    ConfiguracaoApp xml = (ConfiguracaoApp)ser.Deserialize(reader);
                }
                finally
                {

                    reader.Close();
                }
            }
        }
    }

}



