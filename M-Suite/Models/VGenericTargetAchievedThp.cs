using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VGenericTargetAchievedThp
{
    public int VgtaId { get; set; }

    public string VgtaCode { get; set; } = null!;

    public string VgtaType { get; set; } = null!;

    public string VgtaSection { get; set; } = null!;

    public string VgtaValuetype { get; set; } = null!;

    public decimal? VgtaJanThps { get; set; }

    public decimal? VgtaFebThps { get; set; }

    public decimal? VgtaMarThps { get; set; }

    public decimal? VgtaAprThps { get; set; }

    public decimal? VgtaMayThps { get; set; }

    public decimal? VgtaJunThps { get; set; }

    public decimal? VgtaJulThps { get; set; }

    public decimal? VgtaAugThps { get; set; }

    public decimal? VgtaSepThps { get; set; }

    public decimal? VgtaOctThps { get; set; }

    public decimal? VgtaNovThps { get; set; }

    public decimal? VgtaDecThps { get; set; }

    public decimal? VgtaTotal { get; set; }

    public int? Value { get; set; }
}
