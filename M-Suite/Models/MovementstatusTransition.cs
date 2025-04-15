using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementstatusTransition
{
    public int MsstId { get; set; }

    public int MsstMvtId { get; set; }

    public int MsstMssIdFrom { get; set; }

    public int MsstMssIdTo { get; set; }

    public short MsstMvUsIsOwner { get; set; }

    public short MsstMvPlFromIsOwner { get; set; }

    public short MsstMvPlToIsOwner { get; set; }

    public short MsstUpdateQuantityFrom { get; set; }

    public short MsstUpdateQuantityTo { get; set; }

    public short MsstReserveQuantityFrom { get; set; }

    public short MsstReserveQuantityTo { get; set; }

    public short MsstCheckAvailabilityFrom { get; set; }

    public short MsstCheckAvailabilityTo { get; set; }

    public short? MsstMvtIdSource { get; set; }

    public short? MsstAutoCreateFromSource { get; set; }

    public short MsstLxpRequired { get; set; }

    public string? MsstExtraCode { get; set; }

    public short MsstAutoAllocateLxp { get; set; }

    public short MsstExportData { get; set; }

    public int? MsstMvtIdGenerate { get; set; }

    public int? MsstMssIdGenerate { get; set; }

    public virtual ICollection<MovementstatusTransitionBu> MovementstatusTransitionBus { get; set; } = new List<MovementstatusTransitionBu>();

    public virtual ICollection<MovementstatusTransitionProfile> MovementstatusTransitionProfiles { get; set; } = new List<MovementstatusTransitionProfile>();

    public virtual Movementstatus MsstMssIdFromNavigation { get; set; } = null!;

    public virtual Movementstatus? MsstMssIdGenerateNavigation { get; set; }

    public virtual Movementstatus MsstMssIdToNavigation { get; set; } = null!;

    public virtual Movementtype1 MsstMvt { get; set; } = null!;

    public virtual Movementtype1? MsstMvtIdGenerateNavigation { get; set; }
}
