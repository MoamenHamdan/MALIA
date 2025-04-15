using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ListpriceItemException
{
    public int LpixId { get; set; }

    public int LpixLpiId { get; set; }

    public DateTime LpixStartDate { get; set; }

    public DateTime LpixEndDate { get; set; }

    public decimal? LpixPrice { get; set; }

    public decimal? LpixDiscount { get; set; }

    public decimal? LpixMaxDiscount { get; set; }

    public virtual ListpriceItem LpixLpi { get; set; } = null!;
}
