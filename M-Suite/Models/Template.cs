using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Template
{
    public int TmplId { get; set; }

    public string? TmplCode { get; set; }

    public string TmplDescriptionLan1 { get; set; } = null!;

    public string? TmplDescriptionLan2 { get; set; }

    public string? TmplDescriptionLan3 { get; set; }

    public short? TmplActive { get; set; }

    public DateTime TmplFromDate { get; set; }

    public DateTime TmplToDate { get; set; }

    public short? TmplAllCustomers { get; set; }

    public short? TmplAllUsers { get; set; }

    public int TmplUsIdCr { get; set; }

    public DateTime? TmplCreationDate { get; set; }

    public int TmplCdIdTmplt { get; set; }

    public virtual ICollection<TemplateItem> TemplateItems { get; set; } = new List<TemplateItem>();

    public virtual ICollection<TemplateThp> TemplateThps { get; set; } = new List<TemplateThp>();

    public virtual ICollection<TemplateUser> TemplateUsers { get; set; } = new List<TemplateUser>();

    public virtual Codesc TmplCdIdTmpltNavigation { get; set; } = null!;

    public virtual User TmplUsIdCrNavigation { get; set; } = null!;
}
