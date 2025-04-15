using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Creditdebitnote
{
    public int CdnId { get; set; }

    public int CdnBuId { get; set; }

    public int CdnThpsId { get; set; }

    public int CdnCdIdCur { get; set; }

    public int CdnUsIdCr { get; set; }

    public DateTime CdnDate { get; set; }

    public DateTime? CdnCreateDate { get; set; }

    public DateTime? CdnUpdateDate { get; set; }

    public int CdnCdIdCdtyp { get; set; }

    public decimal? CdnAmount { get; set; }

    public int? CdnCdIdCdnrsn { get; set; }

    public string? CdnRemarks { get; set; }

    public int? CdnDiId { get; set; }

    public int? CdnCdIdCdnsts { get; set; }

    public virtual BusinessUnit CdnBu { get; set; } = null!;

    public virtual Codesc? CdnCdIdCdnrsnNavigation { get; set; }

    public virtual Codesc CdnCdIdCdtypNavigation { get; set; } = null!;

    public virtual Codesc CdnCdIdCurNavigation { get; set; } = null!;

    public virtual DueInvoice? CdnDi { get; set; }

    public virtual ThirdpartySite CdnThps { get; set; } = null!;

    public virtual ICollection<CreditdebitnoteInvoice> CreditdebitnoteInvoices { get; set; } = new List<CreditdebitnoteInvoice>();
}
