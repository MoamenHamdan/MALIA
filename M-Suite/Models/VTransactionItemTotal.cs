using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VTransactionItemTotal
{
    public int CTsiId { get; set; }

    public int CTsiTsId { get; set; }

    public decimal CTsiQuantity { get; set; }

    public decimal? CTsiPrice { get; set; }

    public decimal? CTsiDiscountPercentage { get; set; }

    public decimal? CTsiDiscountAmount { get; set; }

    public decimal? CTsiTotalDiscount { get; set; }

    public decimal CTsiTotalTax { get; set; }

    public decimal? CTsiTotal { get; set; }
}
