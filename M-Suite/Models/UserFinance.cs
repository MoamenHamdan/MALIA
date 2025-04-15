using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserFinance
{
    public int UsfId { get; set; }

    public int UsfUsId { get; set; }

    public int UsfUbuId { get; set; }

    public int? UsfCdIdCur { get; set; }

    public decimal? UsfBalance { get; set; }

    public decimal? UsfCreditLimit { get; set; }

    public short? UsfIsRecursive { get; set; }

    public virtual Codesc? UsfCdIdCurNavigation { get; set; }

    public virtual UserBusinessUnit UsfUbu { get; set; } = null!;

    public virtual User UsfUs { get; set; } = null!;
}
