using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PlanogramUser
{
    public int PlnuId { get; set; }

    public int PlnuPlnId { get; set; }

    public int PlnuPlnUsId { get; set; }

    public virtual Planogram PlnuPln { get; set; } = null!;

    public virtual User PlnuPlnUs { get; set; } = null!;
}
