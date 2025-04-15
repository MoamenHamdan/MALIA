using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VQlkVisit
{
    public string? VtId { get; set; }

    public int? VtCcdId { get; set; }

    public int VtUsId { get; set; }

    public int? VtThpsId { get; set; }

    public DateTime VtTimeIn { get; set; }

    public DateTime VtTimeOut { get; set; }

    public string VtOperation { get; set; } = null!;

    public string? VtRemarks { get; set; }

    public string? VtVersion { get; set; }

    public string? VtLongitude { get; set; }

    public string? VtLatitude { get; set; }

    public short? VtIsScanned { get; set; }

    public short? VtInGeofence { get; set; }

    public int? VtYear { get; set; }

    public int? VtMonth { get; set; }

    public int? VtDay { get; set; }

    public int? VtTimeSpent { get; set; }

    public int? VtTimeInNum { get; set; }

    public string? ThpsUsVt { get; set; }

    public string? ThpsLatitude { get; set; }

    public string? ThpsLongitude { get; set; }

    public double VtDistance { get; set; }

    public TimeOnly? VtTimeInT { get; set; }

    public TimeOnly? VtTimeOutT { get; set; }
}
