using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPhysicalLocation
{
    public int PlId { get; set; }

    public int? PlPlId { get; set; }

    public int PlCdIdPlt { get; set; }

    public int PlMdId { get; set; }

    public short? PlLevel { get; set; }

    public string PlCode { get; set; } = null!;

    public string PlDescriptionLan1 { get; set; } = null!;

    public string? PlDescriptionLan2 { get; set; }

    public string? PlDescriptionLan3 { get; set; }

    public string PlPltCode { get; set; } = null!;

    public string? PlPltDescriptionLan1 { get; set; }

    public string? PlPltDescriptionLan2 { get; set; }

    public string? PlPltDescriptionLan3 { get; set; }
}
