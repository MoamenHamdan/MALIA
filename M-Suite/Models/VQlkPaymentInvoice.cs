using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkPaymentInvoice
{
    public int PaiId { get; set; }

    public int PaId { get; set; }

    public int? DiId { get; set; }

    public decimal PaiAmount { get; set; }

    public decimal? PaiAmountBc { get; set; }

    public DateTime? PaiCreateDate { get; set; }

    public DateTime? PaiModifiedDate { get; set; }

    public string PaiCurCode { get; set; } = null!;

    public string? PaiCurDescriptionLan1 { get; set; }

    public string? PaiCurDescriptionLan2 { get; set; }

    public string? PaiCurDescriptionLan3 { get; set; }
}
