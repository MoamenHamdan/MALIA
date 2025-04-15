using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MobileMenu
{
    public int MmId { get; set; }

    public int? MmMmId { get; set; }

    public int? MmOrder { get; set; }

    public short? MmLevel { get; set; }

    public string MmDescription { get; set; } = null!;

    public string MmActionCode { get; set; } = null!;

    public string? MmCommand { get; set; }

    public string? MmClass { get; set; }

    public string? MmIcon { get; set; }

    public int? MmTextSize { get; set; }

    public string? MmIconAlign { get; set; }

    public int? MmHeight { get; set; }

    public int? MmWidth { get; set; }

    public string? MmBackgroundStyle { get; set; }

    public short MmIsAction { get; set; }

    public short? MmActive { get; set; }

    public string? MmParameters { get; set; }

    public string? MmSession { get; set; }

    public string? MmTextStyle { get; set; }

    public string? MmGridCode { get; set; }

    public string? MmSelecteyeCode { get; set; }

    public int? MmUsrId { get; set; }

    public string? MmGroup { get; set; }

    public string? MmTitleLan1 { get; set; }

    public string? MmTitleLan2 { get; set; }

    public string? MmTitleLan3 { get; set; }

    public string? MmDetailsLan1 { get; set; }

    public string? MmDetailsLan2 { get; set; }

    public string? MmDetailsLan3 { get; set; }

    public virtual ICollection<MobilemenusProfile> MobilemenusProfiles { get; set; } = new List<MobilemenusProfile>();
}
