using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserMobileProfile
{
    public int UsmpId { get; set; }

    public int UsmpUsId { get; set; }

    public int UsmpMprId { get; set; }

    public virtual MobileProfile UsmpMpr { get; set; } = null!;

    public virtual User UsmpUs { get; set; } = null!;
}
