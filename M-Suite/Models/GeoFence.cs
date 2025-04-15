using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class GeoFence
{
    public int GfId { get; set; }

    public int? GfGlId { get; set; }

    public string? GfCode { get; set; }

    public string? GfDescription { get; set; }

    public string? GfDescriptionLan2 { get; set; }

    public string? GfDescriptionLan3 { get; set; }

    public short? GfActive { get; set; }

    public virtual ICollection<GeoFenceDetail> GeoFenceDetails { get; set; } = new List<GeoFenceDetail>();

    public virtual GeoLocation? GfGl { get; set; }
}
