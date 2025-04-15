using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VCallCycleDetail
{
    public int? CcdThpsId { get; set; }

    public int? CcdUsId { get; set; }

    public DateTime? CcdPlannedVisitDate { get; set; }

    public DateTime? CcdActualVisitDate { get; set; }
}
