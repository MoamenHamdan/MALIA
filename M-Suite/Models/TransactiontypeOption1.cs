using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactiontypeOption1
{
    public int TstoId { get; set; }

    public int? TstoTstId { get; set; }

    public string? TstoCode { get; set; }

    public string? TstoDescriptionLan1 { get; set; }

    public string? TstoDescriptionLan2 { get; set; }

    public string? TstoDescriptionLan3 { get; set; }

    public short TstoAllowDiscountChange { get; set; }

    public short TstoAllowDiscountAmountChange { get; set; }

    public short? TstoShowPrice { get; set; }

    public short? TstoManageProductionDate { get; set; }

    public short? TstoManageExpiryDate { get; set; }

    public short? TstoManageLot { get; set; }

    public short? TstoManageSerial { get; set; }

    public short? TstoHoldQuantity { get; set; }

    public short? TstoCheckQuantity { get; set; }

    public short? TstoUpdateQuantity { get; set; }

    public short TstoQuantityMultiplier { get; set; }

    public short TstoAllowPriceChange { get; set; }

    public virtual ICollection<TransactionDeliveryItem> TransactionDeliveryItems { get; set; } = new List<TransactionDeliveryItem>();

    public virtual ICollection<TransactionItem> TransactionItems { get; set; } = new List<TransactionItem>();

    public virtual Transactiontype1? TstoTst { get; set; }
}
