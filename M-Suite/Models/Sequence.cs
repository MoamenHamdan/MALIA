using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Sequence
{
    public int SqId { get; set; }

    public string SqCode { get; set; } = null!;

    public string SqDescriptionLan1 { get; set; } = null!;

    public string? SqDescriptionLan2 { get; set; }

    public string? SqDescriptionLan3 { get; set; }

    public int SqFrom { get; set; }

    public int SqTo { get; set; }

    public DateTime? SqDate { get; set; }

    public short SqActive { get; set; }

    public int? SqUserId { get; set; }

    public virtual ICollection<MovementSequence> MovementSequences { get; set; } = new List<MovementSequence>();

    public virtual ICollection<PaymenttypeSequence> PaymenttypeSequences { get; set; } = new List<PaymenttypeSequence>();

    public virtual ICollection<TransactiontypeSequence> TransactiontypeSequences { get; set; } = new List<TransactiontypeSequence>();
}
