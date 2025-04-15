using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartySiteListpriceRoute
{
    public int TslrId { get; set; }

    public int? TslrThpfId { get; set; }

    public int TslrLpId { get; set; }

    public string? TslrRoute { get; set; }

    public int? TslrPlId { get; set; }

    public virtual Listprice TslrLp { get; set; } = null!;

    public virtual PhysicalLocation? TslrPl { get; set; }

    public virtual ThirdpartyFinance? TslrThpf { get; set; }
}
