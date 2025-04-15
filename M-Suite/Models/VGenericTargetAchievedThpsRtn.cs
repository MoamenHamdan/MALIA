using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VGenericTargetAchievedThpsRtn
{
    public int VgtaId { get; set; }

    public string VgtaCode { get; set; } = null!;

    public string VgtaType { get; set; } = null!;

    public string VgtaSection { get; set; } = null!;

    public string VgtaValuetype { get; set; } = null!;

    public decimal? VgtaJanThpsRtn { get; set; }

    public decimal? VgtaFebThpsRtn { get; set; }

    public decimal? VgtaMarThpsRtn { get; set; }

    public decimal? VgtaAprThpsRtn { get; set; }

    public decimal? VgtaMayThpsRtn { get; set; }

    public decimal? VgtaJunThpsRtn { get; set; }

    public decimal? VgtaJulThpsRtn { get; set; }

    public decimal? VgtaAugThpsRtn { get; set; }

    public decimal? VgtaSepThpsRtn { get; set; }

    public decimal? VgtaOctThpsRtn { get; set; }

    public decimal? VgtaNovThpsRtn { get; set; }

    public decimal? VgtaDecThpsRtn { get; set; }

    public decimal? VgtaTotal { get; set; }

    public int? Value { get; set; }
}
