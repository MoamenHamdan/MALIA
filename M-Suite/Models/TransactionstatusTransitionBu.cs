using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionstatusTransitionBu
{
    public int TstbId { get; set; }

    public int? TstbTsstId { get; set; }

    public int? TstbBuId { get; set; }

    public virtual BusinessUnit? TstbBu { get; set; }

    public virtual TransactionstatusTransition? TstbTsst { get; set; }
}
