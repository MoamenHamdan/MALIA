using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionConfig
{
    public int TcId { get; set; }

    public int TcTtId { get; set; }

    public int TcOrder { get; set; }

    public int? TcSkipIfEmpty { get; set; }

    public string TcSelecteye { get; set; } = null!;

    public string? TcGridCode { get; set; }

    public string? TcTitle { get; set; }

    public string? TcSearchCriteria { get; set; }

    public short? TcClickable { get; set; }

    public int? TcCdIdReturntype { get; set; }

    public short? TcShowAddToWishlist { get; set; }
}
