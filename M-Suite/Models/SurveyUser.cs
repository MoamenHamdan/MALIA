using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SurveyUser
{
    public int SrusId { get; set; }

    public int? SrusSrId { get; set; }

    public int? SrusUsId { get; set; }

    public virtual Survey? SrusSr { get; set; }

    public virtual User? SrusUs { get; set; }
}
