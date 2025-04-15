using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VPromotionPreselectionBuy
{
    public int PndScenario { get; set; }

    public string? PndGroup { get; set; }

    public string? PndSubgroup { get; set; }

    public int PndSubgroupCount { get; set; }

    public int PndId { get; set; }

    public int PnlId { get; set; }

    public string? PpmDescription { get; set; }

    public string PndCode { get; set; } = null!;

    public string PndDescription { get; set; } = null!;

    public decimal? PndBuyFrom { get; set; }

    public decimal? PndBuyTo { get; set; }

    public decimal PndForeach { get; set; }

    public string CdCode { get; set; } = null!;

    public int PndItId { get; set; }
}
