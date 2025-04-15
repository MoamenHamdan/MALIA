using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2ResultAnswer
{
    public int SraId { get; set; }

    public int SraSrrId { get; set; }

    public int SraSrqdId { get; set; }

    public int? SraSadId { get; set; }

    public int? SraIdOrg { get; set; }

    public int? SraSrrIdOrg { get; set; }

    public string? SraFreeText { get; set; }

    public DateTime? SraDatetime { get; set; }

    public short? SraOrder { get; set; }

    public string? SraComments { get; set; }

    public virtual Survey2answerDetail? SraSad { get; set; }

    public virtual Survey2questionDetail SraSrqd { get; set; } = null!;

    public virtual Survey2Result SraSrr { get; set; } = null!;

    public virtual ICollection<Survey2ResultAnswerMulti> Survey2ResultAnswerMultis { get; set; } = new List<Survey2ResultAnswerMulti>();

    public virtual ICollection<Survey2exeanswerImage> Survey2exeanswerImages { get; set; } = new List<Survey2exeanswerImage>();
}
