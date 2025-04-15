using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UiTransaction
{
    public int UtsId { get; set; }

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

    public virtual Transactionstatus? UtsTss { get; set; }

    public virtual Transactiontype1? UtsTst { get; set; }
}
