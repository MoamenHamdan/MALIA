using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2answerDetail
{
    public int SadId { get; set; }

    public int SadSaId { get; set; }

    public int? SadCdIdAnt { get; set; }

    public string? SadCode { get; set; }

    public short? SadOrder { get; set; }

    public string SadDescriptionLan1 { get; set; } = null!;

    public string? SadDescriptionLan3 { get; set; }

    public string? SadDescriptionLan2 { get; set; }

    public short? SadRequired { get; set; }

    public virtual Codesc? SadCdIdAntNavigation { get; set; }

    public virtual Survey2answer SadSa { get; set; } = null!;

    public virtual ICollection<Survey2Question> Survey2Questions { get; set; } = new List<Survey2Question>();

    public virtual ICollection<Survey2ResultAnswerMulti> Survey2ResultAnswerMultis { get; set; } = new List<Survey2ResultAnswerMulti>();

    public virtual ICollection<Survey2ResultAnswer> Survey2ResultAnswers { get; set; } = new List<Survey2ResultAnswer>();
}
