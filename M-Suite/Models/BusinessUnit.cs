using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class BusinessUnit
{
    public int BuId { get; set; }

    public int? BuBuId { get; set; }

    public int? BuCpId { get; set; }

    public string BuCode { get; set; } = null!;

    public string BuDescriptionLan1 { get; set; } = null!;

    public string? BuDescriptionLan2 { get; set; }

    public string? BuDescriptionLan3 { get; set; }

    public string BuPath { get; set; } = null!;

    public string? BuImpUid { get; set; }

    public string? BuLeId { get; set; }

    public string? BuOuId { get; set; }

    public string? BuOrgCode { get; set; }

    public string? BuPrefix { get; set; }

    public virtual BusinessUnit? BuBu { get; set; }

    public virtual Company? BuCp { get; set; }

    public virtual ICollection<BusinessUnit> InverseBuBu { get; set; } = new List<BusinessUnit>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
