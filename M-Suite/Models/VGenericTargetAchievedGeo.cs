using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VGenericTargetAchievedGeo
{
    public int VgtaId { get; set; }

    public string VgtaCode { get; set; } = null!;

    public string VgtaType { get; set; } = null!;

    public string VgtaSection { get; set; } = null!;

    public string VgtaValuetype { get; set; } = null!;

    public decimal? VgtaJanGeo { get; set; }

    public decimal? VgtaFebGeo { get; set; }

    public decimal? VgtaMarGeo { get; set; }

    public decimal? VgtaAprGeo { get; set; }

    public decimal? VgtaMayGeo { get; set; }

    public decimal? VgtaJunGeo { get; set; }

    public decimal? VgtaJulGeo { get; set; }

    public decimal? VgtaAugGeo { get; set; }

    public decimal? VgtaSepGeo { get; set; }

    public decimal? VgtaOctGeo { get; set; }

    public decimal? VgtaNovGeo { get; set; }

    public decimal? VgtaDecGeo { get; set; }

    public decimal? VgtaTotal { get; set; }

    public int? Value { get; set; }
}
