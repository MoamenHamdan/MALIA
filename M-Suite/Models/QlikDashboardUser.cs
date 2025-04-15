using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class QlikDashboardUser
{
    public int QluId { get; set; }

    public int QluQlId { get; set; }

    public int? QluUsIs { get; set; }

    public int? QluPrId { get; set; }

    public short? QluActive { get; set; }

    public DateTime? QluExpiryDate { get; set; }

    public DateTime? QluEffectiveDate { get; set; }

    public string? QluOption { get; set; }

    public short? QluIsDefault { get; set; }

    public short? QluOrder { get; set; }

    public virtual Profile? QluPr { get; set; }

    public virtual QlikDashboard QluQl { get; set; } = null!;

    public virtual User? QluUsIsNavigation { get; set; }
}
