using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2BusinessUnit
{
    public int SrbId { get; set; }

    public int SrbSrId { get; set; }

    public int SrbBuId { get; set; }

    public int SrbCdIdSrt { get; set; }

    public virtual BusinessUnit SrbBu { get; set; } = null!;

    public virtual Codesc SrbCdIdSrtNavigation { get; set; } = null!;

    public virtual Survey2 SrbSr { get; set; } = null!;
}
