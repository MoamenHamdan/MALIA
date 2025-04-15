using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CustomerBillShipSnc
{
    public int SCbsId { get; set; }

    public int? SCbsCuIdBill { get; set; }

    public int? SCbsCuIdShip { get; set; }

    public string SCbsVersion { get; set; } = null!;

    public string SCbsSmId { get; set; } = null!;
}
