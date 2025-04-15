using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class SignatureDetail
{
    public int SgdId { get; set; }

    public int? SgdOrgId { get; set; }

    public int? SgdCdIdSsrc { get; set; }

    public string? SgdReference { get; set; }

    public int SgdFkValue { get; set; }

    public string? SgdLabel { get; set; }

    public string? SgdDescription { get; set; }

    public string? SgdSignFilePath { get; set; }

    public string? SgdSignFileName { get; set; }

    public string? SgdText1 { get; set; }

    public string? SgdText2 { get; set; }

    public DateTime? SgdDate { get; set; }

    public int? SgdSatisfaction { get; set; }

    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();

    public virtual ICollection<Operation> Operations { get; set; } = new List<Operation>();

    public virtual ICollection<SurveyResult> SurveyResults { get; set; } = new List<SurveyResult>();

    public virtual ICollection<TransactionDelivery> TransactionDeliveries { get; set; } = new List<TransactionDelivery>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
