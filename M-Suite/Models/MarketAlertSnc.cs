using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MarketAlertSnc
{
    public int SMaId { get; set; }

    public int SMaSmId { get; set; }

    public int SMaVtId { get; set; }

    public string? SMaRemarks { get; set; }

    public string? SMaText1 { get; set; }

    public string? SMaText2 { get; set; }

    public string? SMaText3 { get; set; }

    public string SMaVersion { get; set; } = null!;

    public string? SMaSynched { get; set; }

    public string? SMaVtUid { get; set; }

    public string? SMaUid { get; set; }
}
