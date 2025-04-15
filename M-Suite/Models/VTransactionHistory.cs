using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VTransactionHistory
{
    public string TsNumber { get; set; } = null!;

    public DateTime TsDate { get; set; }

    public decimal TsTotal { get; set; }

    public string TsCurSymb { get; set; } = null!;

    public string? TsType { get; set; }

    public int TsId { get; set; }

    public int? TsThpsIdBill { get; set; }

    public int? TsThpsIdShip { get; set; }

    public int TstId { get; set; }
}
