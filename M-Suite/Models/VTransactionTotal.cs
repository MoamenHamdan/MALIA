using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VTransactionTotal
{
    public int CTsId { get; set; }

    public decimal? CTsTotalDiscount { get; set; }

    public decimal? CTsTotalTax { get; set; }

    public decimal? CTsTotal { get; set; }
}
