using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class InspectionEmployeeSnc
{
    public int SIneId { get; set; }

    public int SIneInId { get; set; }

    public int SIneEmId { get; set; }

    public string SIneVersion { get; set; } = null!;

    public int SIneUserId { get; set; }
}
