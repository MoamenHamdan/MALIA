using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpImImportsqlSalesBV
{
    public string Type { get; set; } = null!;

    public string Ref { get; set; } = null!;

    public string? Warehouse { get; set; }

    public string Item { get; set; } = null!;

    public string Barcode { get; set; } = null!;

    public string? Extradesc { get; set; }

    public decimal? Uprice { get; set; }

    public decimal? Udiscperc { get; set; }

    public decimal? Vatamt { get; set; }

    public string Unit { get; set; } = null!;

    public decimal Quantity { get; set; }

    public decimal Freeqty { get; set; }

    public int? Processed { get; set; }

    public int SmId { get; set; }

    public string CmpSeq { get; set; } = null!;

    public int TsId { get; set; }
}
