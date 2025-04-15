using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPaymentHistory
{
    public int Pk { get; set; }

    public int? PaBuId { get; set; }

    public DateTime PaDate { get; set; }

    public string PaNumber { get; set; } = null!;

    public string? PaTotalAmount { get; set; }

    public int PaCdIdCur { get; set; }

    public string PaCurSymb { get; set; } = null!;

    public DateTime PhDatetime { get; set; }

    public int? PhCuId { get; set; }
}
