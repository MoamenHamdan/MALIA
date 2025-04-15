using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserpaymentstatusTransitionProfile
{
    public int UptpId { get; set; }

    public int UptpUpstId { get; set; }

    public int UptpPrId { get; set; }

    public virtual Profile UptpPr { get; set; } = null!;

    public virtual UserpaymentstatusTransition UptpUpst { get; set; } = null!;
}
