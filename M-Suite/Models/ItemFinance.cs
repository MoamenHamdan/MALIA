using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemFinance
{
    public int ItfId { get; set; }

    public int? ItfItId { get; set; }

    public int ItfBuId { get; set; }

    public int? ItfCdIdTax { get; set; }

    public decimal? ItfDefaultPrice { get; set; }

    public decimal? ItfMaxDiscount { get; set; }

    public virtual BusinessUnit ItfBu { get; set; } = null!;

    public virtual Codesc? ItfCdIdTaxNavigation { get; set; }

    public virtual Item? ItfIt { get; set; }
}
