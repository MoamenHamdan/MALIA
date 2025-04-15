using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ModifiedField
{
    public int ModId { get; set; }

    public string? ModTable { get; set; }

    public int? ModPk { get; set; }

    public string? ModField { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime? ModDate { get; set; }

    public int ModUsId { get; set; }

    public string ModVersion { get; set; } = null!;

    public int? ModSynched { get; set; }
}
