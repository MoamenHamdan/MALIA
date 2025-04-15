using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartycategoryFamilyValue
{
    public int ThcfvId { get; set; }

    public int? ThcfvThcfId { get; set; }

    public string ThcfvCode { get; set; } = null!;

    public string? ThcfvDescriptionLan1 { get; set; }

    public string? ThcfvDescriptionLan2 { get; set; }

    public string? ThcfvDescriptionLan3 { get; set; }

    public virtual ICollection<ItemcontainerThpCategoryValue> ItemcontainerThpCategoryValues { get; set; } = new List<ItemcontainerThpCategoryValue>();

    public virtual ThirdpartycategoryFamily? ThcfvThcf { get; set; }

    public virtual ICollection<ThirdpartycategoryValue> ThirdpartycategoryValues { get; set; } = new List<ThirdpartycategoryValue>();

    public virtual ICollection<ThirdpartysitecategoryValue> ThirdpartysitecategoryValues { get; set; } = new List<ThirdpartysitecategoryValue>();
}
