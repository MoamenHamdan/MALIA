using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Paymentterm
{
    public int PtId { get; set; }

    public int PtBuId { get; set; }

    public string PtCode { get; set; } = null!;

    public string? PtDescriptionLan1 { get; set; }

    public string? PtDescriptionLan2 { get; set; }

    public string? PtDescriptionLan3 { get; set; }

    public decimal PtCommission { get; set; }

    public string? PtImpUid { get; set; }

    public virtual ICollection<PaymenttermDetail> PaymenttermDetails { get; set; } = new List<PaymenttermDetail>();

    public virtual BusinessUnit PtBu { get; set; } = null!;

    public virtual ICollection<ThirdpartyPaymentterm> ThirdpartyPaymentterms { get; set; } = new List<ThirdpartyPaymentterm>();
}
