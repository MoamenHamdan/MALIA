using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class DataInfoSnc
{
    public int SDiId { get; set; }

    public int SDiSmId { get; set; }

    public DateTime SDiCreated { get; set; }

    public DateTime? SDiMerged { get; set; }

    public string SDiVersion { get; set; } = null!;
}
