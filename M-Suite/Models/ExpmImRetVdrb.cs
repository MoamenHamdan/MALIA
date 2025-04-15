using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpmImRetVdrb
{
    public int Trxtype { get; set; }

    public decimal Trxid { get; set; }

    public string Itemcode { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal Freeqty { get; set; }

    public decimal Price { get; set; }

    public decimal? Discperc { get; set; }

    public decimal? Vat { get; set; }

    public int? Imported { get; set; }

    public string? Reason { get; set; }

    public string? Kitcode { get; set; }

    public string? Descr { get; set; }

    public int? Cmpseqb { get; set; }

    public decimal? Linenum { get; set; }

    public string? VtBatchNo { get; set; }

    public int? IsSent { get; set; }
}
