using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MobileStoredProcedure
{
    public int MspId { get; set; }

    public int MspMdId { get; set; }

    public string MspName { get; set; } = null!;

    public int MspRow { get; set; }

    public string MspCommand { get; set; } = null!;

    public string? MspComments { get; set; }

    public string? MspAtribute01 { get; set; }

    public string? MspAtribute02 { get; set; }
}
