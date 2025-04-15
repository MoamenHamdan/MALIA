using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Operation
{
    public int OpId { get; set; }

    public int? OpOrgId { get; set; }

    public int? OpUsId { get; set; }

    public int OpBuId { get; set; }

    public int OpOptId { get; set; }

    public int? OpOpsId { get; set; }

    public int? OpCdIdSrc { get; set; }

    public int? OpCdIdCur { get; set; }

    public int? OpCdIdCms { get; set; }

    public int? OpThpsId { get; set; }

    public int? OpPlIdWhs { get; set; }

    public int? OpPlIdWhsTo { get; set; }

    public string OpNumber { get; set; } = null!;

    public string? OpOurReference { get; set; }

    public string? OpTheirReference { get; set; }

    public DateTime? OpDueDate { get; set; }

    public DateTime OpDate { get; set; }

    public decimal? OpDiscount { get; set; }

    public decimal? OpTotalDiscount { get; set; }

    public decimal? OpTotalDiscountBc { get; set; }

    public decimal? OpTotalTax { get; set; }

    public decimal? OpTotalTaxBc { get; set; }

    public decimal OpTotal { get; set; }

    public decimal? OpTotalBc { get; set; }

    public string? OpRemarks { get; set; }

    public DateTime? OpCreateDate { get; set; }

    public DateTime? OpModifiedDate { get; set; }

    public decimal? OpCurRate { get; set; }

    public decimal? OpInvCurRate { get; set; }

    public int? OpUsIdCreatedby { get; set; }

    public int? OpOpId { get; set; }

    public int? OpSgdId { get; set; }

    public int? OpTsId { get; set; }

    public int? OpUmvId { get; set; }

    public virtual BusinessUnit OpBu { get; set; } = null!;

    public virtual Codesc? OpCdIdCmsNavigation { get; set; }

    public virtual Codesc? OpCdIdCurNavigation { get; set; }

    public virtual Codesc? OpCdIdSrcNavigation { get; set; }

    public virtual Operationstatus? OpOps { get; set; }

    public virtual Operationtype OpOpt { get; set; } = null!;

    public virtual PhysicalLocation? OpPlIdWhsNavigation { get; set; }

    public virtual PhysicalLocation? OpPlIdWhsToNavigation { get; set; }

    public virtual SignatureDetail? OpSgd { get; set; }

    public virtual ThirdpartySite? OpThps { get; set; }

    public virtual Transaction? OpTs { get; set; }

    public virtual UiMovement? OpUmv { get; set; }

    public virtual User? OpUs { get; set; }

    public virtual ICollection<OperationItem> OperationItems { get; set; } = new List<OperationItem>();

    public virtual ICollection<OperationPackaging> OperationPackagings { get; set; } = new List<OperationPackaging>();
}
