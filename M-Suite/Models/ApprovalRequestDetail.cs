using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ApprovalRequestDetail
{
    public int ArdId { get; set; }

    public int ArdArId { get; set; }

    public int ArdCdIdArtd { get; set; }

    public int? ArdOrgId { get; set; }

    public virtual ICollection<ApprovalrequestdetailInfo> ApprovalrequestdetailInfos { get; set; } = new List<ApprovalrequestdetailInfo>();

    public virtual ApprovalRequest ArdAr { get; set; } = null!;

    public virtual Codesc ArdCdIdArtdNavigation { get; set; } = null!;
}
