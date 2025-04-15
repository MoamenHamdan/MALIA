using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SalesAdjustmentSnc
{
    public int SSjId { get; set; }

    public int? SSjBeId { get; set; }

    public int? SSjSjrId { get; set; }

    public int SSjSoId { get; set; }

    public decimal SSjAmount { get; set; }

    public string? SSjComment { get; set; }

    public string SSjSmId { get; set; } = null!;

    public string SSjVersion { get; set; } = null!;
}
