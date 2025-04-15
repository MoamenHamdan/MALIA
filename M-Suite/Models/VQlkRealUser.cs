using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkRealUser
{
    public int UsId { get; set; }

    public string? UsSupervisor { get; set; }

    public int? UsThpId { get; set; }

    public string UsCode { get; set; } = null!;

    public string UsFirstName { get; set; } = null!;

    public string SalesRep { get; set; } = null!;

    public string UsLastName { get; set; } = null!;

    public string UsShortName { get; set; } = null!;

    public string UsLogin { get; set; } = null!;

    public short? UsReceiveNotification { get; set; }

    public DateTime? UsExpiryDate { get; set; }

    public short? UsActive { get; set; }

    public short UsDeleted { get; set; }

    public int UsGlId { get; set; }
}
