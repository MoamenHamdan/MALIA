using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesPromotionSnc
{
    public int SSpId { get; set; }

    public int? SSpSoId { get; set; }

    public int? SSpSodId { get; set; }

    public int? SSpPnId { get; set; }

    public int? SSpPnbId { get; set; }

    public int? SSpPngId { get; set; }

    public int? SSpCdIdPtp { get; set; }

    public decimal? SSpValue { get; set; }

    public int? SSpPrecedence { get; set; }

    public int? SSpBucket { get; set; }

    public string? SSpPrIds { get; set; }

    public string SSpVersion { get; set; } = null!;

    public string SSpSmId { get; set; } = null!;

    public decimal? SSpValue1 { get; set; }

    public decimal? SSpValue2 { get; set; }
}
