using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CustomerPlusSnc
{
    public int SCpId { get; set; }

    public string? SCpName { get; set; }

    public string? SCpPhone { get; set; }

    public string? SCpCell { get; set; }

    public string? SCpArea { get; set; }

    public string? SCpSubarea { get; set; }

    public string? SCpCity { get; set; }

    public string? SCpZone { get; set; }

    public string? SCpAddressLine { get; set; }

    public DateTime? SCpCreationDate { get; set; }

    public int? SCpSmCreatedBy { get; set; }

    public string? SCpLongitude { get; set; }

    public string? SCpLatitude { get; set; }

    public string? SCpComments { get; set; }

    public string? SCpAttribute01 { get; set; }

    public string? SCpAttribute02 { get; set; }

    public string? SCpAttribute03 { get; set; }

    public string? SCpAttribute04 { get; set; }

    public string? SCpAttribute05 { get; set; }

    public string? SCpAttribute06 { get; set; }

    public string? SCpAttribute07 { get; set; }

    public string? SCpAttribute08 { get; set; }

    public string? SCpAttribute09 { get; set; }

    public string? SCpAttribute10 { get; set; }

    public int? SCpIsCreated { get; set; }

    public string SCpVersion { get; set; } = null!;

    public int SCpSmId { get; set; }
}
