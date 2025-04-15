using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MobilemenusProfile
{
    public int MmpId { get; set; }

    public int MmpPrId { get; set; }

    public int MmpMmId { get; set; }

    public virtual MobileMenu MmpMm { get; set; } = null!;

    public virtual Profile MmpPr { get; set; } = null!;
}
