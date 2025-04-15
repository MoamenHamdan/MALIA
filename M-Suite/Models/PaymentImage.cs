using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PaymentImage
{
    public int PaimId { get; set; }

    public int? PaimPaId { get; set; }

    public string? PaimImage { get; set; }

    public int? PaimOrder { get; set; }

    public int? PaimOrgId { get; set; }

    public DateTime? PaimCreationDate { get; set; }

    public virtual Payment? PaimPa { get; set; }
}
