using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VThpctgFamilyValuesVirtual
{
    public int? ThcfvId { get; set; }

    public int? ThcfvThcfId { get; set; }

    public string ThcfvCode { get; set; } = null!;

    public string? ThcfvDescriptionLan1 { get; set; }

    public string? ThcfvDescriptionLan2 { get; set; }

    public string? ThcfvDescriptionLan3 { get; set; }

    public string ThcfvThcfCode { get; set; } = null!;

    public string ThcfvThcfDescriptionLan1 { get; set; } = null!;

    public string ThcfvThcfDescriptionLan2 { get; set; } = null!;

    public string ThcfvThcfDescriptionLan3 { get; set; } = null!;
}
