using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class AppMedium
{
    public int MedId { get; set; }

    public int? MedOrgId { get; set; }

    public string MedName { get; set; } = null!;

    public int MedCdIdMedref { get; set; }

    public int MedCdIdMedtype { get; set; }

    public int MedUsId { get; set; }

    public DateTime MedDatetime { get; set; }

    public string? MedLatitude { get; set; }

    public string? MedLongitude { get; set; }

    public int MedFkValue { get; set; }

    public string? MedDevicePath { get; set; }

    public string? MedServerPath { get; set; }

    public int? MedOrder { get; set; }

    public short? MedActive { get; set; }

    public string? MedText1 { get; set; }

    public string? MedText2 { get; set; }

    public decimal? MedNum1 { get; set; }

    public decimal? MedNum2 { get; set; }

    public virtual Codesc MedCdIdMedrefNavigation { get; set; } = null!;

    public virtual User MedUs { get; set; } = null!;
}
