using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementstatusTransitionProfile
{
    public int MstpId { get; set; }

    public int MstpMsstId { get; set; }

    public int MstpPrId { get; set; }

    public virtual MovementstatusTransition MstpMsst { get; set; } = null!;

    public virtual Profile MstpPr { get; set; } = null!;
}
