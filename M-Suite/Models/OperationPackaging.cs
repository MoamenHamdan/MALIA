using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class OperationPackaging
{
    public int OppId { get; set; }

    public int? OppOpId { get; set; }

    public int? OppOpbId { get; set; }

    public int OppPckId { get; set; }

    public int OpQuantity { get; set; }

    public virtual Operation? OppOp { get; set; }

    public virtual OperationBatch? OppOpb { get; set; }

    public virtual Package OppPck { get; set; } = null!;
}
