using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Observacao
{    
    public class obsCont
    {
        /// <summary>
        ///     VA03 - Identificação do campo
        /// </summary>
        [XmlAttribute]
        public string xCampo { get; set; }

        /// <summary>
        ///     VA04 - Conteúdo do campo
        /// </summary>
        public string xTexto { get; set; }
    }
}
