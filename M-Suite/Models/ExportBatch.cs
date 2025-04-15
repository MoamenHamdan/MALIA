using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExportBatch
{
    public string? ExpBatchNo { get; set; }

    public int? ExpUsId { get; set; }

    public int? ExpStatus { get; set; }

    public DateTime? ExpSentDate { get; set; }
}
