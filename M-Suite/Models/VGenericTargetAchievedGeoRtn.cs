using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VGenericTargetAchievedGeoRtn
{
    public int VgtaId { get; set; }

    public string VgtaCode { get; set; } = null!;

    public string VgtaType { get; set; } = null!;

    public string VgtaSection { get; set; } = null!;

    public string VgtaValuetype { get; set; } = null!;

    public decimal? VgtaJanGeoRtn { get; set; }

    public decimal? VgtaFebGeoRtn { get; set; }

    public decimal? VgtaMarGeoRtn { get; set; }

    public decimal? VgtaAprGeoRtn { get; set; }

    public decimal? VgtaMayGeoRtn { get; set; }

    public decimal? VgtaJunGeoRtn { get; set; }

    public decimal? VgtaJulGeoRtn { get; set; }

    public decimal? VgtaAugGeoRtn { get; set; }

    public decimal? VgtaSepGeoRtn { get; set; }

    public decimal? VgtaOctGeoRtn { get; set; }

    public decimal? VgtaNovGeoRtn { get; set; }

    public decimal? VgtaDecGeoRtn { get; set; }

    public decimal? VgtaTotal { get; set; }

    public int? Value { get; set; }
}
