using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpsInventoryheaderUser
{
    public int TihuId { get; set; }

    public int TihuTihId { get; set; }

    public int TihuUsId { get; set; }

    public virtual ThpsInventoryHeader TihuTih { get; set; } = null!;

    public virtual User TihuUs { get; set; } = null!;
}
