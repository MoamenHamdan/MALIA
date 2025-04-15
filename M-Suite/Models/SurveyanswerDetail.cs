using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SurveyanswerDetail
{
    public int SadId { get; set; }

    public int SadSaId { get; set; }

    public short? SadOrder { get; set; }

    public string? SadDescriptionLan1 { get; set; }

    public string? SadDescriptionLan3 { get; set; }

    public string? SadDescriptionLan2 { get; set; }

    public string SadCode { get; set; } = null!;

    public virtual Surveyanswer SadSa { get; set; } = null!;

    public virtual ICollection<SurveyResultAnswer> SurveyResultAnswers { get; set; } = new List<SurveyResultAnswer>();
}
