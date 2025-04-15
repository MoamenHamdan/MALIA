using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class MenuDetail
{
    public int MndId { get; set; }

    public int? MndMnId { get; set; }

    public int? MndCdIdAct { get; set; }

    public short? MndInpage { get; set; }

    public short? MndInsearch { get; set; }

    public virtual ICollection<ProfileMenuDetail> ProfileMenuDetails { get; set; } = new List<ProfileMenuDetail>();
}
