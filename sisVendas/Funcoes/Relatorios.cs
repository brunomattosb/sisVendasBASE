using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace sisVendas.Funcoes
{
    public class Relatorios
    {
        static BaseFont fontBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
        public static void gerarRelatorio(string nomeArquivo, string titulo, DataTable dt, float[] largurasColunas)
        {
            
            if(largurasColunas.Length == dt.Columns.Count)
            {
                int totalPaginas = 1;
                int totalLinhas = dt.Rows.Count;
                if (totalLinhas > 24)
                {
                    totalPaginas += (int)Math.Ceiling((totalLinhas - 24) / 29F);
                }

                //definir as bordas
                var pxPorMm = 72 / 25.2f;
                var pdf = new Document(PageSize.A4, 15 * pxPorMm, 15 * pxPorMm, 15 * pxPorMm, 20 * pxPorMm);


                //criar a pasta Rekatorios caso não exista
                string caminhoPasta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Relatorios");
                if (!Directory.Exists(caminhoPasta))
                {
                    Directory.CreateDirectory(caminhoPasta);
                }

                //definir modo de criação e associar o pdf ao arquivo
                var arquivo = new FileStream(Path.Combine(caminhoPasta, nomeArquivo), FileMode.Create);
                var write = PdfWriter.GetInstance(pdf, arquivo);
                write.PageEvent = new EventosDaPagina(totalPaginas);
                pdf.Open();

                //Fonte para titulos
                var fontParagrafo = new iTextSharp.text.Font(fontBase, 32, iTextSharp.text.Font.NORMAL, BaseColor.Black);
                //titulo
                var Titulo = new Paragraph(titulo + "\n\n", fontParagrafo);
                Titulo.Alignment = Element.ALIGN_LEFT;
                Titulo.SpacingAfter = 4;
                pdf.Add(Titulo);

                //adicionar IMAGEM
                Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.AGlogo, System.Drawing.Imaging.ImageFormat.Png);

                iTextSharp.text.Image logo = img;
                float razaoAlturaLargura = logo.Width / logo.Height;
                float alturaLogo = 64;
                float larguraLogo = alturaLogo * razaoAlturaLargura;
                logo.ScaleToFit(larguraLogo, alturaLogo);

                var margemEsquerda = pdf.PageSize.Width - pdf.RightMargin - larguraLogo;
                var margemTopo = pdf.PageSize.Height - pdf.TopMargin - 54;
                logo.SetAbsolutePosition(margemEsquerda, margemTopo);
                write.DirectContent.AddImage(logo, false);


                //adicionando a tabela
                var tabela = new PdfPTable(dt.Columns.Count);

                //float[] largurasColunas = {0.5f,1.5f};
                tabela.SetTotalWidth(largurasColunas);

                tabela.DefaultCell.BorderWidth = 0;
                tabela.WidthPercentage = 100;

                List<String> arrColunas = new List<string>();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    arrColunas.Add(dt.Columns[i].ColumnName);
                    CriarCelulaTexto(tabela, dt.Columns[i].ColumnName, PdfCell.ALIGN_CENTER, true);

                }

                //Adicionar linhas
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for(int j = 0; j < arrColunas.Count; j++)
                        {
                            CriarCelulaTexto(tabela, dt.Rows[i][arrColunas[j]].ToString(), PdfCell.ALIGN_CENTER);
                        }
                        
                    }
                }

                pdf.Add(tabela);

                pdf.Close();
                arquivo.Close();
                //abrir no visualizador padrao
                var caminhoPDF = Path.Combine(caminhoPasta, nomeArquivo);
                if (File.Exists(caminhoPDF))
                {
                    Process.Start(new ProcessStartInfo()
                    {
                        Arguments = $"/c start {caminhoPDF}",
                        FileName = "cmd.exe",
                        CreateNoWindow = true
                    });
                }
            }
            
        }

        static void CriarCelulaTexto(PdfPTable tabela, string texto,
            int alinhamentoHorizontal = PdfPCell.ALIGN_LEFT,
            bool negrito = false, bool italico = false,
            int tamanhoFonte = 12, int alturaCelula = 25)
        {
            int estilo = iTextSharp.text.Font.NORMAL;
            if(negrito && italico)
            {
                estilo = iTextSharp.text.Font.BOLDITALIC;
            }else if (negrito )
            {
                estilo = iTextSharp.text.Font.BOLD;
            }else if (italico)
            {
                estilo = iTextSharp.text.Font.ITALIC;
            }

            var bgColor = iTextSharp.text.BaseColor.White;
            if(tabela.Rows.Count % 2 == 1)
            {
                bgColor = new BaseColor(0.95F, 0.95F, 0.95F);
            }

            var fontCelula = new iTextSharp.text.Font(fontBase, tamanhoFonte,
                estilo, BaseColor.Black);
            var celula = new PdfPCell(new Phrase(texto, fontCelula));
            //float[] larguraColunas = { 0.6f, 2f, 1.5f, 1f, 1f};
            //tabela.SetWidths(larguraColunas);
            celula.HorizontalAlignment = alinhamentoHorizontal;
            celula.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            celula.Border = 0;
            celula.BorderWidthBottom = 1;
            celula.FixedHeight = alturaCelula;
            celula.PaddingBottom = 5;
            celula.BackgroundColor = bgColor;

            tabela.AddCell(celula);
        }
    }

    class EventosDaPagina : PdfPageEventHelper
    {
        private BaseFont fontBaseRodape { get; set; }
        private iTextSharp.text.Font fontRodape { get; set; }

        private PdfContentByte wdc;
        public int totalPaginas { get; set; }

        public EventosDaPagina(int totalPaginas)
        {
            fontBaseRodape = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            fontRodape = new iTextSharp.text.Font(fontBaseRodape, 8f, iTextSharp.text.Font.NORMAL, BaseColor.Black);
            
            this.totalPaginas = totalPaginas;
        }
        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            base.OnOpenDocument(writer, document);
            this.wdc = writer.DirectContent;
        }
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);

            // inserir momento da geracao
            var textoMomentoGeracao = $"Gerado em {DateTime.Now.ToShortDateString()} às " +
                $"{DateTime.Now.ToShortTimeString()}";

            wdc.BeginText();
            wdc.SetFontAndSize(fontRodape.BaseFont, fontRodape.Size);
            wdc.SetTextMatrix(document.LeftMargin,
                document.BottomMargin * 0.75F);
            wdc.ShowText(textoMomentoGeracao);
            wdc.EndText();


            //edicao numero da página
            int paginaAtual = writer.PageNumber;
            var textoPaginacao = $"Página {paginaAtual} de {totalPaginas}";

            float larguraTextoPaginacao = fontBaseRodape.GetWidthPoint(textoPaginacao,
                fontRodape.Size);

            var tamanhoPagina = document.PageSize;
            wdc.BeginText();
            wdc.SetFontAndSize(fontRodape.BaseFont, fontRodape.Size);
            wdc.SetTextMatrix(tamanhoPagina.Width - document.RightMargin - larguraTextoPaginacao,
                document.BottomMargin * 0.75F);
            wdc.ShowText(textoPaginacao);
            wdc.EndText();
        }
    }
}

