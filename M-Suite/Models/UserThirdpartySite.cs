using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserThirdpartySite
{
    public int UthpsId { get; set; }

    public int UthpsUsId { get; set; }

    public int? UthpsThpsId { get; set; }

    public int? UthpsCcFrequency { get; set; }

    public string? UthpsAttribute1 { get; set; }

    public virtual ThirdpartySite? UthpsThps { get; set; }

    public virtual User UthpsUs { get; set; } = null!;
}
