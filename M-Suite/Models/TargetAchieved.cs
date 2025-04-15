using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TargetAchieved
{
    public int? VgtaId { get; set; }

    public string? VgtaCode { get; set; }

    public string? VgtaType { get; set; }

    public string? VgtaSection { get; set; }

    public string? VgtaValuetype { get; set; }

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

    public string? Value { get; set; }
}
