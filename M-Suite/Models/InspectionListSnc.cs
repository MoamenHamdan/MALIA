using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InspectionListSnc
{
    public int SIlId { get; set; }

    public int SIlScId { get; set; }

    public int SIlInId { get; set; }

    public int? SIlCdIdRemark { get; set; }

    public string? SIlRemark { get; set; }

    public short? SIlSynched { get; set; }

    public int? SIlSmId { get; set; }

    public string SIlVersion { get; set; } = null!;

    public int? SIlIsCreated { get; set; }

    public short? SIlScanned { get; set; }

    public string? SIlInUid { get; set; }
}
