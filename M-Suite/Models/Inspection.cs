using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Inspection
{
    public int InId { get; set; }

    public int? InOrgId { get; set; }

    public int InVtId { get; set; }

    public int InUsId { get; set; }

    public int? InSgdId { get; set; }

    public int? InCdIdType { get; set; }

    public int? InCdIdRemark { get; set; }

    public string? InRemarks { get; set; }

    public DateTime? InIsCreateDate { get; set; }

    public virtual Codesc? InCdIdRemarkNavigation { get; set; }

    public virtual Codesc? InCdIdTypeNavigation { get; set; }

    public virtual User InUs { get; set; } = null!;

    public virtual Visit InVt { get; set; } = null!;

    public virtual ICollection<InspectionList> InspectionLists { get; set; } = new List<InspectionList>();
}
