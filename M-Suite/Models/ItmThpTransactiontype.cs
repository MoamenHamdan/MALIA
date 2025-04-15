using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItmThpTransactiontype
{
    public int ItttId { get; set; }

    public int ItttItId { get; set; }

    public int ItttThpId { get; set; }

    public int? ItttThpsId { get; set; }

    public int ItttBuId { get; set; }

    public int ItttTstId { get; set; }

    public virtual BusinessUnit ItttBu { get; set; } = null!;

    public virtual Item ItttIt { get; set; } = null!;

    public virtual Thirdparty ItttThp { get; set; } = null!;

    public virtual ThirdpartySite? ItttThps { get; set; }

    public virtual Transactiontype1 ItttTst { get; set; } = null!;
}
