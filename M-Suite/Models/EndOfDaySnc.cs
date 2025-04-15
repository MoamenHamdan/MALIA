using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class EndOfDaySnc
{
    public int SEodId { get; set; }

    public int SEodSmId { get; set; }

    public DateTime? SEodDate { get; set; }

    public int? SEodSynched { get; set; }

    public string SEodVersion { get; set; } = null!;
}
