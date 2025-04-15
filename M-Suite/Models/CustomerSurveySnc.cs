using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CustomerSurveySnc
{
    public int SCsId { get; set; }

    public int? SCsCuId { get; set; }

    public int? SCsScId { get; set; }

    public string SCsVersion { get; set; } = null!;

    public string SCsSmId { get; set; } = null!;
}
