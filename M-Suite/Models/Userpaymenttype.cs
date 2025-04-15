using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Userpaymenttype
{
    public int UptId { get; set; }

    public string UptCode { get; set; } = null!;

    public string UptDescriptionLan1 { get; set; } = null!;

    public string? UptDescriptionLan2 { get; set; }

    public string? UptDescriptionLan3 { get; set; }

    public short UptDebitCredit { get; set; }

    public virtual ICollection<UserPayment> UserPayments { get; set; } = new List<UserPayment>();

    public virtual ICollection<UserpaymentstatusTransition> UserpaymentstatusTransitions { get; set; } = new List<UserpaymentstatusTransition>();
}
