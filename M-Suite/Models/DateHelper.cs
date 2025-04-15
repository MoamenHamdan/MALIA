using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class DateHelper
{
    public int DhId { get; set; }

    public DateTime DhDate { get; set; }

    public int? DhDay { get; set; }

    public int? DhMonth { get; set; }

    public int? DhYear { get; set; }

    public int? DhDayOfYear { get; set; }

    public int? DhWeek { get; set; }

    public int? DhWeekDay { get; set; }

    public int? DhQuarter { get; set; }

    public string? DhDayInfo { get; set; }

    public string? DhMonthInfo { get; set; }

    public int? DhCalendarWeek { get; set; }

    public virtual ICollection<CallCycleUserHelper> CallCycleUserHelpers { get; set; } = new List<CallCycleUserHelper>();

    public virtual ICollection<ReportSchedule> ReportSchedules { get; set; } = new List<ReportSchedule>();
}
