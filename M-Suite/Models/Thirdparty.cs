using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Thirdparty
{
    public int ThpId { get; set; }

    public int? ThpOrgId { get; set; }

    public int? ThpCdIdTpg { get; set; }

    public int? ThpCdIdTps { get; set; }

    public string ThpCode { get; set; } = null!;

    public string ThpNameLan1 { get; set; } = null!;

    public string? ThpNameLan2 { get; set; }

    public string? ThpNameLan3 { get; set; }

    public short? ThpIsCustomer { get; set; }

    public short? ThpIsSupplier { get; set; }

    public short? ThpIsCompany { get; set; }

    public DateTime ThpCreateDate { get; set; }

    public DateTime? ThpModifiedDate { get; set; }

    public short? ThpActive { get; set; }

    public string ThpImpUid { get; set; } = null!;

    public string? ThpRemarks { get; set; }

    public short? ThpImported { get; set; }

    public short? ThpReadonly { get; set; }

    public int? ThpUsIdCreated { get; set; }

    public string? ThpNewcode { get; set; }

    public string? ThpPrintLang { get; set; }

    public short? ThpPrintarabic { get; set; }

    public int? ThpIsB2b { get; set; }

    public virtual ICollection<ItmThpTransactiontype> ItmThpTransactiontypes { get; set; } = new List<ItmThpTransactiontype>();

    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();

    public virtual ICollection<ThirdpartyAdditionalInfo> ThirdpartyAdditionalInfos { get; set; } = new List<ThirdpartyAdditionalInfo>();

    public virtual ICollection<ThirdpartySite> ThirdpartySites { get; set; } = new List<ThirdpartySite>();

    public virtual ICollection<ThirdpartycategoryValue> ThirdpartycategoryValues { get; set; } = new List<ThirdpartycategoryValue>();

    public virtual Codesc? ThpCdIdTpgNavigation { get; set; }

    public virtual Codesc? ThpCdIdTpsNavigation { get; set; }

    public virtual ICollection<ThpTransactiontype> ThpTransactiontypes { get; set; } = new List<ThpTransactiontype>();

    public virtual ICollection<UserThirdparty> UserThirdparties { get; set; } = new List<UserThirdparty>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
