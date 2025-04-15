using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserQlikInfo
{
    public int UqiId { get; set; }

    public int? UqiUsId { get; set; }

    public string UqiQlikUsername { get; set; } = null!;

    public string UqiQlikAccess { get; set; } = null!;

    public string? UqiQlikReduction { get; set; }

    public string? UqiQlikOmit { get; set; }

    public string? UqiQlikGroup { get; set; }

    public virtual User? UqiUs { get; set; }
}
