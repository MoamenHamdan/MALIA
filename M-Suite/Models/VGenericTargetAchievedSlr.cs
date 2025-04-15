using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VGenericTargetAchievedSlr
{
    public int VgtaId { get; set; }

    public string VgtaCode { get; set; } = null!;

    public string VgtaType { get; set; } = null!;

    public string VgtaSection { get; set; } = null!;

    public string VgtaValuetype { get; set; } = null!;

    public decimal? VgtaJanSlr { get; set; }

    public decimal? VgtaFebSlr { get; set; }

    public decimal? VgtaMarSlr { get; set; }

    public decimal? VgtaAprSlr { get; set; }

    public decimal? VgtaMaySlr { get; set; }

    public decimal? VgtaJunSlr { get; set; }

    public decimal? VgtaJulSlr { get; set; }

    public decimal? VgtaAugSlr { get; set; }

    public decimal? VgtaSepSlr { get; set; }

    public decimal? VgtaOctSlr { get; set; }

    public decimal? VgtaNovSlr { get; set; }

    public decimal? VgtaDecSlr { get; set; }

    public decimal? VgtaTotal { get; set; }

    public int? Value { get; set; }
}
