using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactiontypeUiGenericpage
{
    public int TsgpId { get; set; }

    public int TsgpTstId { get; set; }

    public int TsgpGpId { get; set; }

    public virtual UiGenericPage TsgpGp { get; set; } = null!;

    public virtual Transactiontype1 TsgpTst { get; set; } = null!;
}
