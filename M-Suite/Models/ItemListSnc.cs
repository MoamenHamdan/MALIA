using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemListSnc
{
    public int SItlId { get; set; }

    public int SItlCdIdItlt { get; set; }

    public int? SItlThpsId { get; set; }

    public int SItlSmId { get; set; }

    public int? SItlVtId { get; set; }

    public int? SItlBuId { get; set; }

    public string SItlCode { get; set; } = null!;

    public string SItlDescriptionLan1 { get; set; } = null!;

    public string? SItlDescriptionLan2 { get; set; }

    public string? SItlDescriptionLan3 { get; set; }

    public DateTime? SItlStartDate { get; set; }

    public DateTime? SItlEndDate { get; set; }

    public DateTime SItlCreationDate { get; set; }

    public int? SItlCdIdItls { get; set; }

    public string SItlVersion { get; set; } = null!;

    public string? SItlVtUid { get; set; }
}
