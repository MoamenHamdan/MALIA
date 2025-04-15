using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkSyncLog
{
    public int TsyId { get; set; }

    public int? TsyUsId { get; set; }

    public string? TsySyncVersion { get; set; }

    public string? TsyAction { get; set; }

    public string? TsyDescription { get; set; }

    public int? TsyResult { get; set; }

    public DateTime? TsyDatetime { get; set; }
}
