using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkBusinessUnit
{
    public int BuId { get; set; }

    public int? BuBuId { get; set; }

    public int? BuCpId { get; set; }

    public string BuCode { get; set; } = null!;

    public string BuDescriptionLan1 { get; set; } = null!;

    public string? BuDescriptionLan2 { get; set; }

    public string? BuDescriptionLan3 { get; set; }

    public string BuPath { get; set; } = null!;
}
