using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartyClassificationV
{
    public int ClsId { get; set; }

    public int? ClsFamilyId { get; set; }

    public string ClsCode { get; set; } = null!;

    public string? ClsLan1 { get; set; }

    public string? ClsLan2 { get; set; }

    public string? ClsLan3 { get; set; }
}
