using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VItemMovementsByPack
{
    public string UserCode { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string WarehouseCode { get; set; } = null!;

    public string WarehouseName { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public string ItemDescription { get; set; } = null!;

    public string UomCode { get; set; } = null!;

    public string? UomName { get; set; }

    public decimal? LoadedQuantity { get; set; }

    public decimal? UnloadedQuantity { get; set; }

    public decimal? GrossSoldQuantity { get; set; }

    public decimal? SoldQuantity { get; set; }

    public decimal? ReturnedGoodQuantity { get; set; }

    public decimal? ReturnedBadQuantity { get; set; }

    public decimal? VoidedQuantity { get; set; }

    public decimal? ReturnVoidedQuantity { get; set; }

    public decimal? StockCalculated { get; set; }

    public decimal? CurrentStock { get; set; }

    public int UsId { get; set; }

    public int PlId { get; set; }

    public int ItId { get; set; }

    public int UomId { get; set; }

    public int? ItBuId { get; set; }
}
