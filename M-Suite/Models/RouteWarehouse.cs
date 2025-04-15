using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class RouteWarehouse
{
    public int RtwId { get; set; }

    public int RtwRtId { get; set; }

    public int RtwPlId { get; set; }

    public virtual PhysicalLocation RtwPl { get; set; } = null!;

    public virtual Route RtwRt { get; set; } = null!;
}
