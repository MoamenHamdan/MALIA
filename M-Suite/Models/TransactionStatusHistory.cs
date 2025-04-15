using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionStatusHistory
{
    public int TsshId { get; set; }

    public int TsshTssId { get; set; }

    public int TsshTsId { get; set; }

    public int TsshUsId { get; set; }

    public DateTime TsshCreateDate { get; set; }

    public string? TsshComments { get; set; }

    public virtual Transaction TsshTs { get; set; } = null!;

    public virtual Transactionstatus TsshTss { get; set; } = null!;

    public virtual User TsshUs { get; set; } = null!;
}
