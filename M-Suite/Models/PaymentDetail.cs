using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PaymentDetail
{
    public int PadId { get; set; }

    public int? PadOrgId { get; set; }

    public int PadPaId { get; set; }

    public int? PadPaOrgId { get; set; }

    public int PadCdIdPam { get; set; }

    public int PadCdIdCur { get; set; }

    public int? PadCdIdBnk { get; set; }

    public int? PadCdIdCct { get; set; }

    public int? PadBuId { get; set; }

    public decimal PadAmount { get; set; }

    public decimal? PadAmountBc { get; set; }

    public string? PadCcNumber { get; set; }

    public DateTime? PadCcDate { get; set; }

    public string? PadCcName { get; set; }

    public decimal? PadCurRate { get; set; }

    public decimal? PadInvCurRate { get; set; }

    public DateTime? PadCreateDate { get; set; }

    public DateTime? PadModifiedDate { get; set; }

    public short? PadLineSequence { get; set; }

    public string? PadJournalno { get; set; }

    public int? PadLinenumber { get; set; }

    public int? PadIsCreditcard { get; set; }

    public virtual BusinessUnit? PadBu { get; set; }

    public virtual Codesc? PadCdIdBnkNavigation { get; set; }

    public virtual Codesc? PadCdIdCctNavigation { get; set; }

    public virtual Codesc PadCdIdCurNavigation { get; set; } = null!;

    public virtual Codesc PadCdIdPamNavigation { get; set; } = null!;

    public virtual Payment PadPa { get; set; } = null!;
}
