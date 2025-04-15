using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ModifierLineElligible
{
    public int MleId { get; set; }

    public int MleMlId { get; set; }

    public int MleElligible { get; set; }

    public int MleGroupingNo { get; set; }

    public int MleGroupNo { get; set; }

    public string? MleHL { get; set; }

    public int? MleMhId { get; set; }

    public string? MleVersion { get; set; }
}
