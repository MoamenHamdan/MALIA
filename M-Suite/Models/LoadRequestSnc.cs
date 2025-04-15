using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class LoadRequestSnc
{
    public int SLrId { get; set; }

    public int SLrSmId { get; set; }

    public string? SLrDate { get; set; }

    public string? SLrComment { get; set; }

    public string? SLrSignFilename { get; set; }

    public string? SLrCode { get; set; }

    public short? SLrStatus { get; set; }

    public string SLrVersion { get; set; } = null!;

    public short? SLrSynched { get; set; }

    public short? SLrIsCreated { get; set; }

    public DateTime? SLrMovementDate { get; set; }

    public string? SLrUid { get; set; }
}
