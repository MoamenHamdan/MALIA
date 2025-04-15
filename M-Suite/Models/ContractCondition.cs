using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ContractCondition
{
    public int CncId { get; set; }

    public int CncCnId { get; set; }

    public int CncSrId { get; set; }

    public int CncCdIdResp { get; set; }

    public virtual Contract CncCn { get; set; } = null!;

    public virtual Survey2 CncSr { get; set; } = null!;
}
