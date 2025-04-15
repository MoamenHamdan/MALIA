using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VTransactionDetail
{
    public int TsId { get; set; }

    public DateOnly? TransDate { get; set; }

    public string Lotid { get; set; } = null!;

    public string Itemid { get; set; } = null!;

    public decimal? Unitprice { get; set; }

    public string Warehouse { get; set; } = null!;

    public decimal? Discount { get; set; }

    public decimal ShdQty { get; set; }
}
