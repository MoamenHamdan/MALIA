using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PaymentTransSnc
{
    public int SPatId { get; set; }

    public int SPatPaId { get; set; }

    public int? SPatDtId { get; set; }

    public decimal SPatAmount { get; set; }

    public int SPatCdIdCur { get; set; }

    public string? SPatDocno { get; set; }

    public short? SPatIsCreated { get; set; }

    public short? SPatIsModified { get; set; }

    public short? SPatSynched { get; set; }

    public string SPatVersion { get; set; } = null!;

    public int SPatSmId { get; set; }

    public int? SPatSoId { get; set; }

    public string? SPatPaDocno { get; set; }

    public string? SPatDtTransNo { get; set; }

    public string? SPatSoUid { get; set; }

    public string? SPatPaUid { get; set; }

    public string? SPatDtUid { get; set; }
}
