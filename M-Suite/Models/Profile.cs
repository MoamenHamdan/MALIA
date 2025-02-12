using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Profile
{
    public int PrId { get; set; }

    public string PrCode { get; set; } = null!;

    public string PrDescription { get; set; } = null!;

    public short PrActive { get; set; }

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
