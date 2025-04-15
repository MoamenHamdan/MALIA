using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserItemQuotaGroup
{
    public int UiqgId { get; set; }

    public int UiqgUsId { get; set; }

    public int UiqgIqgId { get; set; }

    public virtual ItemQuotaGroup UiqgIqg { get; set; } = null!;

    public virtual User UiqgUs { get; set; } = null!;
}
