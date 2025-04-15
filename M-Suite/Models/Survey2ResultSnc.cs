using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2ResultSnc
{
    public int SSrrId { get; set; }

    public int? SSrrSrId { get; set; }

    public int? SSrrVtId { get; set; }

    public int? SSrrOrgId { get; set; }

    public int? SSrrVtIdOrg { get; set; }

    public int? SSrrCdIdSrc { get; set; }

    public DateTime SSrrTimeIn { get; set; }

    public DateTime SSrrTimeOut { get; set; }

    public string? SSrrComment { get; set; }

    public string SSrrUid { get; set; } = null!;

    public string SSrrVersion { get; set; } = null!;

    public int SSrrUsId { get; set; }

    public string? SSrrVtUid { get; set; }
}
