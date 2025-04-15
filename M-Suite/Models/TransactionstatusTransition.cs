using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class TransactionstatusTransition
{
    public int TsstId { get; set; }

    public int TsstTstId { get; set; }

    public int TsstTssIdFrom { get; set; }

    public int TsstTssIdTo { get; set; }

    public int? TsstTssIdGenerate { get; set; }

    public int? TsstTstIdGenerate { get; set; }

    public short TsstTsUsIsOwner { get; set; }

    public short TsstCheckAvailability { get; set; }

    public short TsstUpdateQuantity { get; set; }

    public short TsstLxpRequired { get; set; }

    public short TsstAutoAllocateLxp { get; set; }

    public short TsstManageDueInvoice { get; set; }

    public string? TsstExtraCode { get; set; }

    public short TsstExportData { get; set; }

    public short TsstCheckCreditLimit { get; set; }

    public int TsstSilentMode { get; set; }

    public virtual ICollection<TransactionstatusTransitionBu> TransactionstatusTransitionBus { get; set; } = new List<TransactionstatusTransitionBu>();

    public virtual ICollection<TransactionstatusTransitionProfile> TransactionstatusTransitionProfiles { get; set; } = new List<TransactionstatusTransitionProfile>();

    public virtual Transactionstatus TsstTssIdFromNavigation { get; set; } = null!;

    public virtual Transactionstatus? TsstTssIdGenerateNavigation { get; set; }

    public virtual Transactionstatus TsstTssIdToNavigation { get; set; } = null!;

    public virtual Transactiontype1 TsstTst { get; set; } = null!;

    public virtual Transactiontype1? TsstTstIdGenerateNavigation { get; set; }
}
