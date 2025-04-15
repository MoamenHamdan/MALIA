using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class VTransactionType
{
    public int TstId { get; set; }

    public string TstCode { get; set; } = null!;

    public string? TstDescriptionLan1 { get; set; }

    public string? TstDescriptionLan2 { get; set; }

    public string? TstDescriptionLan3 { get; set; }

    public string? TstNameLan1 { get; set; }

    public string? TstNameLan2 { get; set; }

    public string? TstNameLan3 { get; set; }

    public string? TstNotes { get; set; }

    public short TstQuantityMultiplier { get; set; }

    public short? TstUpdateQuantity { get; set; }

    public short? TstCheckQuantity { get; set; }

    public short? TstHoldQuantity { get; set; }

    public short? TstMvtIdSource { get; set; }

    public short? TstAutoSequence { get; set; }

    public short? TstManageSerial { get; set; }

    public short? TstManageLot { get; set; }

    public short? TstManageExpiryDate { get; set; }

    public short? TstManageProductionDate { get; set; }

    public short? TstShowPrice { get; set; }

    public short TstAllowPriceChange { get; set; }

    public short TstAllowDiscountAmountChange { get; set; }

    public short TstAllowDiscountChange { get; set; }

    public string? TstPrintingCode { get; set; }

    public short? TstCheckCreditLimit { get; set; }

    public short? TstApplyPromotion { get; set; }

    public short? TstGenerateDueInvoice { get; set; }

    public short? TstPrintCopies { get; set; }

    public string? TstStatusFcCode { get; set; }

    public short? TstDqIdWhsSelection { get; set; }

    public int? TstDqUomSelection { get; set; }

    public int? TstDqItemSelection { get; set; }

    public short? TstApplyConstraints { get; set; }

    public short? TstCollect { get; set; }

    public short? TstUpdateCost { get; set; }

    public short? TstAccountingPost { get; set; }

    public short? TstAutoCreateFromSource { get; set; }

    public short? TstTstIdSource { get; set; }

    public int? TstTstIdNew { get; set; }

    public decimal? TstDefaultItemDiscount { get; set; }

    public int? TstCdIdTsg { get; set; }

    public short? TstShowreturntype { get; set; }

    public short? TstShowdeliveryqty { get; set; }

    public int? TstShowtax { get; set; }

    public string? TstReturntype { get; set; }

    public int? TstShowFreecomment { get; set; }

    public int? TstShowFreereason { get; set; }

    public short? TstAllowChangeOrdQty { get; set; }

    public short? TstAllowChangeDelvQty { get; set; }
}
