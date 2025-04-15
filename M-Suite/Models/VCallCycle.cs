using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VCallCycle
{
    public int CcId { get; set; }

    public int? CcUsId { get; set; }

    public DateTime? CcFromDate { get; set; }

    public DateTime? CcToDate { get; set; }

    public short? CcActive { get; set; }

    public string? CcDescription { get; set; }

    public int? CcCdIdCyt { get; set; }

    public string? CcWorkdays { get; set; }

    public short? CcCycleLength { get; set; }

    public string CcCdCode { get; set; } = null!;

    public string? CdDescriptionLan2 { get; set; }

    public string? CdDescriptionLan1 { get; set; }

    public string? CdDescriptionLan3 { get; set; }

    public int? CdNum1 { get; set; }

    public int? CdNum2 { get; set; }

    public string? CdText1 { get; set; }

    public string? CdText2 { get; set; }

    public DateTime? CdDate1 { get; set; }

    public DateTime? CdDate2 { get; set; }

    public string UsCode { get; set; } = null!;

    public string UsFirstName { get; set; } = null!;

    public string UsLastName { get; set; } = null!;

    public string UsShortName { get; set; } = null!;
}
