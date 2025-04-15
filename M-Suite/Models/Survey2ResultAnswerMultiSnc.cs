using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2ResultAnswerMultiSnc
{
    public int SSramId { get; set; }

    public int SSramSraId { get; set; }

    public int SSramSadId { get; set; }

    public string SSramVersion { get; set; } = null!;

    public int SSramUsId { get; set; }
}
