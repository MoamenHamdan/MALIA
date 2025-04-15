using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TableLock
{
    public int TlId { get; set; }

    public string TlTable { get; set; } = null!;

    public int TlPk { get; set; }

    public string? TlPkSupp { get; set; }

    public string? TlSource { get; set; }

    public string TlUser { get; set; } = null!;

    public string TlSession { get; set; } = null!;

    public DateTime TlDate { get; set; }

    public int? TlBeId { get; set; }

    public int TlActive { get; set; }
}
