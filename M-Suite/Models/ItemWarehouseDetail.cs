using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemWarehouseDetail
{
    public int ItwdId { get; set; }

    public int ItwdItwId { get; set; }

    public int ItwdIldId { get; set; }

    public decimal ItwdQuantity { get; set; }

    public virtual ItemWarehouse ItwdItw { get; set; } = null!;
}
