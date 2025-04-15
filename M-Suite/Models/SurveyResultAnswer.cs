using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SurveyResultAnswer
{
    public int SraId { get; set; }

    public int? SraIdOrg { get; set; }

    public int? SraSrrIdOrg { get; set; }

    public int? SraSrrId { get; set; }

    public int? SraSrqId { get; set; }

    public int? SraSadId { get; set; }

    public string? SraFreeText { get; set; }

    public DateTime? SraDatetime { get; set; }

    public short? SraOrder { get; set; }

    public virtual SurveyanswerDetail? SraSad { get; set; }

    public virtual SurveyQuestion? SraSrq { get; set; }

    public virtual SurveyResult? SraSrr { get; set; }
}
