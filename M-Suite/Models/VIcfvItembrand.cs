using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VIcfvItembrand
{
    public int? IcfvId { get; set; }

    public int? IcfvIcfId { get; set; }

    public string IcfvCode { get; set; } = null!;

    public string? IcfvDescriptionLan1 { get; set; }

    public string? IcfvDescriptionLan2 { get; set; }

    public string? IcfvDescriptionLan3 { get; set; }

    public int? IcfvBuId { get; set; }

    public string IcfvIcfDescriptionLan1 { get; set; } = null!;

    public string IcfvIcfDescriptionLan2 { get; set; } = null!;

    public string IcfvIcfDescriptionLan3 { get; set; } = null!;
}
