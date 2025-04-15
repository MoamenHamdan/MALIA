using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Printing1
{
    public int RpId { get; set; }

    public int RpBuId { get; set; }

    public string RpCode { get; set; } = null!;

    public string RpSection { get; set; } = null!;

    public int RpRow { get; set; }

    public string? RpValue { get; set; }

    public string? RpPercentage { get; set; }

    public short RpValIsSelect { get; set; }

    public string? RpFontSettings { get; set; }

    public short RpLtrRtl { get; set; }

    public string? RpPrinter { get; set; }

    public virtual BusinessUnit RpBu { get; set; } = null!;
}
