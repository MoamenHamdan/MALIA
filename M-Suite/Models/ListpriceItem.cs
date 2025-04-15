using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ListpriceItem
{
    public int LpiId { get; set; }

    public int? LpiLpId { get; set; }

    public int? LpiItId { get; set; }

    public int? LpiUomId { get; set; }

    public decimal LpiPrice { get; set; }

    public decimal? LpiDiscount { get; set; }

    public decimal? LpiMaxDiscount { get; set; }

    public virtual ICollection<ListpriceItemException> ListpriceItemExceptions { get; set; } = new List<ListpriceItemException>();

    public virtual Item? LpiIt { get; set; }

    public virtual Listprice? LpiLp { get; set; }

    public virtual Uom? LpiUom { get; set; }

    public virtual ICollection<TransactionDeliveryItem> TransactionDeliveryItems { get; set; } = new List<TransactionDeliveryItem>();
}
