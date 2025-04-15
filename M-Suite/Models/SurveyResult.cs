using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SurveyResult
{
    public int SrrId { get; set; }

    public int? SrrOrgId { get; set; }

    public int? SrrVtId { get; set; }

    public int? SrrVtIdOrg { get; set; }

    public int? SrrCdIdSrc { get; set; }

    public int? SrrSrId { get; set; }

    public int? SrrSgdId { get; set; }

    public DateTime SrrTimeIn { get; set; }

    public DateTime SrrTimeOut { get; set; }

    public string? SrrComment { get; set; }

    public int? SrrUsId { get; set; }

    public string? SrrUid { get; set; }

    public virtual Codesc? SrrCdIdSrcNavigation { get; set; }

    public virtual SignatureDetail? SrrSgd { get; set; }

    public virtual Survey? SrrSr { get; set; }

    public virtual Visit? SrrVt { get; set; }

    public virtual ICollection<SurveyResultAnswer> SurveyResultAnswers { get; set; } = new List<SurveyResultAnswer>();
}
