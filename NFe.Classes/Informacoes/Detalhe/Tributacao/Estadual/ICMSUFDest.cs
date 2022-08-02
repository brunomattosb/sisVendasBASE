﻿using System.Xml.Serialization;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual
{
    public class ICMSUFDest
    {
        private decimal _vBcufDest;
        private decimal? _pFcpufDest;
        private decimal _pIcmsufDest;
        private decimal _pIcmsInter;
        private decimal _pIcmsInterPart;
        private decimal? _vFcpufDest;
        private decimal _vIcmsufDest;
        private decimal _vIcmsufRemet;
        private decimal? _vBcfcpufDest;

        /// <summary>
        /// NA03 - Valor da BC do ICMS na UF de destino
        /// </summary>
        [XmlElement(Order = 1)]
        public decimal vBCUFDest
        {
            get { return _vBcufDest; }
            set { _vBcufDest = value.Arredondar(2); }
        }

        /// <summary>
        /// NA04 - Valor da BC FCP na UF de destino
        /// Versão 4.00
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal? vBCFCPUFDest
        {
            get { return _vBcfcpufDest.Arredondar(2); }
            set { _vBcfcpufDest = value.Arredondar(2); }
        }

        public bool vBCFCPUFDestSpecified
        {
            get { return vBCFCPUFDest.HasValue; }
        }

        /// <summary>
        /// NA05 - Percentual do ICMS relativo ao Fundo de Combate à Pobreza (FCP) na UF de destino
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal? pFCPUFDest
        {
            get { return _pFcpufDest; }
            set
            {
                _pFcpufDest = value.Arredondar(4); }
        }

        public bool pFCPUFDestSpecified
        {
            get { return pFCPUFDest.HasValue; }
        }

        /// <summary>
        /// NA07 - Alíquota interna da UF de destino
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal pICMSUFDest
        {
            get { return _pIcmsufDest; }
            set { _pIcmsufDest = value.Arredondar(4); }
        }

        /// <summary>
        /// NA09 - Alíquota interestadual das UF envolvidas
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal pICMSInter
        {
            get { return _pIcmsInter; }
            set { _pIcmsInter = value.Arredondar(2); }
        }

        /// <summary>
        /// NA11 - Percentual provisório de partilha do ICMS Interestadual
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal pICMSInterPart
        {
            get { return _pIcmsInterPart; }
            set { _pIcmsInterPart = value.Arredondar(4); }
        }

        /// <summary>
        /// NA13 - Valor do ICMS relativo ao Fundo de Combate à Pobreza(FCP) da UF de destino
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal? vFCPUFDest
        {
            get { return _vFcpufDest; }
            set { _vFcpufDest = value.Arredondar(2); }
        }

        public bool vFCPUFDestSpecified
        {
            get { return vFCPUFDest.HasValue; }
        }

        /// <summary>
        /// NA15 - Valor do ICMS Interestadual para a UF de destino
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal vICMSUFDest
        {
            get { return _vIcmsufDest; }
            set { _vIcmsufDest = value.Arredondar(2); }
        }

        /// <summary>
        /// NA17 - Valor do ICMS Interestadual para a UF do remetente
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal vICMSUFRemet
        {
            get { return _vIcmsufRemet; }
            set { _vIcmsufRemet = value.Arredondar(2); }
        }
    }
}