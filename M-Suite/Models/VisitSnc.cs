using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VisitSnc
{
    public int SVtId { get; set; }

    public int SVtCuId { get; set; }

    public int SVtSmId { get; set; }

    public int? SVtCcdId { get; set; }

    public DateTime SVtTimeIn { get; set; }

    public DateTime SVtTimeOut { get; set; }

    public string SVtOperation { get; set; } = null!;

    public string? SVtRemarks { get; set; }

    public string? SVtNoSale { get; set; }

    public string? SVtNoCall { get; set; }

    public string? SVtNoScan { get; set; }

    public string SVtVersion { get; set; } = null!;

    public short? SVtSynched { get; set; }

    public string? SVtBatchNb { get; set; }

    public short? SVtIsCreated { get; set; }

    public string? SVtUid { get; set; }

    public string? SVtCuUid { get; set; }
}
