using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserPayment
{
    public int UpId { get; set; }

    public int? UpOrgId { get; set; }

    public int? UpCdIdSrc { get; set; }

    public int UpBuId { get; set; }

    public int UpUsId { get; set; }

    public int UpUsIdCashier { get; set; }

    public int UpUpsId { get; set; }

    public int UpUptId { get; set; }

    public DateTime UpDate { get; set; }

    public string UpNumber { get; set; } = null!;

    public DateTime UpCreateDate { get; set; }

    public DateTime UpModifiedDate { get; set; }

    public string? UpRemarks { get; set; }

    public DateTime? UpDateFrom { get; set; }

    public DateTime? UpDateTo { get; set; }

    public virtual BusinessUnit UpBu { get; set; } = null!;

    public virtual Codesc? UpCdIdSrcNavigation { get; set; }

    public virtual Userpaymentstatus UpUps { get; set; } = null!;

    public virtual Userpaymenttype UpUpt { get; set; } = null!;

    public virtual User UpUs { get; set; } = null!;

    public virtual User UpUsIdCashierNavigation { get; set; } = null!;

    public virtual ICollection<UserPaymentDetail> UserPaymentDetails { get; set; } = new List<UserPaymentDetail>();

    public virtual ICollection<UserPaymentLine> UserPaymentLines { get; set; } = new List<UserPaymentLine>();
}
