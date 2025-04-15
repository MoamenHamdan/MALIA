using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpThirdpartyV
{
    public int? IThpId { get; set; }

    public string? IThpCode { get; set; }

    public int IThpCdIdTpg { get; set; }

    public int IThpCdIdTps { get; set; }

    public string? IThpNameLan1 { get; set; }

    public string? IThpNameLan2 { get; set; }

    public string? IThpNameLan3 { get; set; }

    public string IThpImpUid { get; set; } = null!;

    public short IThpIsCustomer { get; set; }

    public short IThpIsSupplier { get; set; }

    public short IThpIsCompany { get; set; }

    public DateTime? IThpCreateDate { get; set; }

    public DateTime IThpModifiedDate { get; set; }
}
