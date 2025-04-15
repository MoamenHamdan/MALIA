using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TargetDetailspvt
{
    public int TdId { get; set; }

    public int TdTaId { get; set; }

    public int? TdSource { get; set; }

    public int? TdSourceId { get; set; }

    public int? Monthnum { get; set; }

    public string? Columnname { get; set; }

    public decimal? Columnvalue { get; set; }
}
