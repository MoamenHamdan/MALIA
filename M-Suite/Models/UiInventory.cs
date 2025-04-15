using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UiInventory
{
    public int UivId { get; set; }

    public int? UivCdIvtId { get; set; }

    public int? UivCdIvsId { get; set; }

    public short? UivIvCode { get; set; }

    public short? UivIvDateStart { get; set; }

    public short? UivIvDateEnd { get; set; }

    public short? UivIvRemarks { get; set; }

    public short? UivModifiedDate { get; set; }

    public short? UivCreateDate { get; set; }

    public short? UivIvActive { get; set; }

    public short? UivIvItemsQuantity { get; set; }

    public short? UivBtnApprove { get; set; }

    public short? UivBtnVoid { get; set; }

    public short? UivBtnConfirm { get; set; }

    public short? UtsBtnNew { get; set; }

    public short? UtsBtnSubmit { get; set; }
}
