using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ApprovalconfigMember
{
    public int AcmId { get; set; }

    public int AcmAcId { get; set; }

    public int AcmUsId { get; set; }

    public DateTime AcStartDate { get; set; }

    public DateTime AcEndDate { get; set; }

    public virtual ApprovalConfig AcmAc { get; set; } = null!;

    public virtual User AcmUs { get; set; } = null!;
}
