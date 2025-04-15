using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PlanogramThp
{
    public int PlntId { get; set; }

    public int PlntPlnId { get; set; }

    public int? PlntThpsId { get; set; }

    public int? PlntThcfId { get; set; }

    public int? PlntThcfvId { get; set; }

    public virtual Planogram PlntPln { get; set; } = null!;

    public virtual ThirdpartySite? PlntThps { get; set; }
}
