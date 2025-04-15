using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpsSuggestedQtyV
{
    public long? TsqId { get; set; }

    public string TsqTstCode { get; set; } = null!;

    public int TsqThpsId { get; set; }

    public decimal? TsqTsiQty { get; set; }

    public decimal TsqStockQty { get; set; }
}
