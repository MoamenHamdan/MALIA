using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VTarget
{
    public string TaDescription { get; set; } = null!;

    public int? TsYear { get; set; }

    public int? TsMonth { get; set; }

    public string UsCode { get; set; } = null!;

    public decimal? Achived { get; set; }

    public decimal? Target { get; set; }

    public decimal? Perc { get; set; }
}
