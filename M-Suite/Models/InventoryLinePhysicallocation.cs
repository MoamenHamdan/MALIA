using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventoryLinePhysicallocation
{
    public int IplId { get; set; }

    public int IplIvId { get; set; }

    public int IplPlId { get; set; }

    public virtual Inventory1 IplIv { get; set; } = null!;

    public virtual PhysicalLocation IplPl { get; set; } = null!;
}
