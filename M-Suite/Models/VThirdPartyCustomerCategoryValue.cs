using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VThirdPartyCustomerCategoryValue
{
    public int ThcfvId { get; set; }

    public int? ThcfvThcfId { get; set; }

    public string ThcfvCode { get; set; } = null!;

    public string? ThcfvDescriptionLan1 { get; set; }

    public string? ThcfvDescriptionLan2 { get; set; }

    public string? ThcfvDescriptionLan3 { get; set; }
}
