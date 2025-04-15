using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CurrencyRate
{
    public int CrId { get; set; }

    public DateTime CrDate { get; set; }

    public int CrCdIdCurFrom { get; set; }

    public int CrCdIdCurTo { get; set; }

    public int CrBuId { get; set; }

    public decimal? CrRateBuy { get; set; }

    public decimal? CrRateSell { get; set; }

    public decimal? CrMaxRateBuy { get; set; }

    public decimal? CrMaxRateSell { get; set; }

    public decimal? CrMinRateBuy { get; set; }

    public decimal? CrMinRateSell { get; set; }
}
