using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UiCodesc
{
    public int UcdId { get; set; }

    public int? UcdCdId { get; set; }

    public int? UcdFcId { get; set; }

    public short? UcdMdId { get; set; }

    public short? UcdBuId { get; set; }

    public short? UcdFcCode { get; set; }

    public short? UcdCode { get; set; }

    public short? UcdDescriptionLan1 { get; set; }

    public short? UcdDescriptionLan2 { get; set; }

    public short? UcdDescriptionLan3 { get; set; }

    public short? UcdNum1 { get; set; }

    public string? UcdNum1DescriptionLan1 { get; set; }

    public string? UcdNum1DescriptionLan2 { get; set; }

    public string? UcdNum1DescriptionLan3 { get; set; }

    public short? UcdNum2 { get; set; }

    public string? UcdNum2DescriptionLan1 { get; set; }

    public string? UcdNum2DescriptionLan2 { get; set; }

    public string? UcdNum2DescriptionLan3 { get; set; }

    public short? UcdText1 { get; set; }

    public string? UcdText1DescriptionLan1 { get; set; }

    public string? UcdText1DescriptionLan2 { get; set; }

    public string? UcdText1DescriptionLan3 { get; set; }

    public short? UcdText2 { get; set; }

    public string? UcdText2DescriptionLan1 { get; set; }

    public string? UcdText2DescriptionLan2 { get; set; }

    public string? UcdText2DescriptionLan3 { get; set; }

    public short? UcdDate2 { get; set; }

    public string? UcdDate2DescriptionLan1 { get; set; }

    public string? UcdDate2DescriptionLan2 { get; set; }

    public string? UcdDate2DescriptionLan3 { get; set; }

    public short? UcdDate1 { get; set; }

    public string? UcdDate1DescriptionLan1 { get; set; }

    public string? UcdDate1DescriptionLan2 { get; set; }

    public string? UcdDate1DescriptionLan3 { get; set; }

    public short? UcdCreateDate { get; set; }

    public short? UcdModifiedDate { get; set; }

    public short? UcdLevel { get; set; }

    public short? UcdHasChildren { get; set; }

    public short? UcdActive { get; set; }

    public short? UcdIsSystem { get; set; }

    public virtual FamilyCodesc? UcdFc { get; set; }
}
