using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpmImRetVdrc
{
    public int Trxtype { get; set; }

    public decimal Trxid { get; set; }

    public decimal Linenum { get; set; }

    public string Mop { get; set; } = null!;

    public string Curcode { get; set; } = null!;

    public decimal Amount { get; set; }

    public string? Checkcard { get; set; }

    public string? Maturity { get; set; }

    public string? Bank { get; set; }

    public int? Imported { get; set; }

    public double? Rate { get; set; }

    public double? Ratesl { get; set; }

    public int? Cmpseqc { get; set; }

    public string? VtBatchNo { get; set; }

    public int? IsSent { get; set; }
}
