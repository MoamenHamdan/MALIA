using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserTransactiontype
{
    public int UttId { get; set; }

    public int UttUsId { get; set; }

    public int UttTstId { get; set; }

    public int UttBuId { get; set; }

    public int? UttPlId { get; set; }

    public virtual BusinessUnit UttBu { get; set; } = null!;

    public virtual Transactiontype1 UttTst { get; set; } = null!;

    public virtual User UttUs { get; set; } = null!;
}
