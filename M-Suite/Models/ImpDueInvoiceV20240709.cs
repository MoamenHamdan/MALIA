using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ImpDueInvoiceV20240709
{
    public int? IDiOrgId { get; set; }

    public int IDiBuId { get; set; }

    public int IDiCdIdCur { get; set; }

    public int? IDiCdIdSrc { get; set; }

    public int? IDiUsId { get; set; }

    public int? IDiTsId { get; set; }

    public int? IDiTsOrgId { get; set; }

    public int IDiThpsId { get; set; }

    public string IDiNumber { get; set; } = null!;

    public DateTime? IDiDate { get; set; }

    public DateTime? IDiDueDate { get; set; }

    public int? IDiOrder { get; set; }

    public decimal IDiTotalAmount { get; set; }

    public decimal IDiRemainAmount { get; set; }

    public DateTime IDiCreateDate { get; set; }

    public DateTime IDiModifiedDate { get; set; }

    public int IDiVoid { get; set; }

    public string IDiText1 { get; set; } = null!;

    public int? IDiId { get; set; }

    public string? IDiDesc { get; set; }
}
