using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class CustomerAddressSnc
{
    public int SAdId { get; set; }

    public int SAdCuId { get; set; }

    public string? SAdAddress1 { get; set; }

    public string? SAdAddress2 { get; set; }

    public string? SAdAddress3 { get; set; }

    public string? SAdPhone { get; set; }

    public string? SAdMobile { get; set; }

    public string? SAdFax { get; set; }

    public string? SAdEmail { get; set; }

    public string? SAdWebsite { get; set; }

    public string? SAdCity { get; set; }

    public string? SAdCountry { get; set; }

    public string? SAdLongitude { get; set; }

    public string? SAdLatitude { get; set; }

    public short SAdIsCreated { get; set; }

    public short SAdIsModified { get; set; }

    public int SAdSmId { get; set; }

    public string SAdVersion { get; set; } = null!;
}
