using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ReportSchedule
{
    public int RpsId { get; set; }

    public int? RpsRpId { get; set; }

    public int? RpsDhId { get; set; }

    public short? RpsWeekly { get; set; }

    public short? RpsDaily { get; set; }

    public short? RpsMonthly { get; set; }

    public short? RpsOnce { get; set; }

    public short? RpsActive { get; set; }

    public int? RpsUsIdCreatedby { get; set; }

    public int? RpsUsIdModifiedby { get; set; }

    public DateTime? RpsCreateDate { get; set; }

    public DateTime? RpsModifiedDate { get; set; }

    public virtual DateHelper? RpsDh { get; set; }

    public virtual Report? RpsRp { get; set; }
}
