using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventoryheaderItem
{
    public int IvhiId { get; set; }

    public int IvhiIvhId { get; set; }

    public int IvhiIcfId { get; set; }

    public int IvhiIcfvId { get; set; }

    public virtual InventoryHeader IvhiIvh { get; set; } = null!;
}
