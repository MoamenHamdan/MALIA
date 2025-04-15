using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionItemDetail
{
    public int TsidId { get; set; }

    public int? TsidOrgId { get; set; }

    public int TsidTsiId { get; set; }

    public int TsidIldId { get; set; }

    public decimal TsidQuantity { get; set; }

    public decimal? TsidQuantity2 { get; set; }

    public virtual TransactionItem TsidTsi { get; set; } = null!;
}
