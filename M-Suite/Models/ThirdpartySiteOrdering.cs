using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartySiteOrdering
{
    public int ThpsoId { get; set; }

    public int? ThpsoThpsId { get; set; }

    public int? ThpsoCdIdMdtp { get; set; }

    public string? ThpsoOrder { get; set; }

    public virtual ThirdpartySite? ThpsoThps { get; set; }
}
