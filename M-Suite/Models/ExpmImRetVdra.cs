using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpmImRetVdra
{
    public int Trxtype { get; set; }

    public decimal Trxid { get; set; }

    public string Date { get; set; } = null!;

    public string Time { get; set; } = null!;

    public string Customer { get; set; } = null!;

    public string Salesman { get; set; } = null!;

    public string? Curcode { get; set; }

    public string Outlet { get; set; } = null!;

    public decimal? Shift { get; set; }

    public decimal Packet { get; set; }

    public int? Imported { get; set; }

    public int? Customerid { get; set; }

    public int? Salesmanid { get; set; }

    public int? Invoicetypeid { get; set; }

    public double? Rate { get; set; }

    public double? Ratesl { get; set; }

    public decimal? Netamount { get; set; }

    public int? Reattc { get; set; }

    public int? Cmpseqa { get; set; }

    public string? VtBatchNo { get; set; }

    public int? IsSent { get; set; }

    public decimal? Disc1 { get; set; }

    public string? Remark { get; set; }
}
