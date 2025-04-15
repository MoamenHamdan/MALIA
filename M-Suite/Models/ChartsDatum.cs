using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ChartsDatum
{
    public int ChdId { get; set; }

    public string ChdChartCode { get; set; } = null!;

    public int? ChdSmId { get; set; }

    public string ChdCode { get; set; } = null!;

    public decimal ChdValue { get; set; }

    public string ChdDescription { get; set; } = null!;

    public int? ChdOrder { get; set; }

    public string? ChdGroup { get; set; }

    public DateTime? ChdDate { get; set; }

    public string? ChdText1 { get; set; }

    public string? ChdText2 { get; set; }

    public decimal? ChdNum1 { get; set; }

    public decimal? ChdNum2 { get; set; }

    public DateTime? ChdDate1 { get; set; }

    public DateTime? ChdDate2 { get; set; }
}
