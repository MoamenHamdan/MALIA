using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementItemHistory
{
    public int MvihId { get; set; }

    public int MvihMvId { get; set; }

    public int MvihMviId { get; set; }

    public int MvihItId { get; set; }

    public decimal MvihRequestedQty { get; set; }

    public decimal? MvihApprovedQty { get; set; }

    public DateTime MvihRequestedDate { get; set; }

    public DateTime? MvihApprovedDate { get; set; }

    public int MvihUsIdCr { get; set; }

    public int? MvihUsIdApp { get; set; }

    public virtual Item MvihIt { get; set; } = null!;

    public virtual Movement MvihMv { get; set; } = null!;

    public virtual MovementItem MvihMvi { get; set; } = null!;

    public virtual User? MvihUsIdAppNavigation { get; set; }

    public virtual User MvihUsIdCrNavigation { get; set; } = null!;
}
