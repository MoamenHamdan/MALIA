using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemWarehouseHistory
{
    public int? ItwPlIdWhs { get; set; }

    public int? ItwItId { get; set; }

    public int? ItwUomId { get; set; }

    public decimal? ItwQuantity { get; set; }

    public decimal? ItwQuantityDamage { get; set; }

    public decimal? ItwQuantityReserved { get; set; }

    public string? ItwAction { get; set; }

    public DateTime ItwDateofaction { get; set; }

    public string? SuserName { get; set; }

    public string? HostName { get; set; }

    public DateTime? ItwCreationDate { get; set; }

    public int? ItwCreatedBy { get; set; }

    public DateTime? ItwUpdateDate { get; set; }

    public int? ItwUpdatedBy { get; set; }

    public string? ItwRemarks { get; set; }
}
