using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkUserAtt
{
    public string Userid { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Value { get; set; }
}
