using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartyAdditionalInfo
{
    public int ThpiId { get; set; }

    public int ThpiThpId { get; set; }

    public int? ThpiGlId { get; set; }

    public string? ThpiLongitude { get; set; }

    public string? ThpiLatitude { get; set; }

    public string? ThpiPhone { get; set; }

    public string? ThpiMobile { get; set; }

    public string? ThpiEmail { get; set; }

    public string? ThpiWebsite { get; set; }

    public string? ThpiFax { get; set; }

    public string? ThpiRemarks { get; set; }

    public virtual GeoLocation? ThpiGl { get; set; }

    public virtual Thirdparty ThpiThp { get; set; } = null!;
}
