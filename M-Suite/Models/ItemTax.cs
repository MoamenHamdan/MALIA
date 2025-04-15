using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemTax
{
    public int ItxId { get; set; }

    public int? ItxBuId { get; set; }

    public int ItxItId { get; set; }

    public int ItxTaxId { get; set; }

    public decimal ItxRate { get; set; }

    public virtual BusinessUnit? ItxBu { get; set; }

    public virtual Item ItxIt { get; set; } = null!;

    public virtual Tax ItxTax { get; set; } = null!;
}
