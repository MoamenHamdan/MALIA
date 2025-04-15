using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpsIvhsTransitionProfile
{
    public int TivhtpId { get; set; }

    public int TivhtpTivhstId { get; set; }

    public virtual ThpsInventoryheaderstatusTransition TivhtpTivhst { get; set; } = null!;
}
