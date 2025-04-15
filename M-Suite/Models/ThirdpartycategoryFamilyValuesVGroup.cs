using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartycategoryFamilyValuesVGroup
{
    public int? IThcfId { get; set; }

    public int IThcfvThcfId { get; set; }

    public string IThcfvCode { get; set; } = null!;

    public string IThcfvDescriptionLan1 { get; set; } = null!;

    public string IThcfvDescriptionLan2 { get; set; } = null!;

    public string IThcfvDescriptionLan3 { get; set; } = null!;
}
