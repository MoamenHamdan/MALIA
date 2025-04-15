using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CrossTableId
{
    public string? CtTableName { get; set; }

    public string? CtDevice { get; set; }

    public int? CtOldId { get; set; }

    public int? CtNewId { get; set; }

    public string? CtUniquekey { get; set; }

    public string? CtVersion { get; set; }
}
