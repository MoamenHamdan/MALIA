using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemListDetailSnc
{
    public int SItldId { get; set; }

    public int SItldItlId { get; set; }

    public int SItldItId { get; set; }

    public int SItldSmId { get; set; }

    public int? SItldGrouping { get; set; }

    public decimal? SItldUnitQty { get; set; }

    public decimal? SItldPackQty { get; set; }

    public decimal? SItldUnitPrice { get; set; }

    public decimal? SItldPackPrice { get; set; }

    public decimal? SItldDiscountLine { get; set; }

    public string? SItldRemark { get; set; }

    public string? SItldLotNb { get; set; }

    public DateTime? SItldExpiryDate { get; set; }

    public int? SItldSynched { get; set; }

    public string SItldVersion { get; set; } = null!;
}
