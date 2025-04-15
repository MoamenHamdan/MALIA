using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ApprovalrequestdetailInfoSnc
{
    public int SArdiId { get; set; }

    public int SArdiArdId { get; set; }

    public int? SArdiItId { get; set; }

    public int? SArdiItuId { get; set; }

    public decimal? SArdiItOriginalValue { get; set; }

    public decimal? SArdiItModifiedValue { get; set; }

    public int SArdiSmId { get; set; }

    public string SArdiVersion { get; set; } = null!;
}
