using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VListpriceItem
{
    public int LpiId { get; set; }

    public int? LpiLpId { get; set; }

    public int? LpiItId { get; set; }

    public int? LpiUomId { get; set; }

    public decimal LpiPrice { get; set; }

    public decimal? LpiDiscount { get; set; }

    public decimal? LpiMaxDiscount { get; set; }
}
