using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ReceiptInvoiceNbSnc
{
    public int SRiId { get; set; }

    public string SRiType { get; set; } = null!;

    public int SRiSmId { get; set; }

    public string SRiFromCode { get; set; } = null!;

    public string? SRiToCode { get; set; }

    public string? SRiCpCode { get; set; }

    public int? SRiIsModified { get; set; }

    public int? SRiFeId { get; set; }

    public string? SRiPrefix { get; set; }

    public short SRiTotalLength { get; set; }

    public string SRiVersion { get; set; } = null!;

    public string? SRiSynched { get; set; }
}
