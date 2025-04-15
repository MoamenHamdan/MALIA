using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PaymentStatusHistory
{
    public int PashId { get; set; }

    public int PashPssId { get; set; }

    public int PashPaId { get; set; }

    public int PashUsId { get; set; }

    public DateTime PashDate { get; set; }

    public string? PashComment { get; set; }

    public virtual Payment PashPa { get; set; } = null!;

    public virtual Paymentstatus PashPss { get; set; } = null!;

    public virtual User PashUs { get; set; } = null!;
}
