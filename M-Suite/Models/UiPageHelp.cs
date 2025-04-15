using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UiPageHelp
{
    public int PghId { get; set; }

    public string PghPageLink { get; set; } = null!;

    public string PghHelpLinkLan1 { get; set; } = null!;

    public string? PghHelpLinkLan2 { get; set; }

    public string? PghHelpLinkLan3 { get; set; }
}
