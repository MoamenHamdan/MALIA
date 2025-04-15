using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserItemQuotaAllV
{
    public int UiqId { get; set; }

    public int UiqUiqId { get; set; }

    public int UiqUsId { get; set; }

    public string UiqDescription { get; set; } = null!;

    public DateTime UiqFromDate { get; set; }

    public DateTime UiqToDate { get; set; }

    public int? UiqPrId { get; set; }

    public decimal? UiqUsedQtySku { get; set; }

    public decimal? UiqQuotaQtySku { get; set; }

    public decimal? UiqRemQtySku { get; set; }
}
