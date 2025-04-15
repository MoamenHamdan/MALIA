using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PromotionsliceGetDetail
{
    public int PsgdId { get; set; }

    public int PsgdPndId { get; set; }

    public int PsgdUomId { get; set; }

    public int PsgdSlice { get; set; }

    public decimal PsgdGet { get; set; }

    public decimal PsgdGetMax { get; set; }

    public decimal PsgdGetPerc { get; set; }

    public virtual PromotionDetail PsgdPnd { get; set; } = null!;

    public virtual Uom PsgdUom { get; set; } = null!;
}
