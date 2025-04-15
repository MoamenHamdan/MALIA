using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserThpsTransactiontype
{
    public int UtttId { get; set; }

    public int UtttUsId { get; set; }

    public int UtttThpsId { get; set; }

    public int UtttTstId { get; set; }

    public int UtttBuId { get; set; }

    public virtual BusinessUnit UtttBu { get; set; } = null!;

    public virtual Transactiontype1 UtttTst { get; set; } = null!;

    public virtual User UtttUs { get; set; } = null!;
}
