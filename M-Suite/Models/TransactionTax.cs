using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionTax
{
    public int TsxId { get; set; }

    public int TsxTsId { get; set; }

    public int TsxTaxId { get; set; }

    public int? TsxOrgId { get; set; }

    public decimal? TsxTaxableAmount { get; set; }

    public decimal? TsxTaxValue { get; set; }

    public virtual Tax TsxTax { get; set; } = null!;

    public virtual Transaction TsxTs { get; set; } = null!;
}
