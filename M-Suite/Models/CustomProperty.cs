using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CustomProperty
{
    public int CprId { get; set; }

    public int? CprCdIdPrt { get; set; }

    public int? CprBuId { get; set; }

    public int? CprCdIdMod { get; set; }

    public int? CprCdIdPvt { get; set; }

    public string? CprCode { get; set; }
}
