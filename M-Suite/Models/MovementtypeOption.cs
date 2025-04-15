using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementtypeOption
{
    public int MvtoId { get; set; }

    public int? MvtoMvtId { get; set; }

    public virtual ICollection<MovementItem> MovementItems { get; set; } = new List<MovementItem>();

    public virtual Movementtype2? MvtoMvt { get; set; }
}
