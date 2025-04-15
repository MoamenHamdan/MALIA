using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionItemPlu
{
    public int TsipId { get; set; }

    public int TsipTsId { get; set; }

    public int TsipTsiId { get; set; }

    public string? TsipAttribut01 { get; set; }

    public string? TsipAttribut02 { get; set; }

    public string? TsipAttribut03 { get; set; }
}
