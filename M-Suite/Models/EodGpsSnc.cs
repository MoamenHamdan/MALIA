using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class EodGpsSnc
{
    public int SEgId { get; set; }

    public int? SEgEodId { get; set; }

    public string? SEgGpsLog { get; set; }

    public string? SEgGpsAtt { get; set; }

    public int? SEgSynched { get; set; }

    public string SEgVersion { get; set; } = null!;

    public string SEgSmId { get; set; } = null!;
}
