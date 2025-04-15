using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ProspectThirdpartysite
{
    public int PthpsId { get; set; }

    public int? PthpsOrgId { get; set; }

    public int? PthpsThpsId { get; set; }

    public string PthpsCode { get; set; } = null!;

    public string PthpsBarcode { get; set; } = null!;

    public string PthpsNameLan1 { get; set; } = null!;

    public string? PthpsNameLan2 { get; set; }

    public string? PthpsNameLan3 { get; set; }

    public int? PthpsCdIdTpg { get; set; }

    public int PthpsCdIdBst { get; set; }

    public int? PthpsCdIdPsts { get; set; }

    public int? PthpsGlId { get; set; }

    public int? PthpsPlId { get; set; }

    public string? PthpsAddress1 { get; set; }

    public string? PthpsAddress2 { get; set; }

    public string? PthpsAddress3 { get; set; }

    public string? PthpsLatitude { get; set; }

    public string? PthpsLongitude { get; set; }

    public string? PthpsPhone1 { get; set; }

    public string? PthpsPhone2 { get; set; }

    public string? PthpsMobile1 { get; set; }

    public string? PthpsMobile2 { get; set; }

    public string? PthpsEmail { get; set; }

    public string? PthpsWebsite { get; set; }

    public string? PthpsFax { get; set; }

    public string? PthpsContactNameLan1 { get; set; }

    public string? PthpsContactNameLan2 { get; set; }

    public string? PthpsContactNameLan3 { get; set; }

    public string? PthpsRemarks { get; set; }

    public int PthpsUsIdCr { get; set; }

    public short PthpsActive { get; set; }

    public DateTime PthpsCreateDate { get; set; }

    public int? PthpsUsIdUp { get; set; }

    public DateTime? PthpsUpdateDate { get; set; }

    public string PthpsImpUid { get; set; } = null!;

    public string? PthpsProfileImage { get; set; }

    public virtual Codesc PthpsCdIdBstNavigation { get; set; } = null!;

    public virtual Codesc? PthpsCdIdPstsNavigation { get; set; }

    public virtual Codesc? PthpsCdIdTpgNavigation { get; set; }

    public virtual GeoLocation? PthpsGl { get; set; }

    public virtual PhysicalLocation? PthpsPl { get; set; }

    public virtual User PthpsUsIdCrNavigation { get; set; } = null!;

    public virtual User? PthpsUsIdUpNavigation { get; set; }
}
