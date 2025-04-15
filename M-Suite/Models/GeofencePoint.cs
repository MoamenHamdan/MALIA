using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class GeofencePoint
{
    public int GfpId { get; set; }

    public int GfpGfId { get; set; }

    public short GfpOrder { get; set; }

    public double GfpLatitude { get; set; }

    public double GfpLongitude { get; set; }

    public virtual Geofence1 GfpGf { get; set; } = null!;
}
