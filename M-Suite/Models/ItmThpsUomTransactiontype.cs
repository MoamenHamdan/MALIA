using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItmThpsUomTransactiontype
{
    public int IttuId { get; set; }

    public int IttuItId { get; set; }

    public int? IttuQlvId { get; set; }

    public int IttuBuId { get; set; }

    public int IttuUomId { get; set; }

    public int IttuTstId { get; set; }

    public int IttuIndex { get; set; }

    public DateTime? IttuDateFrom { get; set; }

    public DateTime? IttuDateTo { get; set; }

    public virtual BusinessUnit IttuBu { get; set; } = null!;

    public virtual Item IttuIt { get; set; } = null!;

    public virtual Transactiontype1 IttuTst { get; set; } = null!;
}
