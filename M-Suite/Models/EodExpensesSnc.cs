using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class EodExpensesSnc
{
    public int SEeId { get; set; }

    public int? SEeEodId { get; set; }

    public int? SEeCdIdType { get; set; }

    public int? SEeCdIdCurr { get; set; }

    public decimal? SEeAmount { get; set; }

    public int? SEeSynched { get; set; }

    public string SEeVersion { get; set; } = null!;

    public string SEeSmId { get; set; } = null!;
}
