using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UnitOfMesure
{
    public int UomId { get; set; }

    public int? UomBeId { get; set; }

    public int? UomLevel { get; set; }

    public string UomCode { get; set; } = null!;

    public string? UomDescription { get; set; }

    public int? UomActive { get; set; }
}
