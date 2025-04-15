using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class UserConnectionInfo
{
    public int UciId { get; set; }

    public int UciUsId { get; set; }

    public DateTime? UciFirstLoginDate { get; set; }

    public DateTime? UciLastLoginDate { get; set; }

    public int? UciSuccessfullLoginCount { get; set; }

    public int? UciFailedLoginCount { get; set; }

    public DateTime? UciLastLogoutDate { get; set; }

    public int? UciCdIdLang { get; set; }

    public short? UciIsOnline { get; set; }

    public short? UciConcurrentUsers { get; set; }

    public DateTime? UciLastFailedLoginDate { get; set; }

    public short? UciIsLocked { get; set; }

    public virtual User UciUs { get; set; } = null!;
}
