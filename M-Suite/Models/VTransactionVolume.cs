using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VTransactionVolume
{
    public int TsvTsId { get; set; }

    public decimal? TsvVolume { get; set; }

    public decimal? TsvWeight { get; set; }

    public string TsWhs { get; set; } = null!;
}
