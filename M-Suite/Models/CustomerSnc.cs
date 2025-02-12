using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CustomerSnc
{
    public int SCuId { get; set; }

    public int SCuCdIdCcg { get; set; }

    public int SCuSmId { get; set; }

    public int? SCuGeId { get; set; }

    public int? SCuCdIdCgq { get; set; }

    public string? SCuBarcode { get; set; }

    public string SCuCode { get; set; } = null!;

    public string SCuName { get; set; } = null!;

    public string SCuNameAr { get; set; } = null!;

    public string? SCuContactName { get; set; }

    public string? SCuContactNameAr { get; set; }

    public string? SCuRefId { get; set; }

    public string? SCuText1 { get; set; }

    public string? SCuText2 { get; set; }

    public string? SCuText3 { get; set; }

    public short? SCuActive { get; set; }

    public short SCuIsCreated { get; set; }

    public short SCuIsModified { get; set; }

    public string SCuVersion { get; set; } = null!;

    public string? SCuDesiredTime { get; set; }

    public string? SCuFirstName { get; set; }

    public int? SCuExpectedDlvDate { get; set; }

    public int? SCuCdIdDay { get; set; }

    public string? SCuMiddleName { get; set; }

    public string? SCuLastName { get; set; }

    public string? SCuText { get; set; }

    public string? SCuUid { get; set; }
}
