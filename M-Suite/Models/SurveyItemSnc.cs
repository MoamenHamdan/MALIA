using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SurveyItemSnc
{
    public int? SSiId { get; set; }

    public int? SSiScId { get; set; }

    public string? SSiCode { get; set; }

    public string? SSiQuestion { get; set; }

    public int? SSiCdIdAnswerType { get; set; }

    public int? SSiActive { get; set; }

    public int? SSiReadBarcode { get; set; }

    public string? SSiVersion { get; set; }

    public string? SSiSmId { get; set; }
}
