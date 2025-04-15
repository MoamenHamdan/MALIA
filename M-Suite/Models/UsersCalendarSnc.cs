using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UsersCalendarSnc
{
    public int SUcId { get; set; }

    public int SUcUsrId { get; set; }

    public DateTime SUcDate { get; set; }

    public int? SUcCdIdCt { get; set; }

    public short? SUcWp1 { get; set; }

    public short? SUcWp2 { get; set; }

    public short? SUcWp3 { get; set; }

    public short? SUcWp4 { get; set; }

    public string? SUcComments { get; set; }

    public string SUcVersion { get; set; } = null!;

    public int SUcSmId { get; set; }
}
