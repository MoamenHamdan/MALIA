using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VCollectionviewReport
{
    public int CvPaId { get; set; }

    public string? CvThpCode { get; set; }

    public string? CvThpNameLan1 { get; set; }

    public string? CvThpNameLan2 { get; set; }

    public string? CvThpNameLan3 { get; set; }

    public string CvDusShortName { get; set; } = null!;

    public DateTime CvDiDate { get; set; }

    public decimal CvPaTotalAmount { get; set; }

    public string? CvCdDescriptionLan1 { get; set; }

    public string? CvCdDescriptionLan2 { get; set; }

    public string? CvCdDescriptionLan3 { get; set; }

    public string CvCdCode { get; set; } = null!;

    public short? CvPaVoidSmall { get; set; }

    public short? CvPaAppSmall { get; set; }

    public string CvPaVoid { get; set; } = null!;

    public string CvPaApproved { get; set; } = null!;

    public string CvNumber { get; set; } = null!;

    public int? CvThpId { get; set; }

    public int CvDepartmentId { get; set; }

    public string CvDepartment1 { get; set; } = null!;

    public string? CvDepartment2 { get; set; }

    public string? CvDepartment3 { get; set; }

    public int? CvPaType { get; set; }

    public string? CvPaTypeDesc1 { get; set; }

    public string? CvPaTypeDesc2 { get; set; }

    public string? CvPaTypeDesc3 { get; set; }

    public int CvUsId { get; set; }

    public string? PadCcNumber { get; set; }

    public DateTime? PadCcDate { get; set; }

    public string? CdDescriptionLan1 { get; set; }

    public string? CdDescriptionLan2 { get; set; }

    public string? CdDescriptionLan3 { get; set; }

    public int CvCdId { get; set; }

    public string? ThpmCdDescriptionLan1 { get; set; }

    public string? ThpmCdDescriptionLan2 { get; set; }

    public string? ThpmCdDescriptionLan3 { get; set; }

    public int? CvPsId { get; set; }

    public string? CvStatus1 { get; set; }

    public string? CvStatus2 { get; set; }

    public string? CvStatus3 { get; set; }
}
