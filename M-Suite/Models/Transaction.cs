using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Transaction
{
    public int TsId { get; set; }

    public int? TsOrgId { get; set; }

    public int? TsUsId { get; set; }

    public int TsBuId { get; set; }

    public int? TsVtId { get; set; }

    public int TsTstId { get; set; }

    public int? TsTssId { get; set; }

    public int TsCdIdSrc { get; set; }

    public int TsCdIdCur { get; set; }

    public int? TsCdIdCms { get; set; }

    public int? TsThpsIdBill { get; set; }

    public int? TsThpsIdShip { get; set; }

    public int? TsSgdId { get; set; }

    public string TsNumber { get; set; } = null!;

    public string? TsOurReference { get; set; }

    public string? TsTheirReference { get; set; }

    public DateTime? TsDueDate { get; set; }

    public DateTime TsDate { get; set; }

    public decimal? TsDiscount { get; set; }

    public decimal TsTotalDiscount { get; set; }

    public decimal? TsTotalDiscountBc { get; set; }

    public decimal? TsTotalTax { get; set; }

    public decimal? TsTotalTaxBc { get; set; }

    public decimal TsTotal { get; set; }

    public decimal? TsTotalBc { get; set; }

    public string? TsRemarks { get; set; }

    public DateTime? TsCreateDate { get; set; }

    public DateTime? TsModifiedDate { get; set; }

    public decimal? TsCurRate { get; set; }

    public decimal? TsInvCurRate { get; set; }

    public int? TsUsIdCreatedby { get; set; }

    public int? TsPtId { get; set; }

    public string? TsAttribute01 { get; set; }

    public string? TsAttribute02 { get; set; }

    public string? TsAttribute03 { get; set; }

    public decimal? TsDiscountAmount { get; set; }

    public string? TsUid { get; set; }

    public decimal? TsTotalFinal { get; set; }

    public DateTime? TsExportedDate { get; set; }

    public virtual BusinessUnit TsBu { get; set; } = null!;

    public virtual User? TsUs { get; set; }
}
