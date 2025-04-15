using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class DueTransSnc
{
    public int SDtId { get; set; }

    public int SDtCuId { get; set; }

    public int? SDtFeId { get; set; }

    public int SDtCdIdCur { get; set; }

    public int SDtSmId { get; set; }

    public int? SDtSoId { get; set; }

    public short? SDtDueOrder { get; set; }

    public string SDtTransNo { get; set; } = null!;

    public string SDtDate { get; set; } = null!;

    public decimal SDtAmount { get; set; }

    public decimal SDtRemainAmt { get; set; }

    public decimal SDtRoundValue { get; set; }

    public string SDtCurCode { get; set; } = null!;

    public DateTime? SDtDueDate { get; set; }

    public short? SDtIsCreated { get; set; }

    public short? SDtIsModified { get; set; }

    public short? SDtVoided { get; set; }

    public string SDtVersion { get; set; } = null!;

    public string? SDtSoType { get; set; }

    public short? SDtSynched { get; set; }

    public string? SDtImpUid { get; set; }

    public string? SDtSoUid { get; set; }

    public string? SDtUid { get; set; }

    public string? SDtDtUid { get; set; }

    public string? SDtIsVat { get; set; }
}
