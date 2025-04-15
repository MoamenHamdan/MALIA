using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkSectionAccess
{
    public string Access { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string? Reduction { get; set; }

    public string Omit { get; set; } = null!;
}
