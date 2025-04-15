using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class QlikDashboard
{
    public int QlId { get; set; }

    public string QlAppId { get; set; } = null!;

    public string? QlSheet { get; set; }

    public string? QlObjectId { get; set; }

    public string? QlOption { get; set; }

    public string? QlSelect { get; set; }

    public short? QlIsDefault { get; set; }

    public string QlClientSize { get; set; } = null!;

    public short? QlOrder { get; set; }

    public string? QlCode { get; set; }

    public string? QlDescriptionLan1 { get; set; }

    public string? QlDescriptionLan2 { get; set; }

    public string? QlDescriptionLan3 { get; set; }

    public string? QlTitleLan1 { get; set; }

    public string? QlTitleLan2 { get; set; }

    public string? QlTitleLan3 { get; set; }

    public virtual ICollection<QlikDashboardUser> QlikDashboardUsers { get; set; } = new List<QlikDashboardUser>();
}
