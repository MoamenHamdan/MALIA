using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ApprovalRequest
{
    public int ArId { get; set; }

    public string ArUid { get; set; } = null!;

    public string? ArCode { get; set; }

    public string? ArDescriptionLan1 { get; set; }

    public string? ArDescriptionLan2 { get; set; }

    public string? ArDescriptionLan3 { get; set; }

    public int ArCdIdArt { get; set; }

    public int ArUsIdReq { get; set; }

    public int? ArUsIdApp { get; set; }

    public string? ArRemarksReq { get; set; }

    public string? ArRemarksApp { get; set; }

    public int ArCdIdArsts { get; set; }

    public string? ArLatitude { get; set; }

    public string? ArLongitude { get; set; }

    public int? ArCdIdArtbl { get; set; }

    public int? ArFkValue { get; set; }

    public DateTime ArCreationDate { get; set; }

    public int ArUsIdCr { get; set; }

    public DateTime? ArRequestDate { get; set; }

    public int? ArNotification { get; set; }

    public string ArBatch { get; set; } = null!;

    public short? ArActive { get; set; }

    public string? ArVtUid { get; set; }

    public string? ArFkUid { get; set; }

    public int? ArThpsId { get; set; }

    public string? ArText1 { get; set; }

    public string? ArTsTotal { get; set; }

    public string? ArCreditLimit { get; set; }

    public string? ArBalanceBeforeTs { get; set; }

    public string? ArExceedValue { get; set; }

    public string? ArQuota { get; set; }

    public virtual ICollection<ApprovalRequestDetail> ApprovalRequestDetails { get; set; } = new List<ApprovalRequestDetail>();

    public virtual Codesc ArCdIdArstsNavigation { get; set; } = null!;

    public virtual Codesc ArCdIdArtNavigation { get; set; } = null!;

    public virtual Codesc? ArCdIdArtblNavigation { get; set; }

    public virtual User? ArUsIdAppNavigation { get; set; }

    public virtual User ArUsIdCrNavigation { get; set; } = null!;

    public virtual User ArUsIdReqNavigation { get; set; } = null!;
}
