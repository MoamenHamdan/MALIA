using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InspectionSurvey
{
    public int IlsId { get; set; }

    public int? IlsOrgId { get; set; }

    public int IlsSriId { get; set; }

    public int IlsIlId { get; set; }

    public int? IlsCdIdAnswer { get; set; }

    public string? IlsAnswerText { get; set; }

    public short? IlsScanned { get; set; }

    public virtual Codesc? IlsCdIdAnswerNavigation { get; set; }

    public virtual InspectionList IlsIl { get; set; } = null!;

    public virtual SurveyQuestion IlsSri { get; set; } = null!;
}
