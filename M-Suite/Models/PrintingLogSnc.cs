using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PrintingLogSnc
{
    public int SPlId { get; set; }

    public int SPlSmId { get; set; }

    public string SPlCode { get; set; } = null!;

    public string SPlParams { get; set; } = null!;

    public DateTime SPlDate { get; set; }

    public int SPlStatus { get; set; }

    public string? SPlComments { get; set; }

    public string SPlVersion { get; set; } = null!;
}
