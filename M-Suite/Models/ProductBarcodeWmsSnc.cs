using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ProductBarcodeWmsSnc
{
    public int SPrbId { get; set; }

    public string SPrbBarcode { get; set; } = null!;

    public string? SPrbCode { get; set; }

    public decimal SPrbConversion { get; set; }

    public string? SPrbType { get; set; }

    public int SPrbPrId { get; set; }

    public string? SPrbText1 { get; set; }

    public decimal? SPrbNum1 { get; set; }

    public string? SPrbReftext1 { get; set; }

    public decimal? SPrbRefNum1 { get; set; }

    public string SPrbVersion { get; set; } = null!;

    public short? SPrbIsNew { get; set; }

    public int SPrbUsId { get; set; }
}
