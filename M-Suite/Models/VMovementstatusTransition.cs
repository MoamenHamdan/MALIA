using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VMovementstatusTransition
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

    public string? MsstMvtCode { get; set; }

    public string? MsstMvtDescriptionLan1 { get; set; }

    public string? MsstMvtDescriptionLan2 { get; set; }

    public string MssFromCode { get; set; } = null!;

    public string MsstFromMssDescriptionLan1 { get; set; } = null!;

    public string MsstFromMssDescriptionLan2 { get; set; } = null!;

    public string MssToCode { get; set; } = null!;

    public string MsstToMssDescriptionLan1 { get; set; } = null!;

    public string MsstToMssDescriptionLan2 { get; set; } = null!;
}
