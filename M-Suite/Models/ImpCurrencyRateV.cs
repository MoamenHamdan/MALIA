using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpCurrencyRateV
{
    public DateTime? ICrDate { get; set; }

    public int ICrCdIdCurFrom { get; set; }

    public int ICrCdIdCurTo { get; set; }

    public int ICrBuId { get; set; }

    public decimal? ICrRateBuy { get; set; }

    public decimal? ICrRateSell { get; set; }

    public decimal? ICrMaxRateBuy { get; set; }

    public decimal? ICrMaxRateSell { get; set; }

    public decimal? ICrMinRateBuy { get; set; }

    public decimal? ICrMinRateSell { get; set; }
}
