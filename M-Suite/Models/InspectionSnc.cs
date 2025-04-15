using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InspectionSnc
{
    public int SInId { get; set; }

    public int SInVtId { get; set; }

    public int? SInSmId { get; set; }

    public int? SInCdIdRemark { get; set; }

    public int? SInCdIdType { get; set; }

    public string? SInRemark { get; set; }

    public string SInVersion { get; set; } = null!;

    public short? SInSynched { get; set; }

    public int? SInIsCreated { get; set; }

    public int? SInSgdId { get; set; }

    public string? SInVtUid { get; set; }

    public string? SInUid { get; set; }
}
