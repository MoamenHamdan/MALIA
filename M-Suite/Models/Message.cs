using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Message
{
    public int MsgId { get; set; }

    public string MsgCode { get; set; } = null!;

    public string MsgDescriptionLan1 { get; set; } = null!;

    public string? MsgDescriptionLan2 { get; set; }

    public string? MsgDescriptionLan3 { get; set; }
}
