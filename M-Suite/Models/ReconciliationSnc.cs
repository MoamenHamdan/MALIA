using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ReconciliationSnc
{
    public int SRcId { get; set; }

    public int SRcSmId { get; set; }

    public DateTime SRcDate { get; set; }

    public string? SRcComment { get; set; }

    public string? SRcSignFilename { get; set; }

    public short? SRcIsCreated { get; set; }

    public short? SRcSynched { get; set; }

    public string SRcVersion { get; set; } = null!;

    public string SRcCode { get; set; } = null!;

    public string? SRcUid { get; set; }

    public int? SRcCdIdRpa { get; set; }
}
