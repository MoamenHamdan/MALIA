using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPromotionToSelectItem
{
    public int PslPndId { get; set; }

    public int? PslPnlId { get; set; }

    public int? PslPngId { get; set; }

    public string PslPnCode { get; set; } = null!;

    public string PslPndCode { get; set; } = null!;

    public string PslPpb { get; set; } = null!;

    public string? PslNature { get; set; }

    public string? PslGroup { get; set; }

    public int? PslIcfId { get; set; }

    public int? PslIcfvId { get; set; }

    public string? PndBuyAmountQuantitySku { get; set; }

    public string? PndBuyAndOr { get; set; }

    public string PslCase { get; set; } = null!;
}
