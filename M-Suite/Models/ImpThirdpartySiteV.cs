using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpThirdpartySiteV
{
    public int? IThpsId { get; set; }

    public string? IThpsCode { get; set; }

    public int IThpId { get; set; }

    public int IThpsCdIdBst { get; set; }

    public string? IThpsBarcode { get; set; }

    public string? IThpsNameLan1 { get; set; }

    public string? IThpsNameLan2 { get; set; }

    public string? IThpsNameLan3 { get; set; }

    public string? IThpsAddress1 { get; set; }

    public string? IThpsAddress2 { get; set; }

    public string? IThpsAddress3 { get; set; }

    public int? IThpsLongitude { get; set; }

    public int? IThpsLatitude { get; set; }

    public string? IThpsPhone { get; set; }

    public string? IThpsMobile { get; set; }

    public string? IThpsContactNameLan1 { get; set; }

    public string? IThpsContactNameLan2 { get; set; }

    public string? IThpsContactNameLan3 { get; set; }

    public string IThpsImpUid { get; set; } = null!;

    public int? IThpsEmail { get; set; }

    public int? IThpsWebsite { get; set; }

    public int? IThpsFax { get; set; }

    public string? ICuRemark { get; set; }
}
