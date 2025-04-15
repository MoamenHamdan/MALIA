using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MarketAlertDetailsSnc
{
    public int SMadId { get; set; }

    public int SMadMaId { get; set; }

    public int? SMadCdIdAlt { get; set; }

    public int? SMadCdIdComp { get; set; }

    public string? SMadComments { get; set; }

    public string? SMadPicture { get; set; }

    public int SMadSmId { get; set; }

    public string SMadVersion { get; set; } = null!;

    public string? SMadSynched { get; set; }

    public string? SMadMaUid { get; set; }

    public string? SMadUid { get; set; }
}
