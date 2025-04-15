using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Itemcontainer
{
    public int IcId { get; set; }

    public string? IcCode { get; set; }

    public string? IcDescriptionLan1 { get; set; }

    public string? IcDescriptionLan2 { get; set; }

    public string? IcDescriptionLan3 { get; set; }

    public short? IcActive { get; set; }

    public virtual ICollection<ItemcontainerDetail> ItemcontainerDetails { get; set; } = new List<ItemcontainerDetail>();

    public virtual ICollection<ItemcontainerThpCategoryValue> ItemcontainerThpCategoryValues { get; set; } = new List<ItemcontainerThpCategoryValue>();

    public virtual ICollection<ThpsItemcontainer> ThpsItemcontainers { get; set; } = new List<ThpsItemcontainer>();
}
