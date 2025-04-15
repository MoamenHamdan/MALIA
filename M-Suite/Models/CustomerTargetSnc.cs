using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CustomerTargetSnc
{
    public int SCugId { get; set; }

    public int? SCugCuId { get; set; }

    public string? SCugYmValue { get; set; }

    public decimal? SCugYmTargetV { get; set; }

    public decimal? SCugYmTargetR { get; set; }

    public int? SCugYtdValue { get; set; }

    public decimal? SCugYtdTargetV { get; set; }

    public decimal? SCugYtdTargetR { get; set; }

    public string SCugVersion { get; set; } = null!;

    public string SCugSmId { get; set; } = null!;
}
