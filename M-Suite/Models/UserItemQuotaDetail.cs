using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserItemQuotaDetail
{
    public int UiqdId { get; set; }

    public int? UiqdUiqId { get; set; }

    public int? UiqdItId { get; set; }

    public decimal? UiqdQuotaQtySku { get; set; }

    public decimal? UiqdUsedQtySku { get; set; }

    public decimal? UiqdRemQtySku { get; set; }

    public virtual Item? UiqdIt { get; set; }

    public virtual UserItemQuotum? UiqdUiq { get; set; }
}
