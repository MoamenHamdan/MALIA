using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventoryCriteriaWmsSnc
{
    public int SPrcId { get; set; }

    public int SPrcInId { get; set; }

    public string SPrcBarcode { get; set; } = null!;

    public int SPrcPrId { get; set; }

    public int SPrcUsIdSync { get; set; }

    public string SPrcVersion { get; set; } = null!;
}
