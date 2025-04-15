using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartycategoryFamily
{
    public int ThcfId { get; set; }

    public int? ThcfThcfId { get; set; }

    public int? ThcfBuId { get; set; }

    public short ThcfLevel { get; set; }

    public string ThcfCode { get; set; } = null!;

    public string ThcfDescriptionLan1 { get; set; } = null!;

    public string ThcfDescriptionLan2 { get; set; } = null!;

    public string ThcfDescriptionLan3 { get; set; } = null!;

    public short ThcfCalculated { get; set; }

    public virtual ICollection<ThirdpartyGroupCategory> ThirdpartyGroupCategories { get; set; } = new List<ThirdpartyGroupCategory>();

    public virtual ICollection<ThirdpartycategoryFamilyValue> ThirdpartycategoryFamilyValues { get; set; } = new List<ThirdpartycategoryFamilyValue>();

    public virtual ICollection<ThirdpartycategoryValue> ThirdpartycategoryValues { get; set; } = new List<ThirdpartycategoryValue>();

    public virtual ICollection<ThirdpartysitecategoryValue> ThirdpartysitecategoryValues { get; set; } = new List<ThirdpartysitecategoryValue>();
}
