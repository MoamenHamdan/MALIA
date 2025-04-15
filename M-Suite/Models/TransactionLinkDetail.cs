using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionLinkDetail
{
    public int? OrdUsId { get; set; }

    public int OrdTsId { get; set; }

    public string OrdTsNumber { get; set; } = null!;

    public int? DlvUsId { get; set; }

    public int DlvTsId { get; set; }

    public string DlvTsNumber { get; set; } = null!;

    public int InvTsId { get; set; }

    public int? InvUsId { get; set; }

    public string InvTsNumber { get; set; } = null!;

    public DateTime OrdTsDate { get; set; }

    public decimal OrdTsTotal { get; set; }

    public DateTime DlvTsDate { get; set; }

    public decimal DlvTsTotal { get; set; }

    public DateTime InvTsDate { get; set; }

    public decimal InvTsTotal { get; set; }

    public int TslId { get; set; }
}
