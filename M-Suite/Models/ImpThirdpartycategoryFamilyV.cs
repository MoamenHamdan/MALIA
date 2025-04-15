using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpThirdpartycategoryFamilyV
{
    public int? IThcfThcfId { get; set; }

    public int? IThcfBuId { get; set; }

    public int IThcfLevel { get; set; }

    public int IThcfCalculated { get; set; }

    public string IThcfDescriptionLan3 { get; set; } = null!;

    public string IThcfDescriptionLan1 { get; set; } = null!;

    public string IThcfDescriptionLan2 { get; set; } = null!;

    public string IThcfCode { get; set; } = null!;

    public int IxThcfId { get; set; }
}
