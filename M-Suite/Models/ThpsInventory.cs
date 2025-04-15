using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThpsInventory
{
    public int ThpsiId { get; set; }

    public int? ThpsiOrgId { get; set; }

    public int? ThpsiVtId { get; set; }

    public int? ThpsiThpsId { get; set; }

    public int? ThpsiBuId { get; set; }

    public int? ThpsiTihId { get; set; }

    public int? ThpsiCdIdTivs { get; set; }

    public DateTime? ThpsiCreateDate { get; set; }

    public string ThpsiCode { get; set; } = null!;

    public string? ThpsiDescriptionLan1 { get; set; }

    public string? ThpsiDescriptionLan2 { get; set; }

    public string? ThpsiDescriptionLan3 { get; set; }

    public string? ThpsiUid { get; set; }

    public virtual BusinessUnit? ThpsiBu { get; set; }

    public virtual Codesc? ThpsiCdIdTivsNavigation { get; set; }

    public virtual ThirdpartySite? ThpsiThps { get; set; }

    public virtual ThpsInventoryHeader? ThpsiTih { get; set; }

    public virtual Visit? ThpsiVt { get; set; }
}
