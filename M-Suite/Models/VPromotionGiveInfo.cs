using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPromotionGiveInfo
{
    public long? GPngId { get; set; }

    public int GPngPndId { get; set; }

    public string? GPngSource { get; set; }

    public int? GPngPnlPngId { get; set; }

    public string? GPngGroup { get; set; }

    public string? GPngDescription { get; set; }

    public decimal? GPngGetValue { get; set; }

    public string? GPngAQ { get; set; }

    public string? GPngGetPerTotal { get; set; }

    public int? GPngIsStraightSubGive { get; set; }

    public int? GPngGrouping { get; set; }

    public int? GPngSelectGet { get; set; }
}
