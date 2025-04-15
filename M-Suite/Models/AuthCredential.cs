using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class AuthCredential
{
    public int OcId { get; set; }

    public string OcLogin { get; set; } = null!;

    public string OcPassword { get; set; } = null!;

    public DateTime OcExpiryDate { get; set; }

    public int? OcActive { get; set; }
}
