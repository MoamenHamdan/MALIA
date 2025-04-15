using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Userpaymentstatus
{
    public int UpsId { get; set; }

    public string UpsCode { get; set; } = null!;

    public string UpsDescriptionLan1 { get; set; } = null!;

    public string? UpsDescriptionLan2 { get; set; }

    public string? UpsDescriptionLan3 { get; set; }

    public string UpsLabelCode { get; set; } = null!;

    public string? UpsStyle { get; set; }

    public string? UpsConfirmationCode { get; set; }

    public int UpsOrder { get; set; }

    public virtual ICollection<UserPayment> UserPayments { get; set; } = new List<UserPayment>();

    public virtual ICollection<UserpaymentstatusTransition> UserpaymentstatusTransitionUpstUpsIdFromNavigations { get; set; } = new List<UserpaymentstatusTransition>();

    public virtual ICollection<UserpaymentstatusTransition> UserpaymentstatusTransitionUpstUpsIdToNavigations { get; set; } = new List<UserpaymentstatusTransition>();
}
