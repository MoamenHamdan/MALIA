using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpThirdpartyFinanceV
{
    public int? IThpfOrgId { get; set; }

    public int IThpsId { get; set; }

    public int IThpfBuId { get; set; }

    public int IThpfCdIdCur { get; set; }

    public int? IThpfTaxId { get; set; }

    public int? IThpfPlId { get; set; }

    public decimal IThpfCreditLimit { get; set; }

    public decimal IThpfBalance { get; set; }

    public decimal IThpfDiscount { get; set; }

    public string? IThpfAccountNo { get; set; }

    public DateTime IThpfCreateDate { get; set; }

    public DateTime IThpfModifiedDate { get; set; }

    public int? IThpfImpUid { get; set; }

    public int IThpfActive { get; set; }
}
