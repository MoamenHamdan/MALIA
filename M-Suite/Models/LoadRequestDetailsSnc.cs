using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class LoadRequestDetailsSnc
{
    public int SLrdId { get; set; }

    public int SLrdLrId { get; set; }

    public int SLrdPrId { get; set; }

    public int? SLrdPackQtyLod { get; set; }

    public decimal? SLrdUnitQtyLod { get; set; }

    public int? SLrdPackQtyVld { get; set; }

    public decimal? SLrdUnitQtyVld { get; set; }

    public int? SLrdPackQtyRqt { get; set; }

    public decimal? SLrdUnitQtyRqt { get; set; }

    public decimal? SLrdUnitPerPack { get; set; }

    public string SLrdVersion { get; set; } = null!;

    public int SLrdSmId { get; set; }

    public short? SLrdSynched { get; set; }

    public short? SLrdIsCreated { get; set; }

    public string? SLrdLrUid { get; set; }
}
