using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VUserProfile
{
    public int UspUsId { get; set; }

    public string UspUsCode { get; set; } = null!;

    public string UspUsShortName { get; set; } = null!;

    public int UspPrId { get; set; }

    public string UspPrCode { get; set; } = null!;

    public string UspPrDescription { get; set; } = null!;

    public string UspBuCode { get; set; } = null!;

    public string UspBuDescription { get; set; } = null!;
}
