using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpsIvhsTransitionBu
{
    public int TihstbId { get; set; }

    public int TihstbTivhstId { get; set; }

    public int TihstbBuId { get; set; }

    public virtual BusinessUnit TihstbBu { get; set; } = null!;

    public virtual ThpsInventoryheaderstatusTransition TihstbTivhst { get; set; } = null!;
}
