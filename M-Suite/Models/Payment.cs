using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Payment
{
    public int PaId { get; set; }

    public int? PaOrgId { get; set; }

    public int? PaVtId { get; set; }

    public int? PaMvId { get; set; }

    public int? PaCdIdSrc { get; set; }

    public int PaCdIdCur { get; set; }

    public int? PaCdIdPat { get; set; }

    public int? PaUsId { get; set; }

    public int? PaBuId { get; set; }

    public int? PaSgdId { get; set; }

    public DateTime PaDate { get; set; }

    public string PaNumber { get; set; } = null!;

    public decimal PaTotalAmount { get; set; }

    public decimal? PaTotalAmountBc { get; set; }

    public decimal? PaRoundAmount { get; set; }

    public short? PaVoid { get; set; }

    public short? PaApproved { get; set; }

    public DateTime? PaCreateDate { get; set; }

    public DateTime? PaModifiedDate { get; set; }

    public int? PaPyId { get; set; }

    public int? PaThpsId { get; set; }

    public int? PaPssId { get; set; }

    public string? PaRemarks { get; set; }

    public string? PaUid { get; set; }

    public string? PaJournalno { get; set; }

    public int? PaLinenumber { get; set; }

    public virtual BusinessUnit? PaBu { get; set; }

    public virtual User? PaUs { get; set; }
}
