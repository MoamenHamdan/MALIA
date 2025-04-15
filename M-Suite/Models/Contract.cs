using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Contract
{
    public int CnId { get; set; }

    public int CnThpsId { get; set; }

    public int? CnUsId { get; set; }

    public int CnBuId { get; set; }

    public string CnCode { get; set; } = null!;

    public string? CnDescriptionLan1 { get; set; }

    public string? CnDescriptionLan2 { get; set; }

    public string? CnDescriptionLan3 { get; set; }

    public DateTime CnDateFrom { get; set; }

    public DateTime CnDateTo { get; set; }

    public int CnCdIdCnsts { get; set; }

    public DateTime CnCreationDate { get; set; }

    public int CnCreatedBy { get; set; }

    public DateTime? CnUpdateDate { get; set; }

    public int? CnUpdatedBy { get; set; }

    public string? CnRemarks { get; set; }

    public virtual BusinessUnit CnBu { get; set; } = null!;

    public virtual ThirdpartySite CnThps { get; set; } = null!;

    public virtual User? CnUs { get; set; }

    public virtual ICollection<ContractCondition> ContractConditions { get; set; } = new List<ContractCondition>();

    public virtual ICollection<ContractTerm> ContractTerms { get; set; } = new List<ContractTerm>();
}
