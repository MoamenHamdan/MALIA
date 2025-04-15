using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class RouteTransaction
{
    public int RttId { get; set; }

    public int? RttRtId { get; set; }

    public int? RttTsId { get; set; }

    public int? RttOrder { get; set; }

    public short? RttCollected { get; set; }

    public virtual Route? RttRt { get; set; }

    public virtual Transaction? RttTs { get; set; }
}
