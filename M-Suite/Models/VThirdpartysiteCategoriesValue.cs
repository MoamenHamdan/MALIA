using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VThirdpartysiteCategoriesValue
{
    public string ThpsCode { get; set; } = null!;

    public string ThpsNameLan1 { get; set; } = null!;

    public string ThcfCode { get; set; } = null!;

    public string ThcfDescriptionLan1 { get; set; } = null!;

    public string ThcfvCode { get; set; } = null!;

    public string? ThcfvDescriptionLan1 { get; set; }

    public int ThpsId { get; set; }
}
