using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetHistory
{
    public int AthId { get; set; }

    public int AthAtId { get; set; }

    public int AthThpsId { get; set; }

    public int AthVersion { get; set; }

    public DateTime AthDatetime { get; set; }

    public virtual SalesAsset AthAt { get; set; } = null!;

    public virtual ThirdpartySite AthThps { get; set; } = null!;
}
