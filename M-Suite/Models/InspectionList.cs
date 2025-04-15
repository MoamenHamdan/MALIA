using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InspectionList
{
    public int IlId { get; set; }

    public int? IlOrgId { get; set; }

    public int IlInId { get; set; }

    public int IlSrId { get; set; }

    public int? IlCdIdRemark { get; set; }

    public string? IlRemarks { get; set; }

    public DateTime? IlCreateDate { get; set; }

    public short? IlScanned { get; set; }

    public virtual Codesc? IlCdIdRemarkNavigation { get; set; }

    public virtual Inspection IlIn { get; set; } = null!;

    public virtual Survey IlSr { get; set; } = null!;

    public virtual ICollection<InspectionSurvey> InspectionSurveys { get; set; } = new List<InspectionSurvey>();
}
