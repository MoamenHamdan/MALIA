using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartyBillShip
{
    public int ThbsId { get; set; }

    public int ThbsCdIdBst { get; set; }

    public int ThbsThpsId { get; set; }

    public int ThbsThpsIdBst { get; set; }

    public virtual Codesc ThbsCdIdBstNavigation { get; set; } = null!;

    public virtual ThirdpartySite ThbsThps { get; set; } = null!;

    public virtual ThirdpartySite ThbsThpsIdBstNavigation { get; set; } = null!;
}
