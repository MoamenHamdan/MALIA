using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemcategoryValueLink
{
    public int IclId { get; set; }

    public int? IclIcfvIdParent { get; set; }

    public int IclIcfvIdChild { get; set; }

    public virtual ItemcategoryFamilyValue IclIcfvIdChildNavigation { get; set; } = null!;

    public virtual ItemcategoryFamilyValue? IclIcfvIdParentNavigation { get; set; }
}
