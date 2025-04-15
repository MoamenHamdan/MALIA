using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PromotionsliceBuyDetail
{
    public int PsbdId { get; set; }

    public int PsbdPndId { get; set; }

    public int PsbdUomIdBuy { get; set; }

    public int? PsbdUomIdGet { get; set; }

    public int? PsbdSlice { get; set; }

    public decimal PsbdFrom { get; set; }

    public decimal PsbdTo { get; set; }

    public decimal PsbdForeach { get; set; }

    public decimal? PsbdGet { get; set; }

    public decimal? PsbdGetMax { get; set; }

    public decimal? PsbdGetPerc { get; set; }

    public virtual PromotionDetail PsbdPnd { get; set; } = null!;

    public virtual Uom PsbdUomIdBuyNavigation { get; set; } = null!;

    public virtual Uom? PsbdUomIdGetNavigation { get; set; }
}
