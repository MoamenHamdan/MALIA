using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PaymentDetailsSnc
{
    public int SPadId { get; set; }

    public int SPadPaId { get; set; }

    public string SPadType { get; set; } = null!;

    public decimal SPadAmount { get; set; }

    public int SPadCdIdCur { get; set; }

    public int? SPadCdIdBnk { get; set; }

    public string? SPadChkNum { get; set; }

    public string? SPadChkDate { get; set; }

    public string? SPadCurRate { get; set; }

    public short? SPadSynched { get; set; }

    public short? SPadIsCreated { get; set; }

    public string SPadVersion { get; set; } = null!;

    public int SPadSmId { get; set; }

    public string? SPadComments { get; set; }

    public string? SPadPaUid { get; set; }
}
