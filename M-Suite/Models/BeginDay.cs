using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class BeginDay
{
    public int BdId { get; set; }

    public int? BdOrgId { get; set; }

    public int BdUsId { get; set; }

    public int? BdCdIdSrc { get; set; }

    public DateTime BdDate { get; set; }

    public string? BdOdometer { get; set; }

    public string? BdLatitude { get; set; }

    public string? BdLongitude { get; set; }

    public string? BdNotes { get; set; }

    public string? BdEndOdometer { get; set; }

    public string? BdEndLatitude { get; set; }

    public string? BdEndLongitude { get; set; }

    public DateTime? BdEndDate { get; set; }

    public string? BdEndNotes { get; set; }

    public virtual Codesc? BdCdIdSrcNavigation { get; set; }

    public virtual User BdUs { get; set; } = null!;

    public virtual ICollection<PhysicalLocationOdometer> PhysicalLocationOdometers { get; set; } = new List<PhysicalLocationOdometer>();
}
