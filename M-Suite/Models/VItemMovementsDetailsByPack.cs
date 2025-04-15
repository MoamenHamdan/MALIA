using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VItemMovementsDetailsByPack
{
    public string? ImdMvTypeCode { get; set; }

    public string? ImdMvTypeDescription { get; set; }

    public string ImdUserCode { get; set; } = null!;

    public string ImdUserName { get; set; } = null!;

    public string ImdWarehouseCode { get; set; } = null!;

    public string ImdWarehouseName { get; set; } = null!;

    public DateTime ImdDate { get; set; }

    public string ImdNumber { get; set; } = null!;

    public string ImdMvStatusCode { get; set; } = null!;

    public string ImdMvStatusDescription { get; set; } = null!;

    public string ImdCustomerCode { get; set; } = null!;

    public string ImdCustomerName { get; set; } = null!;

    public string ImdItemCode { get; set; } = null!;

    public string ImdItemDescription { get; set; } = null!;

    public string? ImdItemDescriptionAr { get; set; }

    public decimal? ImdQuantity { get; set; }

    public int ImdItId { get; set; }

    public int? ImdUsId { get; set; }

    public decimal? ImdPrice { get; set; }

    public int? ImdConvValue { get; set; }

    public int? ImdBuId { get; set; }
}
