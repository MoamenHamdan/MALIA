using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ExpXxVansalsIntgrInvoiceHV
{
    public int InvoiceHeaderId { get; set; }

    public string? ReferenceNumber { get; set; }

    public string OrgId { get; set; } = null!;

    public string OrgCode { get; set; } = null!;

    public string? OrgName { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? CustomerId { get; set; }

    public string? CustomerNumber { get; set; }

    public string? CustomerSiteName { get; set; }

    public string? CustomerSiteId { get; set; }

    public string InvoiceType { get; set; } = null!;

    public string ReturnType { get; set; } = null!;

    public DateTime? BakeryDate { get; set; }

    public string DriverName { get; set; } = null!;

    public string DriverCode { get; set; } = null!;

    public string? PriceListId { get; set; }

    public string? PriceListName { get; set; }

    public string? Note { get; set; }

    public string InvoiceStatus { get; set; } = null!;

    public string? TrxDocNumber { get; set; }

    public string VanCode { get; set; } = null!;

    public int Attribute1 { get; set; }

    public DateTime CreationDate { get; set; }

    public int TsId { get; set; }

    public int? TsOrgId { get; set; }

    public string? VtVersion { get; set; }
}
