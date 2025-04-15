using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPromotionGiveGroup
{
    public int PnggPndId { get; set; }

    public int PnggGroupingNo { get; set; }

    public string PnggSource { get; set; } = null!;

    public string? PnggGroupDescription { get; set; }
}
