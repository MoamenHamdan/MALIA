using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartyPaymethod
{
    public int ThpmId { get; set; }

    public int? ThpmThpfId { get; set; }

    public int? ThpmCdIdPam { get; set; }

    public virtual Codesc? ThpmCdIdPamNavigation { get; set; }

    public virtual ThirdpartyFinance? ThpmThpf { get; set; }
}
