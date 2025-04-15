using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactiontypeSequence
{
    public int TssId { get; set; }

    public int TssBuId { get; set; }

    public int TssUsId { get; set; }

    public int TssSqId { get; set; }

    public int TssTstId { get; set; }

    public string TssPrefix { get; set; } = null!;

    public short? TssLength { get; set; }

    public short TssOrder { get; set; }

    public int? TssActive { get; set; }

    public virtual Sequence TssSq { get; set; } = null!;

    public virtual Transactiontype1 TssTst { get; set; } = null!;
}
