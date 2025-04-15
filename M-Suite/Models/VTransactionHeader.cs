using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VTransactionHeader
{
    public int TsId { get; set; }

    public string Currencycode { get; set; } = null!;

    public string CustAccount { get; set; } = null!;

    public DateOnly? ShDate { get; set; }

    public string SalesId { get; set; } = null!;
}
