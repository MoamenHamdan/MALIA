using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpsIvsTransitionBu
{
    public int TistbId { get; set; }

    public int? TistbTivstId { get; set; }

    public int? TistbBuId { get; set; }

    public virtual BusinessUnit? TistbBu { get; set; }

    public virtual ThpsInventorystatusTransition? TistbTivst { get; set; }
}
