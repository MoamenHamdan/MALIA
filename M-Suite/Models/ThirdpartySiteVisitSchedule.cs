using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartySiteVisitSchedule
{
    public int ThpsvsId { get; set; }

    public int ThpsvsThpsId { get; set; }

    public int ThpsvsCdIdTmsd { get; set; }

    public int ThpsvsCdIdTms { get; set; }

    public string? ThpsvsComments { get; set; }

    public int ThpsvsUsIdCr { get; set; }

    public DateTime ThpsvsCreationDate { get; set; }

    public virtual Codesc ThpsvsCdIdTmsNavigation { get; set; } = null!;

    public virtual Codesc ThpsvsCdIdTmsdNavigation { get; set; } = null!;

    public virtual ThirdpartySite ThpsvsThps { get; set; } = null!;

    public virtual User ThpsvsUsIdCrNavigation { get; set; } = null!;
}
