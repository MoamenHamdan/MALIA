using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionitemTax
{
    public int TsixId { get; set; }

    public int TsixTsiId { get; set; }

    public int TsixTaxId { get; set; }

    public int? TsixOrgId { get; set; }

    public decimal? TsixTaxRate { get; set; }

    public decimal? TsixTaxAmount { get; set; }

    public virtual Tax TsixTax { get; set; } = null!;

    public virtual TransactionItem TsixTsi { get; set; } = null!;
}
