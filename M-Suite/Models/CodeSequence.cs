using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CodeSequence
{
    public int CsqId { get; set; }

    public int? CsqBuId { get; set; }

    public string CsqSchema { get; set; } = null!;

    public string CsqTableName { get; set; } = null!;

    public string? CsqPrefix { get; set; }

    public string? CsqPostfix { get; set; }

    public int CsqSequence { get; set; }

    public int CsqLength { get; set; }

    public short CsqActive { get; set; }

    public virtual BusinessUnit? CsqBu { get; set; }
}
