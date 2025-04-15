using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SystemOperator
{
    public int SoId { get; set; }

    public int? SoUsId { get; set; }

    public string? SoName { get; set; }

    public string? SoEmail { get; set; }

    public string? SoSms { get; set; }

    public short? SoActive { get; set; }
}
