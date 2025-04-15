using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VThirdpartysiteCustomersShipTo
{
    public int ThpsId { get; set; }

    public int? ThpsOrgId { get; set; }

    public int ThpsThpId { get; set; }

    public int ThpsCdIdBst { get; set; }

    public int? ThpsGlId { get; set; }

    public string ThpsCode { get; set; } = null!;

    public string ThpsBarcode { get; set; } = null!;

    public string ThpsNameLan1 { get; set; } = null!;

    public string? ThpsNameLan2 { get; set; }

    public string? ThpsNameLan3 { get; set; }

    public string? ThpsAddress1 { get; set; }

    public string? ThpsAddress2 { get; set; }

    public string? ThpsAddress3 { get; set; }

    public string? ThpsLongitude { get; set; }

    public string? ThpsLatitude { get; set; }

    public string? ThpsPhone { get; set; }

    public string? ThpsMobile { get; set; }

    public string? ThpsEmail { get; set; }

    public string? ThpsWebsite { get; set; }

    public string? ThpsFax { get; set; }

    public string? ThpsContactNameLan1 { get; set; }

    public string? ThpsContactNameLan2 { get; set; }

    public string? ThpsContactNameLan3 { get; set; }

    public DateTime ThpsCreateDate { get; set; }

    public string ThpsImpUid { get; set; } = null!;

    public short ThpsActive { get; set; }
}
