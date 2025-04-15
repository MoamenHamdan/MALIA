using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkCallcycle
{
    public int CcId { get; set; }

    public int VtCcdId { get; set; }

    public int? CcdCdIdVst { get; set; }

    public int? CcdThpsId { get; set; }

    public DateTime? CcdPlannedVisitDate { get; set; }

    public DateTime? CcdActualVisitDate { get; set; }

    public int? CcdOrder { get; set; }

    public string VstCode { get; set; } = null!;

    public string? VstDescriptionLan1 { get; set; }

    public string? VstDescriptionLan2 { get; set; }

    public string? VstDescriptionLan3 { get; set; }

    public int? CcdPlannedYear { get; set; }

    public int? CcdPlannedMonth { get; set; }

    public int? CcdPlannedDay { get; set; }

    public int? CcdActualYear { get; set; }

    public int? CcdActualMonth { get; set; }

    public int? CcdActualDay { get; set; }

    public int? CcdPlannedVisitDateNum { get; set; }

    public int? CcdActualVisitDateNum { get; set; }

    public int? CcUsId { get; set; }

    public DateTime? CcFromDate { get; set; }

    public DateTime? CcToDate { get; set; }

    public short? CcActive { get; set; }

    public string? CcDescription { get; set; }

    public string? CcWorkdays { get; set; }

    public short? CcCycleLength { get; set; }

    public short? CcAutorenew { get; set; }

    public string CytCode { get; set; } = null!;

    public string? CytDescriptionLan1 { get; set; }

    public string? CytDescriptionLan2 { get; set; }

    public string? CytDescriptionLan3 { get; set; }

    public int? CcFromYear { get; set; }

    public int? CcFromMonth { get; set; }

    public int? CcFromDay { get; set; }

    public int? CcToYear { get; set; }

    public int? CcToMonth { get; set; }

    public int? CcToDay { get; set; }

    public string? ThpsUs { get; set; }

    public int CcdActualVisit { get; set; }
}
