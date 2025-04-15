using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class BusinessunitApplisetting
{
    public int BasId { get; set; }

    public int BasAsId { get; set; }

    public int? BasBuId { get; set; }

    public string BasAsValue { get; set; } = null!;

    public virtual AppliSetting BasAs { get; set; } = null!;

    public virtual BusinessUnit? BasBu { get; set; }
}
