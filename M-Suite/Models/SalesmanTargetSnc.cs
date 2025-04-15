using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesmanTargetSnc
{
    public int? SSmgId { get; set; }

    public string? SSmgType { get; set; }

    public int? SSmgSmId { get; set; }

    public string? SSmgYmValue { get; set; }

    public decimal? SSmgYmTargetV { get; set; }

    public decimal? SSmgYmTargetR { get; set; }

    public int? SSmgYtdValue { get; set; }

    public decimal? SSmgYtdTargetV { get; set; }

    public decimal? SSmgYtdTargetR { get; set; }

    public string? SSmgVersion { get; set; }
}
