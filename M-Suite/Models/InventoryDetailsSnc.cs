using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventoryDetailsSnc
{
    public int SIvdId { get; set; }

    public int SIvdIvId { get; set; }

    public int? SIvdStId { get; set; }

    public int SIvdPrId { get; set; }

    public decimal SIvdProductQty { get; set; }

    public decimal? SIvdProductPackQty { get; set; }

    public int? SIvSmId { get; set; }

    public string SIvdVersion { get; set; } = null!;

    public int SIvdSmId { get; set; }

    public string? SIvdIvUid { get; set; }
}
