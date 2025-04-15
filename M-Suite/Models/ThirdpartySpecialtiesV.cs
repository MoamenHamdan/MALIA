using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartySpecialtiesV
{
    public int SpcId { get; set; }

    public int? SpcFamilyId { get; set; }

    public string SpcCode { get; set; } = null!;

    public string? SpcLan1 { get; set; }

    public string? SpcLan2 { get; set; }

    public string? SpcLan3 { get; set; }
}
