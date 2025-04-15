using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MovementSequence
{
    public int MvsId { get; set; }

    public int? MvsBuId { get; set; }

    public int? MvsUsId { get; set; }

    public int? MvsMvtId { get; set; }

    public int? MvsSqId { get; set; }

    public string MvsPrefix { get; set; } = null!;

    public short? MvsLength { get; set; }

    public short MvsOrder { get; set; }

    public int? MvsActive { get; set; }

    public virtual BusinessUnit? MvsBu { get; set; }

    public virtual Movementtype1? MvsMvt { get; set; }

    public virtual Sequence? MvsSq { get; set; }

    public virtual User? MvsUs { get; set; }
}
