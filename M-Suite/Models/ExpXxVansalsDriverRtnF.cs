using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpXxVansalsDriverRtnF
{
    public string TrxType { get; set; } = null!;

    public string? TrxDocNumber { get; set; }

    public int ClId { get; set; }

    public string TrxOrgId { get; set; } = null!;

    public string TrxDriverName { get; set; } = null!;

    public string TrxVanNumber { get; set; } = null!;

    public DateTime? BakeryDate { get; set; }

    public string ImportedFlag { get; set; } = null!;

    public int MvId { get; set; }
}
