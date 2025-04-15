using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class BeginDaySnc
{
    public int SBdId { get; set; }

    public int SBdSmId { get; set; }

    public DateTime SBdDate { get; set; }

    public string? SBdOdometer { get; set; }

    public string? SBdGpsLatitude { get; set; }

    public string? SBdGpsLongitude { get; set; }

    public string? SBdNotes { get; set; }

    public short? SBdSynched { get; set; }

    public string SBdVersion { get; set; } = null!;

    public string? SBdEndOdometer { get; set; }

    public string? SBdEndGpsLatitude { get; set; }

    public string? SBdEndGpsLongitude { get; set; }
}
