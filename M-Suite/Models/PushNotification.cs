using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PushNotification
{
    public int PnId { get; set; }

    public int PnUsId { get; set; }

    public string PnToken { get; set; } = null!;

    public string? PnSubject { get; set; }

    public string? PnDescription { get; set; }

    public string? PnAction { get; set; }

    public string? PnActionParams { get; set; }

    public string? PnIcon { get; set; }

    public int PnStatus { get; set; }

    public string? PnSession { get; set; }
}
