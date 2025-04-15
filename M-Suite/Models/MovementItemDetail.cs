using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementItemDetail
{
    public int MvidId { get; set; }

    public int? MvidOrgId { get; set; }

    public int MvidMviId { get; set; }

    public int MvidIldId { get; set; }

    public decimal MvidQuantity { get; set; }

    public decimal? MvidQuantity2 { get; set; }

    public virtual MovementItem MvidMvi { get; set; } = null!;
}
