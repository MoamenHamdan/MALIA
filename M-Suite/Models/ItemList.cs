using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemList
{
    public int ItlId { get; set; }

    public int ItlCdIdItlt { get; set; }

    public int? ItlThpsId { get; set; }

    public int ItlUsId { get; set; }

    public int? ItlVtId { get; set; }

    public int? ItlBuId { get; set; }

    public string ItlCode { get; set; } = null!;

    public string ItlDescriptionLan1 { get; set; } = null!;

    public string? ItlDescriptionLan2 { get; set; }

    public string? ItlDescriptionLan3 { get; set; }

    public DateTime? ItlStartDate { get; set; }

    public DateTime? ItlEndDate { get; set; }

    public DateTime ItlCreationDate { get; set; }

    public int? ItlCdIdItls { get; set; }

    public int? ItlOrgId { get; set; }

    public int? ItlPrId { get; set; }
}
