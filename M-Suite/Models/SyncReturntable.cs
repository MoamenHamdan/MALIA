using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SyncReturntable
{
    public int SId { get; set; }

    public int? SOrd { get; set; }

    public int? SScriptType { get; set; }

    public string? SQueryString { get; set; }

    public int SUsId { get; set; }

    public string SVersion { get; set; } = null!;

    public DateTime? SDatetime { get; set; }
}
