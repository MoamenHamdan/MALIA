using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpsInventoryheaderGl
{
    public int TihgId { get; set; }

    public int TihgTihId { get; set; }

    public int TihgGlId { get; set; }

    public virtual GeoLocation TihgGl { get; set; } = null!;

    public virtual ThpsInventoryHeader TihgTih { get; set; } = null!;
}
