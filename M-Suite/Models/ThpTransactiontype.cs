using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpTransactiontype
{
    public int TttId { get; set; }

    public int TttThpId { get; set; }

    public int? TttThpsId { get; set; }

    public int TttBuId { get; set; }

    public int TttTstId { get; set; }

    public virtual BusinessUnit TttBu { get; set; } = null!;

    public virtual Thirdparty TttThp { get; set; } = null!;

    public virtual ThirdpartySite? TttThps { get; set; }

    public virtual Transactiontype1 TttTst { get; set; } = null!;
}
