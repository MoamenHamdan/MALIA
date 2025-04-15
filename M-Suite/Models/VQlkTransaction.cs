using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkTransaction
{
    public int TsId { get; set; }

    public int? TsOrgId { get; set; }

    public int? TsUsId { get; set; }

    public int TsBuId { get; set; }

    public string TsBuDescriptionLan1 { get; set; } = null!;

    public string? TsVtId { get; set; }

    public string TssCode { get; set; } = null!;

    public string TssDescriptionLan1 { get; set; } = null!;

    public string TssDescriptionLan2 { get; set; } = null!;

    public string TssDescriptionLan3 { get; set; } = null!;

    public string TstCode { get; set; } = null!;

    public string? TstDescriptionLan1 { get; set; }

    public string? TstDescriptionLan2 { get; set; }

    public string? TstDescriptionLan3 { get; set; }

    public int TsCdIdSrc { get; set; }

    public int TsCdIdCur { get; set; }

    public int? TsCdIdCms { get; set; }

    public int TsPtId { get; set; }

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

    public decimal TsTotalDiscountBc { get; set; }

    public decimal? TsTotalTax { get; set; }

    public decimal? TsTotalTaxBc { get; set; }

    public decimal TsTotal { get; set; }

    public decimal TsTotalBc { get; set; }

    public string? TsRemarks { get; set; }

    public DateTime? TsCreateDate { get; set; }

    public DateTime? TsModifiedDate { get; set; }

    public decimal? TsCurRate { get; set; }

    public decimal? TsInvCurRate { get; set; }

    public int? TsYear { get; set; }

    public int? TsMonth { get; set; }

    public int? TsDay { get; set; }

    public string? TsgCode { get; set; }

    public string? TsgDescriptionLan1 { get; set; }

    public string? TsgDescriptionLan2 { get; set; }

    public string? TsgDescriptionLan3 { get; set; }

    public int? TsDateNum { get; set; }

    public string? ThpsUsVtBu { get; set; }
}
