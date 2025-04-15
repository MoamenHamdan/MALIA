using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesAssetSnc
{
    public int SAtId { get; set; }

    public int SAtCdIdAtg { get; set; }

    public int SAtCdIdAts { get; set; }

    public int SAtCdIdAtn { get; set; }

    public int SAtSmId { get; set; }

    public string? SAtBarcode { get; set; }

    public string SAtCode { get; set; } = null!;

    public string SAtDescriptionLan1 { get; set; } = null!;

    public string? SAtDescriptionLan2 { get; set; }

    public string? SAtDescriptionLan3 { get; set; }

    public string SAtVersion { get; set; } = null!;
}
