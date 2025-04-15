using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PhysicalLocationOdometer
{
    public int PloId { get; set; }

    public int PloPlId { get; set; }

    public int PloBdId { get; set; }

    public DateTime PloDate { get; set; }

    public string? PloOdometer { get; set; }

    public string? PloEndOdometer { get; set; }

    public int? PloVersion { get; set; }

    public virtual BeginDay PloBd { get; set; } = null!;

    public virtual PhysicalLocation PloPl { get; set; } = null!;
}
