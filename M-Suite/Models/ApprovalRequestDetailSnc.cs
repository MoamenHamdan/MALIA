using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ApprovalRequestDetailSnc
{
    public int SArdId { get; set; }

    public int SArdArId { get; set; }

    public string SArdArUid { get; set; } = null!;

    public int SArdCdIdArtd { get; set; }

    public int SArdSmId { get; set; }

    public string SArdVersion { get; set; } = null!;
}
