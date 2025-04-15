using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VGenericTargetAchievedItm
{
    public int VgtaId { get; set; }

    public string VgtaCode { get; set; } = null!;

    public string VgtaType { get; set; } = null!;

    public string VgtaSection { get; set; } = null!;

    public string VgtaValuetype { get; set; } = null!;

    public decimal? VgtaJan { get; set; }

    public decimal? VgtaFeb { get; set; }

    public decimal? VgtaMar { get; set; }

    public decimal? VgtaApr { get; set; }

    public decimal? VgtaMay { get; set; }

    public decimal? VgtaJun { get; set; }

    public decimal? VgtaJul { get; set; }

    public decimal? VgtaAug { get; set; }

    public decimal? VgtaSep { get; set; }

    public decimal? VgtaOct { get; set; }

    public decimal? VgtaNov { get; set; }

    public decimal? VgtaDec { get; set; }

    public decimal? VgtaTotal { get; set; }

    public int? Value { get; set; }
}
