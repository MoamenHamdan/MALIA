using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CreditdebitnoteInvoice
{
    public int CdniId { get; set; }

    public int CdniCdnId { get; set; }

    public int CdniTsId { get; set; }

    public DateTime? CdniCreatedDate { get; set; }

    public int? CdniCreatedBy { get; set; }

    public virtual Creditdebitnote CdniCdn { get; set; } = null!;

    public virtual Transaction CdniTs { get; set; } = null!;
}
