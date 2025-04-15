using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Movement
{
    public int MvId { get; set; }

    public int? MvOrgId { get; set; }

    public int? MvUsId { get; set; }

    public int MvBuId { get; set; }

    public int MvCdIdSrc { get; set; }

    public int MvMvtId { get; set; }

    public int? MvSgdId { get; set; }

    public int? MvCdIdCms { get; set; }

    public int? MvThpId { get; set; }

    public int? MvPlIdWhsFrom { get; set; }

    public int? MvPlIdWhsTo { get; set; }

    public int? MvMssId { get; set; }

    public string MvNumber { get; set; } = null!;

    public string? MvOurReference { get; set; }

    public string? MvTheirReference { get; set; }

    public DateTime MvDueDate { get; set; }

    public DateTime MvDate { get; set; }

    public string? MvRemarks { get; set; }

    public DateTime? MvCreateDate { get; set; }

    public DateTime? MvModifiedDate { get; set; }

    public DateTime? MvExportedDate { get; set; }

    public string? MvUid { get; set; }

    public string? MvVersion { get; set; }

    public virtual ICollection<MovementItemHistory> MovementItemHistories { get; set; } = new List<MovementItemHistory>();

    public virtual ICollection<MovementItem> MovementItems { get; set; } = new List<MovementItem>();

    public virtual ICollection<MovementLink> MovementLinkMvlMvIdLinkNavigations { get; set; } = new List<MovementLink>();

    public virtual ICollection<MovementLink> MovementLinkMvlMvs { get; set; } = new List<MovementLink>();

    public virtual ICollection<MovementStatusHistory> MovementStatusHistories { get; set; } = new List<MovementStatusHistory>();

    public virtual BusinessUnit MvBu { get; set; } = null!;

    public virtual Codesc? MvCdIdCmsNavigation { get; set; }

    public virtual Codesc MvCdIdSrcNavigation { get; set; } = null!;

    public virtual Movementstatus? MvMss { get; set; }

    public virtual Movementtype1 MvMvt { get; set; } = null!;

    public virtual PhysicalLocation? MvPlIdWhsFromNavigation { get; set; }

    public virtual PhysicalLocation? MvPlIdWhsToNavigation { get; set; }

    public virtual SignatureDetail? MvSgd { get; set; }

    public virtual Thirdparty? MvThp { get; set; }

    public virtual User? MvUs { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
