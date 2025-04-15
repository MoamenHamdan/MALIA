using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ProductWmsSnc
{
    public int SPrId { get; set; }

    public string SPrCode { get; set; } = null!;

    public string? SPrDescription { get; set; }

    public int? SPrIsSerial { get; set; }

    public string? SPrUsercode { get; set; }

    public short? SPrIsNew { get; set; }

    public string SPrVersion { get; set; } = null!;

    public int SPrUsId { get; set; }

    public int? SPrNum1 { get; set; }

    public decimal? SPrTonality { get; set; }

    public long? SPrRefExport { get; set; }

    public string? SPrRefBarcode { get; set; }

    public string? SPrDescription2 { get; set; }
}
