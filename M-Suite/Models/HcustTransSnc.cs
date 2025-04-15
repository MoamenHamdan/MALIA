using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class HcustTransSnc
{
    public int SHctId { get; set; }

    public int? SHctCuId { get; set; }

    public int? SHctPrId { get; set; }

    public DateTime? SHctDate { get; set; }

    public decimal? SHctSoldQty { get; set; }

    public decimal? SHctFreeQty { get; set; }

    public decimal? SHctReturnQty { get; set; }

    public string SHctVersion { get; set; } = null!;

    public string SHctSmId { get; set; } = null!;
}
