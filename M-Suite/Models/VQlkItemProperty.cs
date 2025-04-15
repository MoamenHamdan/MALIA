using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkItemProperty
{
    public int IcvId { get; set; }

    public int ItId { get; set; }

    public string? IcvValue { get; set; }

    public string IcfCode { get; set; } = null!;

    public string IcfDescriptionLan1 { get; set; } = null!;

    public string IcfDescriptionLan2 { get; set; } = null!;

    public string IcfDescriptionLan3 { get; set; } = null!;

    public string? IcfvCode { get; set; }

    public string? IcfvDescriptionLan1 { get; set; }

    public string? IcfvDescriptionLan2 { get; set; }

    public string? IcfvDescriptionLan3 { get; set; }

    public string IcfvParentCode { get; set; } = null!;

    public string IcfvParentDesc { get; set; } = null!;
}
