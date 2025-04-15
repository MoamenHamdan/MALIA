using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkThirdpartySite
{
    public int ThpsId { get; set; }

    public int? ThpsOrgId { get; set; }

    public int ThpsThpId { get; set; }

    public int ThpsCdIdBst { get; set; }

    public int? GlId { get; set; }

    public string ThpsCode { get; set; } = null!;

    public string ThpsBarcode { get; set; } = null!;

    public string ThpsNameLan1 { get; set; } = null!;

    public string Customer { get; set; } = null!;

    public string? ThpsNameLan2 { get; set; }

    public string? ThpsNameLan3 { get; set; }

    public string? ThpsAddress1 { get; set; }

    public string? ThpsAddress2 { get; set; }

    public string? ThpsAddress3 { get; set; }

    public string? ThpsLongitude { get; set; }

    public string? ThpsLatitude { get; set; }

    public string? ThpsContactNameLan1 { get; set; }

    public string? ThpsContactNameLan2 { get; set; }

    public string? ThpsContactNameLan3 { get; set; }

    public DateTime ThpsCreateDate { get; set; }

    public short ThpsActive { get; set; }

    public string? ThpsRemarks { get; set; }

    public string BstCode { get; set; } = null!;

    public string? BstDescriptionLan1 { get; set; }

    public string? BstDescriptionLan2 { get; set; }

    public string? BstDescriptionLan3 { get; set; }

    public int? Gl1Id { get; set; }
}
