using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2
{
    public int SrId { get; set; }

    public int? SrSrId { get; set; }

    public int? SrCdIdSra { get; set; }

    public int? SrCdIdSrt { get; set; }

    public string SrCode { get; set; } = null!;

    public string SrNameLan1 { get; set; } = null!;

    public string? SrNameLan2 { get; set; }

    public string? SrNameLan3 { get; set; }

    public string? SrDescriptionLan1 { get; set; }

    public string? SrDescriptionLan2 { get; set; }

    public string? SrDescriptionLan3 { get; set; }

    public short? SrReadBarcode { get; set; }

    public short? SrActive { get; set; }

    public int? SrOrgId { get; set; }

    public string? SrVersion { get; set; }

    public short? SrGenerated { get; set; }

    public virtual ICollection<ContractCondition> ContractConditions { get; set; } = new List<ContractCondition>();

    public virtual ICollection<Survey2> InverseSrSr { get; set; } = new List<Survey2>();

    public virtual Codesc? SrCdIdSraNavigation { get; set; }

    public virtual Codesc? SrCdIdSrtNavigation { get; set; }

    public virtual Survey2? SrSr { get; set; }

    public virtual ICollection<Survey2BusinessUnit> Survey2BusinessUnits { get; set; } = new List<Survey2BusinessUnit>();

    public virtual ICollection<Survey2Detail> Survey2Details { get; set; } = new List<Survey2Detail>();

    public virtual ICollection<Survey2Question> Survey2Questions { get; set; } = new List<Survey2Question>();

    public virtual ICollection<Survey2Result> Survey2Results { get; set; } = new List<Survey2Result>();

    public virtual ICollection<Survey2Status> Survey2Statuses { get; set; } = new List<Survey2Status>();
}
