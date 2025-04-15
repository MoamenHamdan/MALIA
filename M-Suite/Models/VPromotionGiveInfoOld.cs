using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPromotionGiveInfoOld
{
    public int PngxPndId { get; set; }

    public int PngxPnlId { get; set; }

    public string PngxGetFrom { get; set; } = null!;

    public int? PngxStraightGet { get; set; }

    public int PngxSelectGroup { get; set; }
}
