using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemListDetail
{
    public int ItldId { get; set; }

    public int ItldItlId { get; set; }

    public int ItldItId { get; set; }

    public int? ItldGrouping { get; set; }

    public decimal? ItldUnitQty { get; set; }

    public decimal? ItldPackQty { get; set; }

    public decimal? ItldUnitPrice { get; set; }

    public decimal? ItldPackPrice { get; set; }

    public decimal? ItldDiscountLine { get; set; }

    public string? ItldRemark { get; set; }

    public string? ItldLotNb { get; set; }

    public DateTime? ItldExpiryDate { get; set; }
}
