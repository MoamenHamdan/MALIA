using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InventoryLineThirdpartySite
{
    public int IpltId { get; set; }

    public int IpltIvId { get; set; }

    public int IpltThpsId { get; set; }

    public virtual Inventory1 IpltIv { get; set; } = null!;

    public virtual ThirdpartySite IpltThps { get; set; } = null!;
}
