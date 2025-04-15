using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VItemPrice
{
    public int? LpiId { get; set; }

    public int? LpiLpId { get; set; }

    public int? LpiItId { get; set; }

    public int? LpiUomId { get; set; }

    public decimal? LpiPrice { get; set; }

    public decimal? LpiDiscount { get; set; }

    public decimal? LpiMaxDiscount { get; set; }

    public int UomId { get; set; }

    public string UomCode { get; set; } = null!;

    public string? UomNameLan1 { get; set; }

    public string? UomNameLan2 { get; set; }

    public string? UomNameLan3 { get; set; }

    public short? UomRoundingPrecision { get; set; }
}
