
using System.ComponentModel;
using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Observacoes
{
    /// <summary>
    ///     Indicador da origem do processo
    ///     <para>0 - SEFAZ;</para>
    ///     <para>1 - Justiça Federal;</para>
    ///     <para>2 - Justiça Estadual;</para>
    ///     <para>3 - Secex/RFB;</para>
    ///     <para>9 - Outros</para>
    /// </summary>
    public enum IndicadorProcesso
    {
        /// <summary>
        /// 0 - SEFAZ
        /// </summary>
        [Description("SEFAZ")]
        [XmlEnum("0")]
        ipSEFAZ = 0,

        /// <summary>
        /// 1 - Justiça Federal
        /// </summary>
        [Description("Justiça Federal")]
        [XmlEnum("1")]
        ipJusticaFederal = 1,

        /// <summary>
        /// 2 - Justiça Estadual
        /// </summary>
        [Description("Justiça Estadual")]
        [XmlEnum("2")]
        ipJusticaEstadual = 2,

        /// <summary>
        /// 3 - Secex/RFB
        /// </summary>
        [Description("Secex/RFB")]
        [XmlEnum("3")]
        ipSecexRFB = 3,

        /// <summary>
        /// 9 - Outros
        /// </summary>
        [Description("Outros")]
        [XmlEnum("9")]
        ipOutros = 9
    }

    /// <summary>
    ///     Para origem do Processo na SEFAZ (indProc=0), informar o tipo de ato concessório
    ///     <para>08 - Termo de Acordo</para>
    ///     <para>10 - Regime Especia</para>
    ///     <para>12 - Autorização específica</para>
    /// </summary>
    public enum TipoAtoConcessorio
    {
        /// <summary>
        /// 08 - Termo de Acordo
        /// </summary>
        [Description("Termo de Acordo")]
        [XmlEnum("08")]
        tpTermoAcordo = 8,

        /// <summary>
        /// 10 - Regime Especial
        /// </summary>
        [Description("Regime Especial")]
        [XmlEnum("10")]
        tpRegimeEspecial= 10,

        /// <summary>
        /// 12 - Autorização Específica
        /// </summary>
        [Description("Autorização Específica")]
        [XmlEnum("12")]
        tpAutorizacaoEspecifica = 12,
    }
}
