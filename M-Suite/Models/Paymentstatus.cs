using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Paymentstatus
{
    public int PssId { get; set; }

    public string PssCode { get; set; } = null!;

    public string? PssDescriptionLan1 { get; set; }

    public string? PssDescriptionLan2 { get; set; }

    public string? PssDescriptionLan3 { get; set; }

    public virtual ICollection<PaymentStatusHistory> PaymentStatusHistories { get; set; } = new List<PaymentStatusHistory>();
}
