using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PaymentImagesSnc
{
    public int SPaimId { get; set; }

    public int? SPaimPaId { get; set; }

    public string? SPaimImage { get; set; }

    public int? SPaimOrder { get; set; }

    public DateTime? SPaimCreationDate { get; set; }

    public int SPaimUsId { get; set; }

    public string SPaimVersion { get; set; } = null!;

    public int? SPaimSynched { get; set; }

    public string? SPaimPaUid { get; set; }
}
