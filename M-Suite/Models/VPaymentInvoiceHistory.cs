using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPaymentInvoiceHistory
{
    public int PthId { get; set; }

    public int PthPhId { get; set; }

    public string? PthAmount { get; set; }

    public int PthCdIdCur { get; set; }

    public string? PthDocno { get; set; }

    public string PthPaDocno { get; set; } = null!;

    public string? PthDtTransNo { get; set; }

    public int? PthBeId { get; set; }
}
