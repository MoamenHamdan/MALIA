using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class GeoLocation
{
    public int GlId { get; set; }

    public int? GlCdIdGeo { get; set; }

    public int? GlGlId { get; set; }

    public short GlLevel { get; set; }

    public string GlCode { get; set; } = null!;

    public string GlDescriptionLan1 { get; set; } = null!;

    public string? GlDescriptionLan2 { get; set; }

    public string? GlDescriptionLan3 { get; set; }

    public virtual ICollection<GeoFence> GeoFences { get; set; } = new List<GeoFence>();

    public virtual ICollection<ItemMslGl> ItemMslGls { get; set; } = new List<ItemMslGl>();

    public virtual ICollection<ProspectThirdpartysite> ProspectThirdpartysites { get; set; } = new List<ProspectThirdpartysite>();

    public virtual ICollection<RouteGeoLocation> RouteGeoLocations { get; set; } = new List<RouteGeoLocation>();

    public virtual ICollection<TargetDetail> TargetDetails { get; set; } = new List<TargetDetail>();

    public virtual ICollection<ThirdpartyAdditionalInfo> ThirdpartyAdditionalInfos { get; set; } = new List<ThirdpartyAdditionalInfo>();

    public virtual ICollection<ThirdpartySite> ThirdpartySites { get; set; } = new List<ThirdpartySite>();

    public virtual ICollection<ThpsInventoryheaderGl> ThpsInventoryheaderGls { get; set; } = new List<ThpsInventoryheaderGl>();
}
