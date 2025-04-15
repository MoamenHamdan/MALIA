using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Profile
{
    public int PrId { get; set; }

    public string PrCode { get; set; } = null!;

    public string PrDescription { get; set; } = null!;

    public short PrActive { get; set; }

    public virtual ICollection<InventorystatusTransitionProfile> InventorystatusTransitionProfiles { get; set; } = new List<InventorystatusTransitionProfile>();

    public virtual ICollection<MobilemenusProfile> MobilemenusProfiles { get; set; } = new List<MobilemenusProfile>();

    public virtual ICollection<MovementstatusTransitionProfile> MovementstatusTransitionProfiles { get; set; } = new List<MovementstatusTransitionProfile>();

    public virtual ICollection<ProfileAppliSetting> ProfileAppliSettings { get; set; } = new List<ProfileAppliSetting>();

    public virtual ICollection<ProfileMenuDetail> ProfileMenuDetails { get; set; } = new List<ProfileMenuDetail>();

    public virtual ICollection<ProfileMenu> ProfileMenus { get; set; } = new List<ProfileMenu>();

    public virtual ICollection<QlikDashboardUser> QlikDashboardUsers { get; set; } = new List<QlikDashboardUser>();

    public virtual ICollection<TransactionstatusTransitionProfile> TransactionstatusTransitionProfiles { get; set; } = new List<TransactionstatusTransitionProfile>();

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();

    public virtual ICollection<UserpaymentstatusTransitionProfile> UserpaymentstatusTransitionProfiles { get; set; } = new List<UserpaymentstatusTransitionProfile>();
}
