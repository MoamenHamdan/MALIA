using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class DownloadLog
{
    public int DlId { get; set; }

    public int DlUsrId { get; set; }

    public string DlAction { get; set; } = null!;

    public string? DlVersion { get; set; }

    public DateTime DlDatetime { get; set; }
}
