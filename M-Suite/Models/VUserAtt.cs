using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VUserAtt
{
    public int Userid { get; set; }

    public string Type { get; set; } = null!;

    public string? Value { get; set; }
}
