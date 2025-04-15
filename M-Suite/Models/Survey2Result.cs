using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2Result
{
    public int SrrId { get; set; }

    public int? SrrSrId { get; set; }

    public int? SrrVtId { get; set; }

    public int? SrrOrgId { get; set; }

    public int? SrrVtIdOrg { get; set; }

    public int? SrrCdIdSrc { get; set; }

    public DateTime SrrTimeIn { get; set; }

    public DateTime SrrTimeOut { get; set; }

    public string? SrrComment { get; set; }

    public string SrrUid { get; set; } = null!;

    public virtual Survey2? SrrSr { get; set; }

    public virtual Visit? SrrVt { get; set; }

    public virtual ICollection<Survey2ResultAnswer> Survey2ResultAnswers { get; set; } = new List<Survey2ResultAnswer>();
}
