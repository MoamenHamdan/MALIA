using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class RouteGeoLocation
{
    public int RtgId { get; set; }

    public int? RtgRtId { get; set; }

    public int? RtgGlId { get; set; }

    public virtual GeoLocation? RtgGl { get; set; }

    public virtual Route? RtgRt { get; set; }
}
