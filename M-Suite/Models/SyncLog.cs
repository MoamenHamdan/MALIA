using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SyncLog
{
    public int SylId { get; set; }

    public int? SylUsId { get; set; }

    public string? SylSyncVersion { get; set; }

    public int? SylResult { get; set; }

    public DateTime? TsyDatetime { get; set; }
}
