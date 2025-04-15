using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TraceAppExport
{
    public int TreId { get; set; }

    public int TreUsId { get; set; }

    public DateTime? TreDate { get; set; }

    public string? TreTableName { get; set; }

    public string? TreFilePath { get; set; }

    public int? TreQdId { get; set; }

    public short? TreStatus { get; set; }
}
