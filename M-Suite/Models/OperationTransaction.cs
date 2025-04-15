using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class OperationTransaction
{
    public int OptId { get; set; }

    public int? OptWhlIdFrom { get; set; }

    public int? OptWhlIdTo { get; set; }

    public int? OptUsId { get; set; }

    public int? OptItId { get; set; }

    public decimal OptQty { get; set; }

    public string OptOperation { get; set; } = null!;

    public string? OptOperationref1 { get; set; }

    public string? OptOperationref2 { get; set; }

    public DateTime OptDate { get; set; }

    public string? OptSync { get; set; }
}
