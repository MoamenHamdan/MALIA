using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPromotionPreselection
{
    public long? PpnId { get; set; }

    public string PpnSource { get; set; } = null!;

    public int PpnPndId { get; set; }

    public int PpnPnlId { get; set; }

    public string? PpnDescription { get; set; }

    public string? PpnDescriptionAr { get; set; }

    public decimal? PpnFrom { get; set; }

    public decimal? PpnTo { get; set; }

    public decimal? PpnGet { get; set; }

    public int? PpnStraightBuy { get; set; }

    public int? PpnStraightGet { get; set; }

    public int? PpnLineBuyCount { get; set; }

    public int? PpnSelectGet { get; set; }

    public int? PpnUomIdBuy { get; set; }
}
