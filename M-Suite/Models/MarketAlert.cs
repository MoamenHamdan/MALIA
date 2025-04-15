using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MarketAlert
{
    public int MaId { get; set; }

    public int? MaOrgId { get; set; }

    public int MaSmId { get; set; }

    public int MaVtId { get; set; }

    public string? MaRemarks { get; set; }

    public string? MaText1 { get; set; }

    public string? MaText2 { get; set; }

    public string? MaText3 { get; set; }

    public string? MaUid { get; set; }
}
