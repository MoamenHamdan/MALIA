using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Geofence1
{
    public int GfId { get; set; }

    public string GfCode { get; set; } = null!;

    public string GfDescriptionLan1 { get; set; } = null!;

    public string? GfDescriptionLan2 { get; set; }

    public string? GfDescriptionLan3 { get; set; }

    public string? GfColor { get; set; }
}
