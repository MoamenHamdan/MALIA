using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PaymentInvoice
{
    public int PaiId { get; set; }

    public int? PaiOrgId { get; set; }

    public int PaiPaId { get; set; }

    public int? PaiPaOrgId { get; set; }

    public int? PaiDiId { get; set; }

    public int PaiCdIdCur { get; set; }

    public decimal PaiAmount { get; set; }

    public decimal? PaiAmountBc { get; set; }

    public DateTime? PaiCreateDate { get; set; }

    public DateTime? PaiModifiedDate { get; set; }

    public decimal? PaiAmountToErp { get; set; }

    public virtual Codesc PaiCdIdCurNavigation { get; set; } = null!;

    public virtual DueInvoice? PaiDi { get; set; }

    public virtual Payment PaiPa { get; set; } = null!;
}
