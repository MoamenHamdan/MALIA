using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VCodescIgp
{
    public int CdId { get; set; }

    public int? CdCdId { get; set; }

    public int CdFcId { get; set; }

    public int? CdMdId { get; set; }

    public int? CdBuId { get; set; }

    public string CdFcCode { get; set; } = null!;

    public string CdCode { get; set; } = null!;

    public string? CdDescriptionLan2 { get; set; }

    public string? CdDescriptionLan1 { get; set; }

    public string? CdDescriptionLan3 { get; set; }

    public int? CdNum1 { get; set; }

    public int? CdNum2 { get; set; }

    public string? CdText1 { get; set; }

    public string? CdText2 { get; set; }

    public DateTime? CdDate1 { get; set; }

    public DateTime? CdDate2 { get; set; }

    public DateTime CdCreateDate { get; set; }

    public DateTime CdModifiedDate { get; set; }

    public short CdLevel { get; set; }

    public short CdHasChildren { get; set; }

    public short? CdActive { get; set; }

    public short? CdIsSystem { get; set; }
}
