using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPromotionLineMobile
{
    public int PnlId { get; set; }

    public int PnlPnId { get; set; }

    public int PnlBeId { get; set; }

    public int PnlPndId { get; set; }

    public int PnlUomIdBuy { get; set; }

    public int PnlUomIdGet { get; set; }

    public int PnlPcfId { get; set; }

    public int? PnlPkId { get; set; }

    public int? PnlPcfRefId { get; set; }

    public decimal? PnlFrom { get; set; }

    public decimal? PnlTo { get; set; }

    public decimal PnlGet { get; set; }

    public decimal PnlGetMax { get; set; }

    public string PnlCodePcf { get; set; } = null!;
}
