using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class NoDeliveryReasonSnc
{
    public int SNdrId { get; set; }

    public int? SNdrVtId { get; set; }

    public int SNdrDvId { get; set; }

    public int? SNdrCdIdNdr { get; set; }

    public string? SNdrNotes { get; set; }

    public DateTime? SNdrCreationDate { get; set; }

    public int SNdrUsId { get; set; }

    public int? SNdrSynched { get; set; }

    public string SNdrVersion { get; set; } = null!;

    public int SNdrSmId { get; set; }
}
