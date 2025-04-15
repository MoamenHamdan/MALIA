using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VGenericTargetAchievedSlrRtn
{
    public int VgtaId { get; set; }

    public string VgtaCode { get; set; } = null!;

    public string VgtaType { get; set; } = null!;

    public string VgtaSection { get; set; } = null!;

    public string VgtaValuetype { get; set; } = null!;

    public decimal? VgtaJanSlrRtn { get; set; }

    public decimal? VgtaFebSlrRtn { get; set; }

    public decimal? VgtaMarSlrRtn { get; set; }

    public decimal? VgtaAprSlrRtn { get; set; }

    public decimal? VgtaMaySlrRtn { get; set; }

    public decimal? VgtaJunSlrRtn { get; set; }

    public decimal? VgtaJulSlrRtn { get; set; }

    public decimal? VgtaAugSlrRtn { get; set; }

    public decimal? VgtaSepSlrRtn { get; set; }

    public decimal? VgtaOctSlrRtn { get; set; }

    public decimal? VgtaNovSlrRtn { get; set; }

    public decimal? VgtaDecSlrRtn { get; set; }

    public decimal? VgtaTotal { get; set; }

    public int? Value { get; set; }
}
