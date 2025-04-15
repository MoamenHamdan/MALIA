using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UsersCalendar
{
    public int UcId { get; set; }

    public int UcUsrId { get; set; }

    public DateTime UcDate { get; set; }

    public int? UcCdIdCt { get; set; }

    public short? UcWp1 { get; set; }

    public short? UcWp2 { get; set; }

    public short? UcWp3 { get; set; }

    public short? UcWp4 { get; set; }

    public string? UcComments { get; set; }

    public virtual Codesc? UcCdIdCtNavigation { get; set; }

    public virtual User UcUsr { get; set; } = null!;
}
