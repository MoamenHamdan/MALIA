using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ApprovalrequestdetailInfo
{
    public int ArdiId { get; set; }

    public int ArdiArdId { get; set; }

    public int? ArdiItId { get; set; }

    public int? ArdiItuId { get; set; }

    public decimal? ArdiItOriginalValue { get; set; }

    public decimal? ArdiItModifiedValue { get; set; }

    public virtual ApprovalRequestDetail ArdiArd { get; set; } = null!;
}
