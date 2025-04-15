using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemcategoryFamilyValueBrand
{
    public int? IIcfvId { get; set; }

    public int IIcfId { get; set; }

    public string IBrCode { get; set; } = null!;

    public string? IBrDescription { get; set; }

    public string? IBrDescriptionAr { get; set; }
}
