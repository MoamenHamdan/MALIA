using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MarketAlertDetail
{
    public int MadId { get; set; }

    public int MadMaId { get; set; }

    public int? MadCdIdAlt { get; set; }

    public int? MadCdIdComp { get; set; }

    public string? MadComments { get; set; }

    public string? MadPicture { get; set; }

    public int? MadOrgId { get; set; }

    public string? MadUid { get; set; }
}
