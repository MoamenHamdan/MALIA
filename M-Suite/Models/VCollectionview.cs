using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VCollectionview
{
    public int CvPaId { get; set; }

    public int CvId { get; set; }

    public string? CvThpNameLan1 { get; set; }

    public string? CvThpNameLan2 { get; set; }

    public string? CvThpNameLan3 { get; set; }

    public string? CvDusShortName { get; set; }

    public DateTime CvDiDate { get; set; }

    public decimal? CvPaTotalAmount { get; set; }

    public string? CvCdDescriptionLan1 { get; set; }

    public string? CvCdDescriptionLan2 { get; set; }

    public string? CvCdDescriptionLan3 { get; set; }

    public int? RttRtId { get; set; }

    public string CvPaVoid { get; set; } = null!;

    public string CvPaApproved { get; set; } = null!;

    public int CvPaVoidSmall { get; set; }

    public int CvPaAppSmall { get; set; }

    public string CvNumber { get; set; } = null!;

    public int? CvThpId { get; set; }

    public int? CvUsId { get; set; }
}
