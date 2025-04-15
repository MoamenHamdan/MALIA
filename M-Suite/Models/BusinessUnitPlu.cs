using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class BusinessUnitPlu
{
    public int BupId { get; set; }

    public int? BupBuId { get; set; }

    public int? BupCdIdCur { get; set; }

    public virtual BusinessUnit? BupBu { get; set; }
}
