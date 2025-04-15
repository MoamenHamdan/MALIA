using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Tax
{
    public int TaxId { get; set; }

    public int? TaxCdIdTaxt { get; set; }

    public string TaxCode { get; set; } = null!;

    public string TaxDescriptionLan1 { get; set; } = null!;

    public string? TaxDescriptionLan2 { get; set; }

    public string? TaxDescriptionLan3 { get; set; }

    public decimal TaxRate { get; set; }

    public string? TaxFormula { get; set; }

    public short TaxIsOnItemLevel { get; set; }

    public string TaxAmountPercentage { get; set; } = null!;

    public short TaxApplyOrder { get; set; }

    public string? TaxMobileFormula { get; set; }

    public virtual ICollection<ItemTax> ItemTaxes { get; set; } = new List<ItemTax>();

    public virtual Codesc? TaxCdIdTaxtNavigation { get; set; }

    public virtual ICollection<ThirdpartysitefinanceTax> ThirdpartysitefinanceTaxes { get; set; } = new List<ThirdpartysitefinanceTax>();

    public virtual ICollection<TransactionTax> TransactionTaxes { get; set; } = new List<TransactionTax>();

    public virtual ICollection<TransactionitemTax> TransactionitemTaxes { get; set; } = new List<TransactionitemTax>();

    public virtual ICollection<TransactiontypeTax> TransactiontypeTaxes { get; set; } = new List<TransactiontypeTax>();
}
