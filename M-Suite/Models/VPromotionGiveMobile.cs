using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPromotionGiveMobile
{
    public int PngId { get; set; }

    public int PngBeId { get; set; }

    public int PngPnId { get; set; }

    public int PngPndId { get; set; }

    public int? PngUomId { get; set; }

    public int PngPcfId { get; set; }

    public int? PngPkId { get; set; }

    public int? PngPcfRefId { get; set; }

    public int PngGroupingNo { get; set; }

    public string? PngValue { get; set; }

    public string? PngValueMax { get; set; }

    public string? PngCodePcf { get; set; }

    public string? PngValuePerc { get; set; }
}
