using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartyItem
{
    public int ThpiId { get; set; }

    public int ThpiItId { get; set; }

    public int? ThpiThpsId { get; set; }

    public string ThpiCode { get; set; } = null!;

    public string ThpiDescriptionLan1 { get; set; } = null!;

    public string? ThpiDescriptionLan2 { get; set; }

    public string? ThpiDescriptionLan3 { get; set; }

    public virtual Item ThpiIt { get; set; } = null!;

    public virtual ThirdpartySite? ThpiThps { get; set; }
}
