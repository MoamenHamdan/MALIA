using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VWarehouseProductNolot
{
    public int WpId { get; set; }

    public int WpUomId { get; set; }

    public int WpPrId { get; set; }

    public int WpWhId { get; set; }

    public decimal? WpQuantity { get; set; }
}
