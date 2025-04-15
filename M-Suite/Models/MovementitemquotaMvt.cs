using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementitemquotaMvt
{
    public int MiqmId { get; set; }

    public int? MiqmMiqId { get; set; }

    public int MiqmMvtId { get; set; }

    public int MiqmMssId { get; set; }

    public int MiqmFrom { get; set; }

    public int MiqmTo { get; set; }

    public virtual Movementitemquotum? MiqmMiq { get; set; }

    public virtual Movementstatus MiqmMss { get; set; } = null!;

    public virtual Movementtype1 MiqmMvt { get; set; } = null!;
}
