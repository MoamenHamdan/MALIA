using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventorystatusTransitionProfile
{
    public int IvtpId { get; set; }

    public int IvtpIvstId { get; set; }

    public int IvtpPrId { get; set; }

    public virtual Profile IvtpPr { get; set; } = null!;
}
