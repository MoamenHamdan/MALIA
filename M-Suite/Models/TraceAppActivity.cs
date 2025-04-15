using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TraceAppActivity
{
    public int TaaId { get; set; }

    public DateTime? TaaDatetime { get; set; }

    public int TaaUsId { get; set; }

    public string TaaAction { get; set; } = null!;

    public string? TaaPageId { get; set; }

    public string? TaaSessionId { get; set; }

    public string? TaaDescription { get; set; }

    public string? TaaClientAddress { get; set; }
}
