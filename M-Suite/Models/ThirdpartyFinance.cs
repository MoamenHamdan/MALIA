using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartyFinance
{
    public int ThpfId { get; set; }

    public int? ThpfOrgId { get; set; }

    public int? ThpfThpsId { get; set; }

    public int ThpfBuId { get; set; }

    public int? ThpfCdIdCur { get; set; }

    public int? ThpfTaxId { get; set; }

    public int? ThpfLpId { get; set; }

    public decimal ThpfCreditLimit { get; set; }

    public decimal ThpfBalance { get; set; }

    public decimal ThpfDiscount { get; set; }

    public string? ThpfAccountNo { get; set; }

    public DateTime? ThpfCreateDate { get; set; }

    public DateTime? ThpfModifiedDate { get; set; }

    public string? ThpfImpUid { get; set; }

    public short ThpfActive { get; set; }

    public int? ThpfFreeVolume { get; set; }

    public virtual ICollection<ThirdpartyPaymentterm> ThirdpartyPaymentterms { get; set; } = new List<ThirdpartyPaymentterm>();

    public virtual ICollection<ThirdpartyPaymethod> ThirdpartyPaymethods { get; set; } = new List<ThirdpartyPaymethod>();

    public virtual ICollection<ThirdpartySiteListpriceRoute> ThirdpartySiteListpriceRoutes { get; set; } = new List<ThirdpartySiteListpriceRoute>();

    public virtual ICollection<ThirdpartysitefinanceTax> ThirdpartysitefinanceTaxes { get; set; } = new List<ThirdpartysitefinanceTax>();

    public virtual BusinessUnit ThpfBu { get; set; } = null!;

    public virtual Codesc? ThpfCdIdCurNavigation { get; set; }

    public virtual Listprice? ThpfLp { get; set; }

    public virtual ThirdpartySite? ThpfThps { get; set; }
}
