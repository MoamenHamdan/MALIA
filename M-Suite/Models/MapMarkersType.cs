using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MapMarkersType
{
    public int MktId { get; set; }

    public string MktCode { get; set; } = null!;

    public string MktDescriptionLan1 { get; set; } = null!;

    public string? MktDescriptionLan2 { get; set; }

    public string? MktDescriptionLan3 { get; set; }

    public string? MktIcon { get; set; }

    public int MktRoot { get; set; }

    public string? MktSourceTable { get; set; }

    public string? MktColumnName { get; set; }
}
