using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemWarehouseCalculated
{
    public int ItId { get; set; }

    public string ItCode { get; set; } = null!;

    public string ItDescriptionLan1 { get; set; } = null!;

    public decimal ItwQuantity { get; set; }

    public decimal In { get; set; }

    public decimal Sold { get; set; }

    public decimal Out { get; set; }

    public decimal? Correct { get; set; }
}
