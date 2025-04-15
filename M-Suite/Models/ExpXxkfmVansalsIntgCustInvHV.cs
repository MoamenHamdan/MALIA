using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpXxkfmVansalsIntgCustInvHV
{
    public int InventoryHeaderId { get; set; }

    public string ReferenceNumber { get; set; } = null!;

    public string InventoryStatus { get; set; } = null!;

    public string OrgId { get; set; } = null!;

    public string OrgCode { get; set; } = null!;

    public string? OrgName { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? CustomerId { get; set; }

    public string? CustomerNumber { get; set; }

    public string? CustomerSiteName { get; set; }

    public string? CustomerSiteId { get; set; }

    public string DriverName { get; set; } = null!;

    public string DriverCode { get; set; } = null!;

    public string Note { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string? Attribute1 { get; set; }

    public string DarpNo { get; set; } = null!;

    public int ThpsiId { get; set; }

    public int? ThpsiOrgId { get; set; }

    public string? VtVersion { get; set; }
}
