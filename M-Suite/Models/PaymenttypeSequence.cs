using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PaymenttypeSequence
{
    public int PysId { get; set; }

    public int PysBuId { get; set; }

    public int PysUsId { get; set; }

    public int PysSqId { get; set; }

    public int PysPyId { get; set; }

    public string PysPrefix { get; set; } = null!;

    public short? PysLength { get; set; }

    public short? PysOrder { get; set; }

    public int? PysActive { get; set; }

    public virtual BusinessUnit PysBu { get; set; } = null!;

    public virtual Paymenttype PysPy { get; set; } = null!;

    public virtual Sequence PysSq { get; set; } = null!;

    public virtual User PysUs { get; set; } = null!;
}
