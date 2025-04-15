using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2Status
{
    public int SrsId { get; set; }

    public int SrsSrId { get; set; }

    public int SrsCdIdIns { get; set; }

    public virtual Codesc SrsCdIdInsNavigation { get; set; } = null!;

    public virtual Survey2 SrsSr { get; set; } = null!;
}
