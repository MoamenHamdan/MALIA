using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkPaymentDetail
{
    public int PadId { get; set; }

    public int PaId { get; set; }

    public int PadCdIdPam { get; set; }

    public string PaCurCode { get; set; } = null!;

    public string? PadCurDescriptionLan1 { get; set; }

    public string? PadCurDescriptionLan2 { get; set; }

    public string? PadCurDescriptionLan3 { get; set; }

    public string? BnkCode { get; set; }

    public string? BnkDescriptionLan1 { get; set; }

    public string? BnkDescriptionLan2 { get; set; }

    public string? BnkDescriptionLan3 { get; set; }

    public string PamCode { get; set; } = null!;

    public string? PamDescriptionLan1 { get; set; }

    public string? PamDescriptionLan2 { get; set; }

    public string? PamDescriptionLan3 { get; set; }

    public decimal PadAmount { get; set; }

    public decimal? PadAmountBc { get; set; }

    public string? PadCcNumber { get; set; }

    public DateTime? PadCcDate { get; set; }

    public string? PadCcName { get; set; }

    public decimal? PadCurRate { get; set; }

    public decimal? PadInvCurRate { get; set; }

    public DateTime? PadCreateDate { get; set; }

    public DateTime? PadModifiedDate { get; set; }
}
