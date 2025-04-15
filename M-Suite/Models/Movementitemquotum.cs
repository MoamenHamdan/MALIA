using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Movementitemquotum
{
    public int MiqId { get; set; }

    public int MiqMvtId { get; set; }

    public int MiqMssId { get; set; }

    public virtual Movementstatus MiqMss { get; set; } = null!;

    public virtual Movementtype1 MiqMvt { get; set; } = null!;

    public virtual ICollection<MovementitemquotaMvt> MovementitemquotaMvts { get; set; } = new List<MovementitemquotaMvt>();
}
