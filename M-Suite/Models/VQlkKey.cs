using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkKey
{
    public int? UsId { get; set; }

    public int? ThpsId { get; set; }

    public int? BuId { get; set; }

    public int? DateNum { get; set; }

    public int? Reduction { get; set; }

    public string? ThpsUs { get; set; }

    public string? ThpsBu { get; set; }

    public string? ThpsUsVt { get; set; }

    public string? ThpsUsVtBu { get; set; }

    public int? TargetKey { get; set; }

    public DateTime? DateValue { get; set; }
}
