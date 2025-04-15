using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpsInventoryheaderThp
{
    public int TihtId { get; set; }

    public int? TihtThcfId { get; set; }

    public int? TihtThcfvId { get; set; }

    public int? TihtThpsId { get; set; }

    public int? TihtTihId { get; set; }

    public virtual ThirdpartySite? TihtThps { get; set; }

    public virtual ThpsInventoryHeader? TihtTih { get; set; }
}
