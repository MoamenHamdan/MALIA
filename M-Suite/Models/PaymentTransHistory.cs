using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PaymentTransHistory
{
    public int PthId { get; set; }

    public int PthPhId { get; set; }

    public decimal PthAmount { get; set; }

    public int PthCdIdCur { get; set; }

    public string? PthDocno { get; set; }

    public string? PthPaDocno { get; set; }

    public string? PthDtTransNo { get; set; }

    public int? PthBeId { get; set; }
}
