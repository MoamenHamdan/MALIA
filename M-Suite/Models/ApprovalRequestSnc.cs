using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ApprovalRequestSnc
{
    public int SArId { get; set; }

    public string SArUid { get; set; } = null!;

    public string? SArCode { get; set; }

    public string? SArDescriptionLan1 { get; set; }

    public string? SArDescriptionLan2 { get; set; }

    public string? SArDescriptionLan3 { get; set; }

    public int SArCdIdArt { get; set; }

    public int SArUsIdReq { get; set; }

    public int? SArUsIdApp { get; set; }

    public string? SArRemarksReq { get; set; }

    public string? SArRemarksApp { get; set; }

    public int SArCdIdArsts { get; set; }

    public string? SArLatitude { get; set; }

    public string? SArLongitude { get; set; }

    public int? SArCdIdArtbl { get; set; }

    public int? SArFkValue { get; set; }

    public DateTime SArCreationDate { get; set; }

    public int SArUsIdCr { get; set; }

    public DateTime? SArRequestDate { get; set; }

    public int? SArNotification { get; set; }

    public int SArSmId { get; set; }

    public string SArVersion { get; set; } = null!;

    public string? SArVtUid { get; set; }

    public string? SArFkUid { get; set; }

    public int? SArThpsId { get; set; }

    public string? SArText1 { get; set; }

    public string? SArTsTotal { get; set; }

    public string? SArCreditLimit { get; set; }

    public string? SArBalanceBeforeTs { get; set; }

    public string? SArExceedValue { get; set; }

    public string? SArQuota { get; set; }
}
