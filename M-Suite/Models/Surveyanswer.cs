using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Surveyanswer
{
    public int SaId { get; set; }

    public int? SaCdIdAnt { get; set; }

    public string? SaDescriptionLan1 { get; set; }

    public string? SaDescriptionLan2 { get; set; }

    public string? SaDescriptionLan3 { get; set; }

    public string SaCode { get; set; } = null!;

    public virtual Codesc? SaCdIdAntNavigation { get; set; }

    public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; } = new List<SurveyQuestion>();

    public virtual ICollection<SurveyanswerDetail> SurveyanswerDetails { get; set; } = new List<SurveyanswerDetail>();
}
