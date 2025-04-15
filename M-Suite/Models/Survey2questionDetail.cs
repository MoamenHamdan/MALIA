using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2questionDetail
{
    public int SrqdId { get; set; }

    public int SrqdSrqId { get; set; }

    public int? SrqdCdIdFrq { get; set; }

    public DateTime SrqdDateFrom { get; set; }

    public DateTime SrqdDateTo { get; set; }

    public short SrqdStatus { get; set; }

    public int? SrqdOccurence { get; set; }

    public int? SrqdUsId { get; set; }

    public int? SrqdSrdId { get; set; }

    public virtual Survey2Question SrqdSrq { get; set; } = null!;

    public virtual ICollection<Survey2ResultAnswer> Survey2ResultAnswers { get; set; } = new List<Survey2ResultAnswer>();
}
