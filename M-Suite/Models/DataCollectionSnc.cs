using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class DataCollectionSnc
{
    public int SDcId { get; set; }

    public DateTime SDcDate { get; set; }

    public string? SDcRemarks { get; set; }

    public int? SDcCdIdDct { get; set; }

    public int? SDcIdXxid { get; set; }

    public int? SDcVtId { get; set; }

    public int SDcSmId { get; set; }

    public string SDcVersion { get; set; } = null!;
}
