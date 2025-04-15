using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2Question
{
    public int SrqId { get; set; }

    public int SrqSrId { get; set; }

    public int? SrqSaId { get; set; }

    public int? SrqSadIdParent { get; set; }

    public int? SrqSrqId { get; set; }

    public int? SrqCdIdSqa { get; set; }

    public int SrqCdIdAnt { get; set; }

    public int? SrqCdIdFrq { get; set; }

    public int? SrqCdIdSgr { get; set; }

    public short? SrqOrder { get; set; }

    public string SrqCode { get; set; } = null!;

    public string? SrqBarcode { get; set; }

    public string? SrqQuestion { get; set; }

    public short? SrqIsRequired { get; set; }

    public short? SrqRequireBarcode { get; set; }

    public short? SrqMultipleSelection { get; set; }

    public string? SrqParentAnswer { get; set; }

    public string? SrqGroupCode { get; set; }

    public string? SrqGroupText { get; set; }

    public short? SrqCanMultiply { get; set; }

    public int? SrqIdValue { get; set; }

    public string? SrqIdTable { get; set; }

    public short? SrqActive { get; set; }

    public int? SrqOrgId { get; set; }

    public string? SrqVersion { get; set; }

    public virtual ICollection<Survey2Question> InverseSrqSrq { get; set; } = new List<Survey2Question>();

    public virtual Codesc SrqCdIdAntNavigation { get; set; } = null!;

    public virtual Codesc? SrqCdIdFrqNavigation { get; set; }

    public virtual Codesc? SrqCdIdSgrNavigation { get; set; }

    public virtual Codesc? SrqCdIdSqaNavigation { get; set; }

    public virtual Survey2answer? SrqSa { get; set; }

    public virtual Survey2answerDetail? SrqSadIdParentNavigation { get; set; }

    public virtual Survey2 SrqSr { get; set; } = null!;

    public virtual Survey2Question? SrqSrq { get; set; }

    public virtual ICollection<Survey2questionDetail> Survey2questionDetails { get; set; } = new List<Survey2questionDetail>();
}
