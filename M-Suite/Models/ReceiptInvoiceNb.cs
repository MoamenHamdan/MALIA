using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ReceiptInvoiceNb
{
    public int RiId { get; set; }

    public int? RiBeId { get; set; }

    public int RiFeId { get; set; }

    public int RiSmId { get; set; }

    public int RiCdIdRit { get; set; }

    public string RiType { get; set; } = null!;

    public string? RiPrefix { get; set; }

    public string RiFromCode { get; set; } = null!;

    public string? RiToCode { get; set; }

    public short RiTotalLength { get; set; }

    public int? RiIsCreated { get; set; }

    public int? RiIsModified { get; set; }
}
