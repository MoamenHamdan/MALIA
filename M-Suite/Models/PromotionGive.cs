using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PromotionGive
{
    public int PngId { get; set; }

    public int PngPnId { get; set; }

    public int PngPndId { get; set; }

    public int PngIcfId { get; set; }

    public int PngIcfvId { get; set; }

    public int? PngUomId { get; set; }

    public int PngGroupingNo { get; set; }

    public decimal PngValue { get; set; }

    public decimal PngValueMax { get; set; }

    public decimal? PngValuePerc { get; set; }

    public virtual PromotionMaster PngPn { get; set; } = null!;

    public virtual PromotionDetail PngPnd { get; set; } = null!;

    public virtual Uom? PngUom { get; set; }
}
