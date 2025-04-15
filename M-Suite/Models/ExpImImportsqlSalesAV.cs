using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpImImportsqlSalesAV
{
    public string Type { get; set; } = null!;

    public string Ref { get; set; } = null!;

    public string Custid { get; set; } = null!;

    public string? Salesmanid { get; set; }

    public string? Trxdate { get; set; }

    public string? Trxtime { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string? Warehouse1 { get; set; }

    public int? Warehouse2 { get; set; }

    public string Cur { get; set; } = null!;

    public decimal? Discperc { get; set; }

    public int Discamt { get; set; }

    public string Remark { get; set; } = null!;

    public int? Processed { get; set; }

    public decimal TsTotal { get; set; }

    public int SmId { get; set; }

    public string CmpSeq { get; set; } = null!;

    public string? VtVersion { get; set; }

    public int TsId { get; set; }
}
