using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpImImportsqlSalesLrqA
{
    public string Type { get; set; } = null!;

    public string Referential { get; set; } = null!;

    public int? Custid { get; set; }

    public int? Salesmanid { get; set; }

    public string? Trxdate { get; set; }

    public string? Trxtime { get; set; }

    public string Warehouse1 { get; set; } = null!;

    public string? Warehouse2 { get; set; }

    public int? Currency { get; set; }

    public int? Discperc { get; set; }

    public int? Discamt { get; set; }

    public string? Remark { get; set; }

    public int Processed { get; set; }

    public int? Invtypeid { get; set; }

    public int? Currate { get; set; }

    public int Cmpseq { get; set; }

    public int? Netamount { get; set; }

    public string? Actdate { get; set; }

    public int? Seqa { get; set; }

    public int? Driver { get; set; }

    public int? Truck { get; set; }

    public int SmId { get; set; }
}
