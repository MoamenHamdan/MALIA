using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MobileProfile
{
    public int MprId { get; set; }

    public short MprActive { get; set; }

    public string MprCode { get; set; } = null!;

    public string MprDescriptionLan1 { get; set; } = null!;

    public string? MprDescriptionLan2 { get; set; }

    public string? MprDescriptionLan3 { get; set; }

    public DateTime MprCreationDate { get; set; }

    public int? MprUsIdCr { get; set; }

    public virtual ICollection<UserMobileProfile> UserMobileProfiles { get; set; } = new List<UserMobileProfile>();
}
