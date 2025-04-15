using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesPromotion
{
    public int SpId { get; set; }

    public int? SpSoId { get; set; }

    public int SpSodId { get; set; }

    public int? SpPnId { get; set; }

    public int? SpPnbId { get; set; }

    public int? SpPngId { get; set; }

    public decimal? SpValue { get; set; }

    public int? SpPrecedence { get; set; }

    public string? SpPrIds { get; set; }

    public int? SpCdIdPtp { get; set; }

    public int? SpBucket { get; set; }

    public decimal? SpValue1 { get; set; }

    public decimal? SpValue2 { get; set; }

    public string SpVersion { get; set; } = null!;
}
