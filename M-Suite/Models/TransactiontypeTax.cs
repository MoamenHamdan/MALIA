using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactiontypeTax
{
    public int TstxId { get; set; }

    public int? TstxBuId { get; set; }

    public int TstxTstId { get; set; }

    public int TstxTaxId { get; set; }

    public virtual BusinessUnit? TstxBu { get; set; }

    public virtual Tax TstxTax { get; set; } = null!;

    public virtual Transactiontype1 TstxTst { get; set; } = null!;
}
