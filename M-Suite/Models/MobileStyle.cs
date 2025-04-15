using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MobileStyle
{
    public int MsId { get; set; }

    public int MsFkId { get; set; }

    public string MsFkTable { get; set; } = null!;

    public string? MsTextColor { get; set; }

    public string? MsTextStyle { get; set; }

    public string? MsBackgroundColor { get; set; }

    public string? MsBackgroundStyle { get; set; }

    public int? MsTextSize { get; set; }

    public string? MsIcon { get; set; }

    public string? MsIconColor { get; set; }

    public string? MsFontFamily { get; set; }

    public int? MsUsId { get; set; }

    public int? MsHeight { get; set; }

    public int? MsWidth { get; set; }
}
