using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserPaymentDetail
{
    public int UpdId { get; set; }

    public int UpdUpId { get; set; }

    public int UpdPaId { get; set; }

    public virtual Payment UpdPa { get; set; } = null!;

    public virtual UserPayment UpdUp { get; set; } = null!;
}
