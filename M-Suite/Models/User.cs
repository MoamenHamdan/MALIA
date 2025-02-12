using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class User
{
    public int UsId { get; set; }

    public int? UsUsId { get; set; }

    public int? UsThpId { get; set; }

    public int? UsCdIdGen { get; set; }

    public int? UsCdIdTtl { get; set; }

    public string UsCode { get; set; } = null!;

    public string UsFirstName { get; set; } = null!;

    public string UsLastName { get; set; } = null!;

    public string UsShortName { get; set; } = null!;

    public string UsLogin { get; set; } = null!;

    public string UsPassword { get; set; } = null!;

    public string? UsEmail { get; set; }

    public short? UsReceiveNotification { get; set; }

    public DateTime? UsExpiryDate { get; set; }

    public short? UsActive { get; set; }

    public short UsDeleted { get; set; }

    public string? UsDbUser { get; set; }

    public short? UsImported { get; set; }

    public short? UsReadonly { get; set; }

    public string? UsToken { get; set; }

    public string? UsRoute { get; set; }

    public string? UsPrefix { get; set; }

    public string? UsType { get; set; }

    public virtual ICollection<CallCycle> CallCycles { get; set; } = new List<CallCycle>();

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<User> InverseUsUs { get; set; } = new List<User>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Route> Routes { get; set; } = new List<Route>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual User? UsUs { get; set; }

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
