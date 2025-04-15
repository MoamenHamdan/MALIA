using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class BarcodeActionMapping
{
    public int BamId { get; set; }

    public string BamBarcode { get; set; } = null!;

    public string BamActionType { get; set; } = null!;

    public string BamActionText { get; set; } = null!;

    public int BamActionInt { get; set; }

    public string? BamScreenName { get; set; }

    public int? BamMmId { get; set; }
}
