using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class AppliSetting
{
    public int AsId { get; set; }

    public int? AsCdIdSrc { get; set; }

    public int AsMdId { get; set; }

    public string AsGroup { get; set; } = null!;

    public string AsCode { get; set; } = null!;

    public string AsDescription { get; set; } = null!;

    public string AsValue { get; set; } = null!;

    public string AsValueType { get; set; } = null!;

    public short? AsSystem { get; set; }

    public virtual Codesc? AsCdIdSrcNavigation { get; set; }

    public virtual Module AsMd { get; set; } = null!;

    public virtual ICollection<BusinessunitApplisetting> BusinessunitApplisettings { get; set; } = new List<BusinessunitApplisetting>();

    public virtual ICollection<ProfileAppliSetting> ProfileAppliSettings { get; set; } = new List<ProfileAppliSetting>();

    public virtual ICollection<UserAppliSetting> UserAppliSettings { get; set; } = new List<UserAppliSetting>();
}
