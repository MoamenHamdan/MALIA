using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartyPaymentterm
{
    public int ThptId { get; set; }

    public int ThptPtId { get; set; }

    public int ThptThpfId { get; set; }

    public virtual Paymentterm ThptPt { get; set; } = null!;

    public virtual ThirdpartyFinance ThptThpf { get; set; } = null!;
}
