using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventoryDetailsWmsSnc
{
    public int SIndId { get; set; }

    public int? SIndInId { get; set; }

    public int? SIndWhlId { get; set; }

    public string? SIndWhlCode { get; set; }

    public int? SIndPrId { get; set; }

    public string? SIndPrCode { get; set; }

    public string? SIndPrDescription { get; set; }

    public string? SIndPrBarcode { get; set; }

    public short? SIndPrIsSerial { get; set; }

    public decimal? SIndQty { get; set; }

    public decimal? SIndSkuQty { get; set; }

    public decimal? SIndPackQty { get; set; }

    public decimal? SIndFactorSku2pack { get; set; }

    public int? SIndIsCreated { get; set; }

    public int? SIndIsModified { get; set; }

    public int SIndUsIdSync { get; set; }

    public string SIndVersion { get; set; } = null!;

    public string? SIndPrbType { get; set; }
}
