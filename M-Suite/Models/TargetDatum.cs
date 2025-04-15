using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TargetDatum
{
    public int TgId { get; set; }

    public int TgUsId { get; set; }

    public int TgFkValue { get; set; }

    public int TgPeriod { get; set; }

    public string TgDimension { get; set; } = null!;

    public string? TgTitleLan1 { get; set; }

    public string? TgTitleLan2 { get; set; }

    public string? TgTitleLan3 { get; set; }

    public string TgDescriptionLan1 { get; set; } = null!;

    public string TgDescriptionLan2 { get; set; } = null!;

    public string TgDescriptionLan3 { get; set; } = null!;

    public decimal? TgTarget { get; set; }

    public decimal TgAchievement { get; set; }
}
