using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InspectionSurveySnc
{
    public int SIlsId { get; set; }

    public int SIlsIlId { get; set; }

    public int SIlsSiId { get; set; }

    public int? SIlsCdIdAnswer { get; set; }

    public string? SIlsAnswerText { get; set; }

    public int? SIlsSmId { get; set; }

    public string SIlsVersion { get; set; } = null!;

    public short? SIlsSynched { get; set; }

    public short? SIlsScanned { get; set; }
}
