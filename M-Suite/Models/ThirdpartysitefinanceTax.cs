using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartysitefinanceTax
{
    public int ThpfxId { get; set; }

    public int ThpfxThpfId { get; set; }

    public int ThpfxTaxId { get; set; }

    public virtual Tax ThpfxTax { get; set; } = null!;

    public virtual ThirdpartyFinance ThpfxThpf { get; set; } = null!;
}
