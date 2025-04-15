using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MobileChart1
{
    public int McId { get; set; }

    public string McChartCode { get; set; } = null!;

    public string McLineCode { get; set; } = null!;

    public string McLineDescription { get; set; } = null!;

    public string McChartType { get; set; } = null!;

    public int McHeight { get; set; }

    public int McWidth { get; set; }

    public int McOrder { get; set; }

    public int? McUsId { get; set; }

    public string McQuery { get; set; } = null!;

    public string McValueTextColor { get; set; } = null!;

    public int McValueFontSize { get; set; }

    public string McValueTextStyle { get; set; } = null!;

    public int McXFontSize { get; set; }

    public int McXLabelWidth { get; set; }

    public string McXTextColor { get; set; } = null!;

    public int McYFontSize { get; set; }

    public int McYLabelCount { get; set; }

    public int McYLabelWidth { get; set; }

    public string McYTextColor { get; set; } = null!;

    public int McDescFontSize { get; set; }

    public string McDescTextColor { get; set; } = null!;

    public string McBarColors { get; set; } = null!;

    public string? McChartClass { get; set; }
}
