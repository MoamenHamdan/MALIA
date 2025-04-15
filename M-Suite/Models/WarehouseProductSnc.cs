using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class WarehouseProductSnc
{
    public int SWpId { get; set; }

    public int SWpPrId { get; set; }

    public int SWpSmId { get; set; }

    public decimal SWpQuantity { get; set; }

    public string? SWpLotNo { get; set; }

    public string? SWpExpiryDate { get; set; }

    public string? SWpUnit { get; set; }

    public decimal SWpQuantityDmg { get; set; }

    public string? SWpProp1 { get; set; }

    public string? SWpProp2 { get; set; }

    public int SWpWhId { get; set; }

    public short? SWpImpFlag { get; set; }

    public decimal SWpPackQuantity { get; set; }

    public string STrVersion { get; set; } = null!;

    public int STrSmId { get; set; }
}
