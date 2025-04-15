using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VThpctgFamilyVirtual
{
    public int ThcfId { get; set; }

    public int? ThcfThcfId { get; set; }

    public int? ThcfBuId { get; set; }

    public int ThcfLevel { get; set; }

    public string ThcfCode { get; set; } = null!;

    public string ThcfDescriptionLan1 { get; set; } = null!;

    public string ThcfDescriptionLan2 { get; set; } = null!;

    public string ThcfDescriptionLan3 { get; set; } = null!;

    public short? ThcfCalculated { get; set; }
}
