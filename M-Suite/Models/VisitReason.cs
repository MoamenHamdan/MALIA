using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VisitReason
{
    public int VrId { get; set; }

    public int VrVtId { get; set; }

    public int VrFcId { get; set; }

    public int VrCdIdReason { get; set; }

    public DateTime VrDate { get; set; }

    public string? VrComments { get; set; }

    public virtual Codesc VrCdIdReasonNavigation { get; set; } = null!;

    public virtual FamilyCodesc VrFc { get; set; } = null!;

    public virtual Visit VrVt { get; set; } = null!;
}
