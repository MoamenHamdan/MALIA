using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VUserWarehouseRole
{
    public string UwrUsCode { get; set; } = null!;

    public string UwrUsShortName { get; set; } = null!;

    public string UwrPrCode { get; set; } = null!;

    public string UwrPrDescription { get; set; } = null!;

    public string UwrPlCode { get; set; } = null!;

    public string UwrPlDescriptionLan1 { get; set; } = null!;

    public short UwrIsDefault { get; set; }

    public int UwrUsId { get; set; }

    public int UwrPrId { get; set; }

    public int UwrPlId { get; set; }
}
