using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ApprovalConfig
{
    public int AcId { get; set; }

    public int AcBuId { get; set; }

    public int AcUsId { get; set; }

    public int AcCdIdArtd { get; set; }

    public short? AcSupervisor { get; set; }

    public int AcUsIdCr { get; set; }

    public DateTime? AcCreationDate { get; set; }

    public short? AcActive { get; set; }

    public virtual BusinessUnit AcBu { get; set; } = null!;

    public virtual Codesc AcCdIdArtdNavigation { get; set; } = null!;

    public virtual User AcUs { get; set; } = null!;

    public virtual User AcUsIdCrNavigation { get; set; } = null!;

    public virtual ICollection<ApprovalconfigMember> ApprovalconfigMembers { get; set; } = new List<ApprovalconfigMember>();
}
