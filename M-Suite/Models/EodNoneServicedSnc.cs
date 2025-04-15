using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class EodNoneServicedSnc
{
    public int SEnsId { get; set; }

    public int? SEnsEodId { get; set; }

    public int? SEnsCuId { get; set; }

    public int? SEnsCdIdReason { get; set; }

    public int? SCcId { get; set; }

    public int? SEnsSynched { get; set; }

    public string SEnsVersion { get; set; } = null!;

    public string SEnsSmId { get; set; } = null!;
}
