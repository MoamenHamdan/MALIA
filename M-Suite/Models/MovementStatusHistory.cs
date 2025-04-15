using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementStatusHistory
{
    public int MvshId { get; set; }

    public int MvshMssId { get; set; }

    public int MvshMvId { get; set; }

    public int MvshUsId { get; set; }

    public DateTime MvshCreateDate { get; set; }

    public string? MvshComments { get; set; }

    public virtual Movementstatus MvshMss { get; set; } = null!;

    public virtual Movement MvshMv { get; set; } = null!;

    public virtual User MvshUs { get; set; } = null!;
}
