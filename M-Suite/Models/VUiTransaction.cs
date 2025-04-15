using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VUiTransaction
{
    public int UtsId { get; set; }

    public string UtsTstCode { get; set; } = null!;

    public string? UtsTstDescriptionLan1 { get; set; }

    public string? UtsTstDescriptionLan2 { get; set; }

    public string? UtsTstDescriptionLan3 { get; set; }

    public string UtsTssCode { get; set; } = null!;

    public string UtsTssDescriptionLan1 { get; set; } = null!;

    public string UtsTssDescriptionLan2 { get; set; } = null!;

    public string UtsTssDescriptionLan3 { get; set; } = null!;

    public int? UtsTstId { get; set; }

    public int? UtsTssId { get; set; }

    public short? UtsTsId { get; set; }

    public short? UtsTsOrgId { get; set; }

    public short? UtsTsUsId { get; set; }

    public short? UtsTsBuId { get; set; }

    public short? UtsTsVtId { get; set; }

    public short? UtsTsTstId { get; set; }

    public short? UtsTsTssId { get; set; }

    public short? UtsTsCdIdSrc { get; set; }

    public short? UtsTsCdIdCur { get; set; }

    public short? UtsTsCdIdCms { get; set; }

    public short? UtsTsCdIdPam { get; set; }

    public short? UtsTsThpsIdBill { get; set; }

    public short? UtsTsThpsIdShip { get; set; }

    public short? UtsTsSgdId { get; set; }

    public short? UtsTsNumber { get; set; }

    public short? UtsTsOurReference { get; set; }

    public short? UtsTsTheirReference { get; set; }

    public short? UtsTsDueDate { get; set; }

    public short? UtsTsDate { get; set; }

    public short? UtsTsDiscount { get; set; }

    public short? UtsTsTotalDiscount { get; set; }

    public short? UtsTsTotalDiscountBc { get; set; }

    public short? UtsTsTotalTax { get; set; }

    public short? UtsTsTotalTaxBc { get; set; }

    public short? UtsTsTotal { get; set; }

    public short? UtsTsTotalBc { get; set; }

    public short? UtsTsRemarks { get; set; }

    public short? UtsTsCreateDate { get; set; }

    public short? UtsTsModifiedDate { get; set; }

    public short? UtsTsCurRate { get; set; }

    public short? UtsTsInvCurRate { get; set; }

    public short? UtsBtnApprove { get; set; }

    public short? UtsBtnApply { get; set; }

    public short? UtsBtnAddItem { get; set; }

    public short? UtsBtnAutoAllocate { get; set; }

    public short? UtsBtnVoid { get; set; }

    public short? UtsUsIdCreatedby { get; set; }

    public short? UtsBtnGetpromotion { get; set; }

    public short? UtsBtnSubmit { get; set; }

    public short? UtsBtnReject { get; set; }

    public short? UtsBtnAdditemDetail { get; set; }

    public short? UtsBtnIngridDelete { get; set; }

    public short? UtsBtnIngridAddsimilar { get; set; }

    public short? UtsBtnIngridShowdetail { get; set; }
}
