using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Survey2DetailStatusHistory
{
    public int SrdhId { get; set; }

    public int SrdhSrdId { get; set; }

    public short SrdhCdIdSrdsts { get; set; }

    public DateTime SrdhCreationDate { get; set; }

    public int SrdhUsId { get; set; }

    public virtual Survey2Detail SrdhSrd { get; set; } = null!;

    public virtual User SrdhUs { get; set; } = null!;
}
