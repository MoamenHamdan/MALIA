using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Module
{
    public int MdId { get; set; }

    public string MdCode { get; set; } = null!;

    public string MdDescription { get; set; } = null!;

    public virtual ICollection<AppliSetting> AppliSettings { get; set; } = new List<AppliSetting>();

    public virtual ICollection<Codesc> Codescs { get; set; } = new List<Codesc>();

    public virtual ICollection<DynamicQuery> DynamicQueries { get; set; } = new List<DynamicQuery>();

    public virtual ICollection<FamilyCodesc> FamilyCodescs { get; set; } = new List<FamilyCodesc>();

    public virtual ICollection<PhysicalLocation> PhysicalLocations { get; set; } = new List<PhysicalLocation>();
}
