using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkTraceAppActivity
{
    public int TaaId { get; set; }

    public DateTime? TaaDatetime { get; set; }

    public int TaaUsId { get; set; }

    public string TaaAction { get; set; } = null!;

    public string? TaaSessionId { get; set; }

    public string? TaaDescription { get; set; }

    public string? TaaClientAddress { get; set; }

    public string? TaaPageId { get; set; }

    public string? TaaUserPageId { get; set; }

    public string? TaaPageNoSession { get; set; }

    public string? TaaPageName { get; set; }

    public string? TaaFullPagePath { get; set; }
}
