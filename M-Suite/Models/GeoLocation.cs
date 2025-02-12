using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class GeoLocation
{
    public int GlId { get; set; }

    public int? GlCdIdGeo { get; set; }

    public int? GlGlId { get; set; }

    public short GlLevel { get; set; }

    public string GlCode { get; set; } = null!;

    public string GlDescriptionLan1 { get; set; } = null!;

    public string? GlDescriptionLan2 { get; set; }

    public string? GlDescriptionLan3 { get; set; }
}
