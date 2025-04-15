using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CustomerFinanceSnc
{
    public int SCfId { get; set; }

    public int? SCfCuId { get; set; }

    public int? SCfCdIdCur { get; set; }

    public int? SCfFeId { get; set; }

    public int? SCfPtId { get; set; }

    public string SCfPaymentType { get; set; } = null!;

    public string? SCfCreditLimit { get; set; }

    public short SCfCreditDaysLimit { get; set; }

    public decimal SCfBalance { get; set; }

    public decimal SCfDiscount { get; set; }

    public string? SCfCommercialNo { get; set; }

    public string? SCfTaxId { get; set; }

    public short SCfIsCreated { get; set; }

    public short SCfIsModified { get; set; }

    public string? SCfAddressRef { get; set; }

    public int SCfSmId { get; set; }

    public string SCfVersion { get; set; } = null!;

    public string? SCfCuUid { get; set; }
}
