using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Menu
{
    public int MnId { get; set; }

    public int? MnMnId { get; set; }

    public int? MnCdIdMnu { get; set; }

    public int MnOrder { get; set; }

    public short MnLevel { get; set; }

    public string MnCode { get; set; } = null!;

    public string MnDescriptionLan1 { get; set; } = null!;

    public string? MnDescriptionLan2 { get; set; }

    public string? MnDescriptionLan3 { get; set; }

    public string? MnCommand { get; set; }

    public string? MnIcon { get; set; }

    public short MnIsAction { get; set; }

    public short? MnIsFunctionality { get; set; }

    public short? MnActive { get; set; }

    public short? MnIsSystem { get; set; }

    public virtual ICollection<Menu> InverseMnMn { get; set; } = new List<Menu>();

    public virtual Menu? MnMn { get; set; }
}
