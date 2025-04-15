using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpUsersV
{
    public string IUsCode { get; set; } = null!;

    public string? IUsFirstName { get; set; }

    public string? IUsLastName { get; set; }

    public string? IUsShortName { get; set; }

    public string IUsLogin { get; set; } = null!;

    public string IUsPassword { get; set; } = null!;

    public string IUsEmail { get; set; } = null!;

    public int IUsReceiveNotification { get; set; }

    public DateTime? IUsExpiryDate { get; set; }

    public int? IUsId { get; set; }

    public int IUsActive { get; set; }

    public int? IUsDeleted { get; set; }

    public int? IUsDbUser { get; set; }
}
