using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CallCycleUserHelper
{
    public int CcuhId { get; set; }

    public int? CcuhDhId { get; set; }

    public int? CcuhUsId { get; set; }

    public short? CcuhCycleNo { get; set; }

    public short? CcuhCycleOrder { get; set; }

    public int? CcuhCcId { get; set; }

    public virtual DateHelper? CcuhDh { get; set; }

    public virtual User? CcuhUs { get; set; }
}
