using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2answer
{
    public int SaId { get; set; }

    public int SaCdIdAnt { get; set; }

    public string? SaCode { get; set; }

    public string SaDescriptionLan1 { get; set; } = null!;

    public string? SaDescriptionLan2 { get; set; }

    public string? SaDescriptionLan3 { get; set; }

    public virtual Codesc SaCdIdAntNavigation { get; set; } = null!;

    public virtual ICollection<Survey2Question> Survey2Questions { get; set; } = new List<Survey2Question>();

    public virtual ICollection<Survey2answerDetail> Survey2answerDetails { get; set; } = new List<Survey2answerDetail>();
}
