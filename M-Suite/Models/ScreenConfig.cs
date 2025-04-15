using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ScreenConfig
{
    public int SccId { get; set; }

    public string SccScreenCode { get; set; } = null!;

    public string SccField { get; set; } = null!;

    public string? SccFieldType { get; set; }

    public int SccVisibility { get; set; }

    public int? SccUsId { get; set; }
}
