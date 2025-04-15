using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Transactiontype1
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

    public int? TstShowLinkedTransactionNumber { get; set; }

    public virtual ICollection<ItmThpTransactiontype> ItmThpTransactiontypes { get; set; } = new List<ItmThpTransactiontype>();

    public virtual ICollection<ItmThpsUomTransactiontypeException> ItmThpsUomTransactiontypeExceptions { get; set; } = new List<ItmThpsUomTransactiontypeException>();

    public virtual ICollection<ItmThpsUomTransactiontype> ItmThpsUomTransactiontypes { get; set; } = new List<ItmThpsUomTransactiontype>();

    public virtual ICollection<ThpTransactiontype> ThpTransactiontypes { get; set; } = new List<ThpTransactiontype>();

    public virtual ICollection<TransactionDelivery> TransactionDeliveries { get; set; } = new List<TransactionDelivery>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual ICollection<TransactionstatusTransition> TransactionstatusTransitionTsstTstIdGenerateNavigations { get; set; } = new List<TransactionstatusTransition>();

    public virtual ICollection<TransactionstatusTransition> TransactionstatusTransitionTsstTsts { get; set; } = new List<TransactionstatusTransition>();

    public virtual ICollection<TransactiontypeOption1> TransactiontypeOption1s { get; set; } = new List<TransactiontypeOption1>();

    public virtual ICollection<TransactiontypeSequence> TransactiontypeSequences { get; set; } = new List<TransactiontypeSequence>();

    public virtual ICollection<TransactiontypeTax> TransactiontypeTaxes { get; set; } = new List<TransactiontypeTax>();

    public virtual ICollection<TransactiontypeUiGenericpage> TransactiontypeUiGenericpages { get; set; } = new List<TransactiontypeUiGenericpage>();

    public virtual Codesc? TstCdIdTsgNavigation { get; set; }

    public virtual ICollection<UiTransactionItem> UiTransactionItems { get; set; } = new List<UiTransactionItem>();

    public virtual ICollection<UiTransaction> UiTransactions { get; set; } = new List<UiTransaction>();

    public virtual ICollection<UserThpsTransactiontype> UserThpsTransactiontypes { get; set; } = new List<UserThpsTransactiontype>();

    public virtual ICollection<UserTransactiontype> UserTransactiontypes { get; set; } = new List<UserTransactiontype>();
}
