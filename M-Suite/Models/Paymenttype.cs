using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Paymenttype
{
    public int PyId { get; set; }

    public string? PyCode { get; set; }

    public string? PyDescriptionLan1 { get; set; }

    public string? PyDescriptionLan2 { get; set; }

    public string? PyDescriptionLan3 { get; set; }

    public string? PyNameLan1 { get; set; }

    public string? PyNameLan2 { get; set; }

    public string? PyNameLan3 { get; set; }

    public virtual ICollection<PaymenttypeSequence> PaymenttypeSequences { get; set; } = new List<PaymenttypeSequence>();
}
