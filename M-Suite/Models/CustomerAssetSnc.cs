using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CustomerAssetSnc
{
    public int SCaId { get; set; }

    public int? SCaCuId { get; set; }

    public int? SCaQuantity { get; set; }

    public string? SCaDescription { get; set; }

    public string? SCaSerialNb { get; set; }

    public string? SCaStatus { get; set; }

    public int? SCaIsModified { get; set; }

    public int? SCaIsCreated { get; set; }

    public string SCaVersion { get; set; } = null!;

    public string SCaSmId { get; set; } = null!;
}
