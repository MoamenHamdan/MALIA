using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Printing
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

    public int? RpHeight { get; set; }

    public string? RpWidth { get; set; }

    public int? RpActive { get; set; }

    public string? RpTextAlignment { get; set; }

    public string? RpTextTranslate { get; set; }

    public string? RpFontStyle { get; set; }

    public string? RpFontFamily { get; set; }

    public int? RpPadding { get; set; }

    public string? RpCondition { get; set; }
}
