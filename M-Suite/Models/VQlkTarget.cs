using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkTarget
{
    public int TaId { get; set; }

    public int TaYear { get; set; }

    public DateTime TaCreateDate { get; set; }

    public string TaCode { get; set; } = null!;

    public string TaDescription { get; set; } = null!;

    public int UsId { get; set; }

    public int? BuId { get; set; }

    public int? TaCdIdCur { get; set; }

    public short? TaActive { get; set; }

    public string TrtCode { get; set; } = null!;

    public string? TrtDescriptionLan1 { get; set; }

    public string? TrtDescriptionLan2 { get; set; }

    public string? TrtDescriptionLan3 { get; set; }

    public string TrcCode { get; set; } = null!;

    public string? TrcDescriptionLan1 { get; set; }

    public string? TrcDescriptionLan2 { get; set; }

    public string? TrcDescriptionLan3 { get; set; }

    public string Trs1Code { get; set; } = null!;

    public string? Trs1DescriptionLan1 { get; set; }

    public string? Trs1DescriptionLan2 { get; set; }

    public string? Trs1DescriptionLan3 { get; set; }

    public string Trs2Code { get; set; } = null!;

    public string? Trs2DescriptionLan1 { get; set; }

    public string? Trs2DescriptionLan2 { get; set; }

    public string? Trs2DescriptionLan3 { get; set; }

    public string Trs3Code { get; set; } = null!;

    public string? Trs3DescriptionLan1 { get; set; }

    public string? Trs3DescriptionLan2 { get; set; }

    public string? Trs3DescriptionLan3 { get; set; }
}
