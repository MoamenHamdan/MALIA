using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpReceiptInvoiceNbV
{
    public int IRiBeId { get; set; }

    public int IRiCdIdRit { get; set; }

    public string IRiType { get; set; } = null!;

    public int IRiSmId { get; set; }

    public int IRiFromCode { get; set; }

    public string IRiToCode { get; set; } = null!;

    public string IRiCpCode { get; set; } = null!;

    public int IRiFeId { get; set; }

    public string? IRiPrefix { get; set; }

    public int? IRiTotalLength { get; set; }

    public int? IxRiId { get; set; }
}
