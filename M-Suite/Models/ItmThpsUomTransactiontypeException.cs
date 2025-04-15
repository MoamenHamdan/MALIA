using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItmThpsUomTransactiontypeException
{
    public int IttueId { get; set; }

    public int IttueItId { get; set; }

    public int? IttueThpsId { get; set; }

    public int IttueBuId { get; set; }

    public int IttueUomId { get; set; }

    public int IttueTstId { get; set; }

    public DateTime? IttueDateFrom { get; set; }

    public DateTime? IttueDateTo { get; set; }

    public virtual Item IttueIt { get; set; } = null!;

    public virtual Transactiontype1 IttueTst { get; set; } = null!;
}
