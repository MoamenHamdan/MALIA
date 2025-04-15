using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2ResultAnswerMulti
{
    public int SramId { get; set; }

    public int SramSraId { get; set; }

    public int SramSadId { get; set; }

    public virtual Survey2answerDetail SramSad { get; set; } = null!;

    public virtual Survey2ResultAnswer SramSra { get; set; } = null!;
}
