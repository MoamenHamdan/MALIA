using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2ResultAnswerSnc
{
    public int SSraId { get; set; }

    public int SSraSrrId { get; set; }

    public int SSraSrqdId { get; set; }

    public int? SSraSadId { get; set; }

    public int? SSraIdOrg { get; set; }

    public int? SSraSrrIdOrg { get; set; }

    public string? SSraFreeText { get; set; }

    public DateTime? SSraDatetime { get; set; }

    public short? SSraOrder { get; set; }

    public string? SSraComments { get; set; }

    public string SSraVersion { get; set; } = null!;

    public int SSraUsId { get; set; }

    public string? SSraSrrUid { get; set; }
}
