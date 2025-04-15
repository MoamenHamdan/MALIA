using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ReleaseVersion
{
    public int NrId { get; set; }

    public string NrVersionText { get; set; } = null!;

    public string NrVersionValue { get; set; } = null!;

    public string NrVersionSize { get; set; } = null!;

    public string NrVersionPatchLevel { get; set; } = null!;

    public string? NrVersionDetails { get; set; }

    public string NrLocalPath { get; set; } = null!;

    public string NrPublicPath { get; set; } = null!;

    public string NrLocalIp { get; set; } = null!;

    public string NrPublicIp { get; set; } = null!;

    public int NrActive { get; set; }

    public DateTime NrCreationDate { get; set; }
}
