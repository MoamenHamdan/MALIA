using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TraceDex
{
    public int TdxId { get; set; }

    public int? TdxUsId { get; set; }

    public string? TdxSyncVersion { get; set; }

    public string? TdxAction { get; set; }

    public string? TdxDescription { get; set; }

    public int? TdxResult { get; set; }

    public DateTime? TdxDatetime { get; set; }

    public int? TdxCdIdDxt { get; set; }

    public string? TdxSyncSession { get; set; }
}
