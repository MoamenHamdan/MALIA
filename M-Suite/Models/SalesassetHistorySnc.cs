using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesassetHistorySnc
{
    public int SAthId { get; set; }

    public int SAthAtId { get; set; }

    public int SAthThpsId { get; set; }

    public int? SAthSmId { get; set; }

    public int SAthVersion { get; set; }

    public DateTime SAthDatetime { get; set; }
}
