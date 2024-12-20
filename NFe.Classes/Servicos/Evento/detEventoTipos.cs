﻿using System.ComponentModel;
using System.Xml.Serialization;

namespace NFe.Classes.Servicos.Evento
{
    /// <summary>
    ///     Informar "1 - Empresa Emitente" para este evento.
    ///     Nota:
    ///     1 - Empresa Emitente;
    ///     2 - Empresa Destinatária;
    ///     3 - Empresa;
    ///     5 - Fisco;
    ///     6 - RFB;
    ///     9 - Outros Órgãos.
    /// </summary>
    public enum TipoAutor
    {
        /// <summary>
        /// 1 - Empresa Emitente
        /// </summary>
        [Description("Empresa Emitente")]
        [XmlEnum("1")]
        taEmpresaEmitente = 1,

        /// <summary>
        /// 2 - Empresa Destinatária
        /// </summary>
        [Description("Empresa Destinatária")]
        [XmlEnum("2")]
        taEmpresaDestinataria = 2,

        /// <summary>
        /// 3 - Empresa
        /// </summary>
        [Description("Empresa")]
        [XmlEnum("3")]
        taEmpresa = 3,

        /// <summary>
        /// 5 - Fisco
        /// </summary>
        [Description("Fisco")]
        [XmlEnum("5")]
        taFisco = 5,

        /// <summary>
        /// 6 - RFB
        /// </summary>
        [Description("RFB")]
        [XmlEnum("6")]
        taRFB = 6,

        /// <summary>
        /// 9 - Outros Órgãos
        /// </summary>
        [Description("Outros Órgãos")]
        [XmlEnum("9")]
        taOutrosOrgaos = 9
    }
}