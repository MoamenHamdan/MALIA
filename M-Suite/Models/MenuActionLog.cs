using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MenuActionLog
{
    public int MalId { get; set; }

    public string MalActionCode { get; set; } = null!;

    public int? MalVtId { get; set; }

    public int MalUsId { get; set; }

    public DateTime MalStartDate { get; set; }

    public DateTime? MalEndDate { get; set; }
}
