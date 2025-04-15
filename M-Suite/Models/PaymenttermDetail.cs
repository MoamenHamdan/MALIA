using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PaymenttermDetail
{
    public int PtdId { get; set; }

    public int PtdPtId { get; set; }

    public short PtdOrder { get; set; }

    public short PtdDueDays { get; set; }

    public decimal PtdAmountPerc { get; set; }

    public decimal PtdCommission { get; set; }

    public virtual Paymentterm PtdPt { get; set; } = null!;
}
