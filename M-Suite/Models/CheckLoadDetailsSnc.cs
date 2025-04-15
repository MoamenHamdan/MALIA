using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CheckLoadDetailsSnc
{
    public int SCldId { get; set; }

    public int? SCldPrId { get; set; }

    public int? SCldClId { get; set; }

    public int? SCldPackQtyLod { get; set; }

    public decimal? SCldUnitQtyLod { get; set; }

    public int? SCldPackQtyVld { get; set; }

    public decimal? SCldUnitQtyVld { get; set; }

    public string? SCldLotno { get; set; }

    public DateTime? SCldExpirydate { get; set; }

    public int SCldSmId { get; set; }

    public string SCldVersion { get; set; } = null!;

    public short? SCldSynched { get; set; }
}
