using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpFmImportsqlschdatum
{
    public int SchCmpSeq { get; set; }

    public decimal SchTrxNo { get; set; }

    public int SchBLineNo { get; set; }

    public DateTime? SchPayDate { get; set; }

    public decimal? SchAmt { get; set; }

    public decimal? SchCollected { get; set; }

    public decimal? SchAmtFirst { get; set; }

    public decimal? SchAmtSecond { get; set; }

    public string? SchSequence { get; set; }

    public int SchSerial { get; set; }

    public int? SchAdvance { get; set; }

    public int? SchSlsCode { get; set; }

    public int? Processed { get; set; }

    public string? VtBatchNo { get; set; }

    public int? SmId { get; set; }

    public int? IsSent { get; set; }

    public int? PaId { get; set; }
}
