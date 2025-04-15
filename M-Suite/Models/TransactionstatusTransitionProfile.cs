using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionstatusTransitionProfile
{
    public int TstpId { get; set; }

    public int TstpTsstId { get; set; }

    public int? TstpPrId { get; set; }

    public virtual Profile? TstpPr { get; set; }

    public virtual TransactionstatusTransition TstpTsst { get; set; } = null!;
}
