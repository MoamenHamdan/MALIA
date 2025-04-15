using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Transactionstatus
{
    public int TssId { get; set; }

    public string TssCode { get; set; } = null!;

    public string TssDescriptionLan1 { get; set; } = null!;

    public string TssDescriptionLan2 { get; set; } = null!;

    public string TssDescriptionLan3 { get; set; } = null!;

    public string TssLabelCode { get; set; } = null!;

    public string? TssStyle { get; set; }

    public string? TssConfirmationCode { get; set; }

    public int TssOrder { get; set; }

    public short TssCausesValidation { get; set; }

    public virtual ICollection<TransactionDelivery> TransactionDeliveries { get; set; } = new List<TransactionDelivery>();

    public virtual ICollection<TransactionReason> TransactionReasons { get; set; } = new List<TransactionReason>();

    public virtual ICollection<TransactionStatusHistory> TransactionStatusHistories { get; set; } = new List<TransactionStatusHistory>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual ICollection<TransactionstatusTransition> TransactionstatusTransitionTsstTssIdFromNavigations { get; set; } = new List<TransactionstatusTransition>();

    public virtual ICollection<TransactionstatusTransition> TransactionstatusTransitionTsstTssIdGenerateNavigations { get; set; } = new List<TransactionstatusTransition>();

    public virtual ICollection<TransactionstatusTransition> TransactionstatusTransitionTsstTssIdToNavigations { get; set; } = new List<TransactionstatusTransition>();

    public virtual ICollection<UiTransactionItem> UiTransactionItems { get; set; } = new List<UiTransactionItem>();

    public virtual ICollection<UiTransaction> UiTransactions { get; set; } = new List<UiTransaction>();
}
