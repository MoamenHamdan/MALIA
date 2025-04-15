using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PromotionLine
{
    public int PnlId { get; set; }

    public int PnlPnId { get; set; }

    public int PnlPndId { get; set; }

    public int? PnlIcfId { get; set; }

    public int? PnlIcfvId { get; set; }

    public int? PnlUomIdBuy { get; set; }

    public int? PnlUomIdGet { get; set; }

    public decimal? PnlFrom { get; set; }

    public decimal? PnlTo { get; set; }

    public decimal PnlGet { get; set; }

    public decimal PnlGetMax { get; set; }

    public decimal? PnlGetPerc { get; set; }

    public decimal PnlForeach { get; set; }

    public int? PnlCdIdPrice { get; set; }

    public int PnlRecurringCount { get; set; }

    public virtual PromotionMaster PnlPn { get; set; } = null!;

    public virtual PromotionDetail PnlPnd { get; set; } = null!;

    public virtual Uom? PnlUomIdBuyNavigation { get; set; }

    public virtual Uom? PnlUomIdGetNavigation { get; set; }
}
