using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VTransactionItemHistory
{
    public int Pk { get; set; }

    public int TsiTsId { get; set; }

    public int TsiId { get; set; }

    public string ItDescriptionLan1 { get; set; } = null!;

    public string UomCode { get; set; } = null!;

    public decimal? TsiQuantity { get; set; }

    public decimal? TsiPrice { get; set; }

    public decimal? TsiDiscountPercentage { get; set; }
}
