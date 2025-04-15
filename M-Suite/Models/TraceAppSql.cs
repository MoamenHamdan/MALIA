using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TraceAppSql
{
    public int TrasId { get; set; }

    public int TrasUsId { get; set; }

    public string TrasObject { get; set; } = null!;

    public string? TrasSession { get; set; }

    public string? TrasAction { get; set; }

    public string? TrasMessage { get; set; }

    public DateTime? TrasDateTime { get; set; }

    public short? TrasStatus { get; set; }
}
