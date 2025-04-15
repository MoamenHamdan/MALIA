using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPromotionPreselectionOld
{
    public int PpnId { get; set; }

    public string PpnSource { get; set; } = null!;

    public int PpnPndId { get; set; }

    public int PpnPnlId { get; set; }

    public string PpnDescriptionLan1 { get; set; } = null!;

    public string? PpnDescriptionLan2 { get; set; }

    public string? PpnDescriptionLan3 { get; set; }

    public decimal? PpnFrom { get; set; }

    public decimal? PpnTo { get; set; }

    public decimal PpnGet { get; set; }

    public int? PpnStraightBuy { get; set; }

    public int? PpnStraightGet { get; set; }
}
