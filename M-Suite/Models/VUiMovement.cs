using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VUiMovement
{
    public int UmvId { get; set; }

    public string? UmvMvtCode { get; set; }

    public string? UmvMvtDescriptionLan1 { get; set; }

    public string? UmvMvtDescriptionLan2 { get; set; }

    public string? UmvMvtDescriptionLan3 { get; set; }

    public string UmvMssCode { get; set; } = null!;

    public string UmvMssDescriptionLan1 { get; set; } = null!;

    public string UmvMssDescriptionLan2 { get; set; } = null!;

    public string UmvMssDescriptionLan3 { get; set; } = null!;

    public int? UmvMvtId { get; set; }

    public int? UmvMssId { get; set; }

    public short? UmvMvId { get; set; }

    public short? UmvMvOrgId { get; set; }

    public short? UmvMvUsId { get; set; }

    public short? UmvMvBuId { get; set; }

    public short? UmvMvCdIdSrc { get; set; }

    public short? UmvMvMvtId { get; set; }

    public short? UmvMvSgdId { get; set; }

    public short? UmvMvCdIdCms { get; set; }

    public short? UmvMvPlIdWhsFrom { get; set; }

    public short? UmvMvPlIdWhsTo { get; set; }

    public short? UmvMvMssId { get; set; }

    public short? UmvMvNumber { get; set; }

    public short? UmvMvOurReference { get; set; }

    public short? UmvMvTheirReference { get; set; }

    public short? UmvMvDueDate { get; set; }

    public short? UmvMvDate { get; set; }

    public short? UmvMvRemarks { get; set; }

    public short? UmvMvCreateDate { get; set; }

    public short? UmvMvModifiedDate { get; set; }

    public short? UmvBtnApprove { get; set; }

    public short? UmvBtnReject { get; set; }

    public short? UmvBtnVoid { get; set; }

    public short? UmvBtnAddItem { get; set; }

    public short? UmvBtnAddDelivery { get; set; }

    public short? UmvBtnAutoAllocate { get; set; }

    public short? UmvCanEdit { get; set; }

    public short? UmvCheckAvailability { get; set; }
}
