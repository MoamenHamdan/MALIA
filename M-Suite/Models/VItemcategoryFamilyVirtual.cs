using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VItemcategoryFamilyVirtual
{
    public int IcfId { get; set; }

    public int? IcfIcfId { get; set; }

    public int? IcfBuId { get; set; }

    public int IcfLevel { get; set; }

    public string IcfCode { get; set; } = null!;

    public string IcfDescriptionLan1 { get; set; } = null!;

    public string IcfDescriptionLan2 { get; set; } = null!;

    public string IcfDescriptionLan3 { get; set; } = null!;

    public int IcfIsLov { get; set; }

    public string? IcfRegex { get; set; }
}
