using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionReason
{
    public int TsrId { get; set; }

    public int? TsrTsId { get; set; }

    public int? TsrOrgId { get; set; }

    public int? TsrUsId { get; set; }

    public int? TsrTssId { get; set; }

    public int TsrCdIdTsr { get; set; }

    public DateTime TsrDate { get; set; }

    public string? TsrRemarks { get; set; }

    public virtual Codesc TsrCdIdTsrNavigation { get; set; } = null!;

    public virtual Transaction? TsrTs { get; set; }

    public virtual Transactionstatus? TsrTss { get; set; }
}
