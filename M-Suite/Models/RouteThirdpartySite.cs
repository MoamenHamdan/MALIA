using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class RouteThirdpartySite
{
    public int RtsId { get; set; }

    public int? RtsRtId { get; set; }

    public int? RtsThpsId { get; set; }

    public int? RtsOrder { get; set; }

    public virtual Route? RtsRt { get; set; }

    public virtual ThirdpartySite? RtsThps { get; set; }
}
