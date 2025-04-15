using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VTransactiontypestatus
{
    public int TtsId { get; set; }

    public int TtsTstId { get; set; }

    public int TtsTssId { get; set; }

    public string TstCode { get; set; } = null!;

    public string? TstDescription { get; set; }

    public string TssCode { get; set; } = null!;

    public string TssDescription { get; set; } = null!;

    public short TtsReserveStock { get; set; }
}
