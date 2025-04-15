using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementstatusTransitionBu
{
    public int MstbId { get; set; }

    public int MstbBuId { get; set; }

    public int MstbMsstId { get; set; }

    public virtual BusinessUnit MstbBu { get; set; } = null!;

    public virtual MovementstatusTransition MstbMsst { get; set; } = null!;
}
