using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Listprice
{
    public int LpId { get; set; }

    public int? LpBuId { get; set; }

    public int LpCdIdCur { get; set; }

    public string? LpCode { get; set; }

    public string? LpDescriptionLan1 { get; set; }

    public string? LpDescriptionLan2 { get; set; }

    public string? LpDescriptionLan3 { get; set; }

    public DateOnly LpFromDate { get; set; }

    public DateOnly LpToDate { get; set; }

    public short LpActive { get; set; }

    public int? LpLevel { get; set; }

    public virtual ICollection<ListpriceItem> ListpriceItems { get; set; } = new List<ListpriceItem>();

    public virtual BusinessUnit? LpBu { get; set; }

    public virtual Codesc LpCdIdCurNavigation { get; set; } = null!;

    public virtual ICollection<MovementItem> MovementItems { get; set; } = new List<MovementItem>();

    public virtual ICollection<OperationItem> OperationItems { get; set; } = new List<OperationItem>();

    public virtual ICollection<ThirdpartyFinance> ThirdpartyFinances { get; set; } = new List<ThirdpartyFinance>();

    public virtual ICollection<ThirdpartySiteListpriceRoute> ThirdpartySiteListpriceRoutes { get; set; } = new List<ThirdpartySiteListpriceRoute>();

    public virtual ICollection<TransactionItem> TransactionItems { get; set; } = new List<TransactionItem>();
}
