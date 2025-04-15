using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CallCycleDetail
{
    public int CcdId { get; set; }

    public int? CcdCcId { get; set; }

    public int? CcdCdIdVst { get; set; }

    public int? CcdThpsId { get; set; }

    public DateTime? CcdPlannedVisitDate { get; set; }

    public DateTime? CcdActualVisitDate { get; set; }

    public int? CcdOrder { get; set; }

    public virtual CallCycle? CcdCc { get; set; }

    public virtual Codesc? CcdCdIdVstNavigation { get; set; }

    public virtual ThirdpartySite? CcdThps { get; set; }

    public virtual ICollection<Visit> Visits { get; set; } = new List<Visit>();
}
