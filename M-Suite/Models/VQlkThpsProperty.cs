using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkThpsProperty
{
    public int ThpscvId { get; set; }

    public int ThpsId { get; set; }

    public string ThcfCode { get; set; } = null!;

    public string ThcfDescriptionLan1 { get; set; } = null!;

    public string ThcfDescriptionLan2 { get; set; } = null!;

    public string ThcfDescriptionLan3 { get; set; } = null!;

    public string? ThcfvCode { get; set; }

    public string? ThcfvDescriptionLan1 { get; set; }

    public string? ThcfvDescriptionLan2 { get; set; }

    public string? ThcfvDescriptionLan3 { get; set; }
}
