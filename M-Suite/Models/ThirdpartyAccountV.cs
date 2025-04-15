using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartyAccountV
{
    public int AccId { get; set; }

    public int? AccFamilyId { get; set; }

    public string AccCode { get; set; } = null!;

    public string? AccLan1 { get; set; }

    public string? AccLan2 { get; set; }

    public string? AccLan3 { get; set; }
}
