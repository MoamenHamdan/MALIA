using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ItemMsl
{
    public int ImslId { get; set; }

    public int ImslCdIdImslt { get; set; }

    public int ImslBuId { get; set; }

    public string ImslCode { get; set; } = null!;

    public string ImslDescriptionLan1 { get; set; } = null!;

    public string? ImslDescriptionLan2 { get; set; }

    public string? ImslDescriptionLan3 { get; set; }

    public DateTime ImslDateStart { get; set; }

    public DateTime ImslDateEnd { get; set; }

    public short ImslActive { get; set; }

    public DateTime ImslDateCreation { get; set; }

    public virtual BusinessUnit ImslBu { get; set; } = null!;

    public virtual Codesc ImslCdIdImsltNavigation { get; set; } = null!;

    public virtual ICollection<ItemMslDetail> ItemMslDetails { get; set; } = new List<ItemMslDetail>();

    public virtual ICollection<ItemMslGl> ItemMslGls { get; set; } = new List<ItemMslGl>();

    public virtual ICollection<ItemMslThp> ItemMslThps { get; set; } = new List<ItemMslThp>();
}
