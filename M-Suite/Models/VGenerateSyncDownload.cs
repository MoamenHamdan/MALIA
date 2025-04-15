using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VGenerateSyncDownload
{
    public string TableName { get; set; } = null!;

    public int? OrdinalPosition { get; set; }

    public string? C { get; set; }
}
