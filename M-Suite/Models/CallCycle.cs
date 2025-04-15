using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CallCycle
{
    public int CcId { get; set; }

    public int? CcUsId { get; set; }

    public int? CcCdIdCyt { get; set; }

    public DateTime? CcFromDate { get; set; }

    public DateTime? CcToDate { get; set; }

    public short? CcActive { get; set; }

    public string? CcDescription { get; set; }

    public string? CcWorkdays { get; set; }

    public short? CcCycleLength { get; set; }

    public short? CcAutorenew { get; set; }

    public virtual ICollection<CallCycleDetail> CallCycleDetails { get; set; } = new List<CallCycleDetail>();

    public virtual Codesc? CcCdIdCytNavigation { get; set; }

    public virtual User? CcUs { get; set; }
}
