using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpXxkfmVansalsIntgCustInvLV
{
    public int InventoryHeaderId { get; set; }

    public int? InventoryLineId { get; set; }

    public string? ItemId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public decimal? QtyPiece { get; set; }

    public decimal? QtyBag { get; set; }

    public decimal? QtyBox { get; set; }

    public int ThpsiId { get; set; }

    public int? ThpsiOrgId { get; set; }

    public string? VtVersion { get; set; }
}
