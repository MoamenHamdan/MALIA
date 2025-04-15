using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventoryDetail
{
    public int IvdId { get; set; }

    public int IvdIvId { get; set; }

    public int? IvdBuId { get; set; }

    public int? IvdStId { get; set; }

    public int IvdItId { get; set; }

    public int? IvdUomId { get; set; }

    public decimal? IvdQuantity { get; set; }

    public decimal? IvdQuantitySku { get; set; }

    public string IvdStBarcode { get; set; } = null!;

    public int? SIvdSmId { get; set; }
}
