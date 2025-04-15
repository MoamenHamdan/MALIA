using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemcontainerThpCategoryValue
{
    public int IctcvId { get; set; }

    public int IctcvIcId { get; set; }

    public int IctcvThcfvId { get; set; }

    public short? IctcvActive { get; set; }

    public DateTime? IctcvFromDate { get; set; }

    public DateTime? IctcvToDate { get; set; }

    public short? IctcvQuantity { get; set; }

    public virtual Itemcontainer IctcvIc { get; set; } = null!;

    public virtual ThirdpartycategoryFamilyValue IctcvThcfv { get; set; } = null!;
}
