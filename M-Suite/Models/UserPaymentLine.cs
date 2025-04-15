using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserPaymentLine
{
    public int UplId { get; set; }

    public int UplUpId { get; set; }

    public int UplCdIdPam { get; set; }

    public int UplCdIdCur { get; set; }

    public int? UplCdIdBank { get; set; }

    public string? UplNumber { get; set; }

    public DateTime UplDate { get; set; }

    public DateTime? UplDocDate { get; set; }

    public decimal? UplAmount { get; set; }

    public decimal? UplCurrencyRate { get; set; }

    public string? UplRemarks { get; set; }

    public virtual Codesc? UplCdIdBankNavigation { get; set; }

    public virtual Codesc UplCdIdCurNavigation { get; set; } = null!;

    public virtual Codesc UplCdIdPamNavigation { get; set; } = null!;

    public virtual UserPayment UplUp { get; set; } = null!;
}
