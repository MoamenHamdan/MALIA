using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SurveyThirdparty
{
    public int SrthId { get; set; }

    public int? SrthSrId { get; set; }

    public int? SrthThpsId { get; set; }

    public virtual Survey? SrthSr { get; set; }

    public virtual ThirdpartySite? SrthThps { get; set; }
}
