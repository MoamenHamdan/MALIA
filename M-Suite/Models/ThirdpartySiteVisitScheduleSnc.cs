using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartySiteVisitScheduleSnc
{
    public int SThpsvsId { get; set; }

    public int SThpsvsCdIdTmsd { get; set; }

    public int SThpsvsCdIdTms { get; set; }

    public string? SThpsvsComments { get; set; }

    public int SThpsvsUsIdCr { get; set; }

    public DateTime SThpsvsCreationDate { get; set; }

    public int SThpsvsSmId { get; set; }

    public string SThpsvsVersion { get; set; } = null!;

    public string SThpsvsThpsUid { get; set; } = null!;
}
