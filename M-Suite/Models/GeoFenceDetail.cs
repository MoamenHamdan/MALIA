using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class GeoFenceDetail
{
    public int GfdId { get; set; }

    public int? GfdGfId { get; set; }

    public short? GfdOrder { get; set; }

    public string? GfdLogitude { get; set; }

    public string? GfdLatitude { get; set; }

    public virtual GeoFence? GfdGf { get; set; }
}
