using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class FmImportsqlschdatum
{
    public string SchCmpSeq { get; set; } = null!;

    public string SchTrxNo { get; set; } = null!;

    public int SchBLineNo { get; set; }

    public DateTime SchPayDate { get; set; }

    public decimal SchAmt { get; set; }

    public int SchCollected { get; set; }

    public decimal? SchAmtFirst { get; set; }

    public decimal? SchAmtSecond { get; set; }

    public string? SchSequence { get; set; }

    public int SchAdvance { get; set; }

    public string? SchSlsCode { get; set; }

    public int Processed { get; set; }

    public int VtUsId { get; set; }

    public string? VtVersion { get; set; }

    public int PaId { get; set; }

    public long? SchSerial { get; set; }
}
