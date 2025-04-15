using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkThirdpartyFinance
{
    public int ThpfId { get; set; }

    public int? ThpfThpsId { get; set; }

    public int ThpfBuId { get; set; }

    public int? ThpfCdIdCur { get; set; }

    public int? ThpfTaxId { get; set; }

    public int? ThpfLpId { get; set; }

    public decimal ThpfCreditLimit { get; set; }

    public decimal? ThpfCreditLimitBc { get; set; }

    public decimal ThpfBalance { get; set; }

    public decimal? ThpfBalanceBc { get; set; }

    public decimal ThpfDiscount { get; set; }

    public string? ThpfAccountNo { get; set; }

    public DateTime? ThpfCreateDate { get; set; }

    public DateTime? ThpfModifiedDate { get; set; }

    public short ThpfActive { get; set; }

    public string TcurCode { get; set; } = null!;

    public string? TcurDescriptionLan2 { get; set; }

    public string? TcurDescriptionLan1 { get; set; }

    public string? TcurDescriptionLan3 { get; set; }

    public string? ThpsBu { get; set; }
}
