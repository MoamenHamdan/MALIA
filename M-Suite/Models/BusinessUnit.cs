using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class BusinessUnit
{
    public int BuId { get; set; }

    public int? BuBuId { get; set; }

    public int? BuCpId { get; set; }

    public string BuCode { get; set; } = null!;

    public string BuDescriptionLan1 { get; set; } = null!;

    public string? BuDescriptionLan2 { get; set; }

    public string? BuDescriptionLan3 { get; set; }

    public string BuPath { get; set; } = null!;

    public string? BuImpUid { get; set; }

    public string? BuLeId { get; set; }

    public string? BuOuId { get; set; }

    public string? BuOrgCode { get; set; }

    public string? BuPrefix { get; set; }

    public virtual ICollection<ApprovalConfig> ApprovalConfigs { get; set; } = new List<ApprovalConfig>();

    public virtual BusinessUnit? BuBu { get; set; }

    public virtual Company? BuCp { get; set; }

    public virtual ICollection<BusinessUnitAttribute> BusinessUnitAttributes { get; set; } = new List<BusinessUnitAttribute>();

    public virtual ICollection<BusinessUnitPlu> BusinessUnitPlus { get; set; } = new List<BusinessUnitPlu>();

    public virtual ICollection<BusinessunitApplisetting> BusinessunitApplisettings { get; set; } = new List<BusinessunitApplisetting>();

    public virtual ICollection<CodeSequence> CodeSequences { get; set; } = new List<CodeSequence>();

    public virtual ICollection<Codesc> Codescs { get; set; } = new List<Codesc>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<Creditdebitnote> Creditdebitnotes { get; set; } = new List<Creditdebitnote>();

    public virtual ICollection<DueInvoice> DueInvoices { get; set; } = new List<DueInvoice>();

    public virtual ICollection<BusinessUnit> InverseBuBu { get; set; } = new List<BusinessUnit>();

    public virtual ICollection<ItemFinance> ItemFinances { get; set; } = new List<ItemFinance>();

    public virtual ICollection<ItemMsl> ItemMsls { get; set; } = new List<ItemMsl>();

    public virtual ICollection<ItemTax> ItemTaxes { get; set; } = new List<ItemTax>();

    public virtual ICollection<ItemcategoryFamily> ItemcategoryFamilies { get; set; } = new List<ItemcategoryFamily>();

    public virtual ICollection<ItmThpTransactiontype> ItmThpTransactiontypes { get; set; } = new List<ItmThpTransactiontype>();

    public virtual ICollection<ItmThpsUomTransactiontype> ItmThpsUomTransactiontypes { get; set; } = new List<ItmThpsUomTransactiontype>();

    public virtual ICollection<Listprice> Listprices { get; set; } = new List<Listprice>();

    public virtual ICollection<MovementSequence> MovementSequences { get; set; } = new List<MovementSequence>();

    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();

    public virtual ICollection<MovementstatusTransitionBu> MovementstatusTransitionBus { get; set; } = new List<MovementstatusTransitionBu>();

    public virtual ICollection<OperationBatch> OperationBatches { get; set; } = new List<OperationBatch>();

    public virtual ICollection<Operation> Operations { get; set; } = new List<Operation>();

    public virtual ICollection<PaymentDetail> PaymentDetails { get; set; } = new List<PaymentDetail>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Paymentterm> Paymentterms { get; set; } = new List<Paymentterm>();

    public virtual ICollection<PaymenttypeSequence> PaymenttypeSequences { get; set; } = new List<PaymenttypeSequence>();

    public virtual ICollection<PhysicalLocation> PhysicalLocations { get; set; } = new List<PhysicalLocation>();

    public virtual ICollection<PostUpload1> PostUpload1s { get; set; } = new List<PostUpload1>();

    public virtual ICollection<Printing1> Printing1s { get; set; } = new List<Printing1>();

    public virtual ICollection<PromotionMaster> PromotionMasters { get; set; } = new List<PromotionMaster>();

    public virtual ICollection<Survey2BusinessUnit> Survey2BusinessUnits { get; set; } = new List<Survey2BusinessUnit>();

    public virtual ICollection<Survey> Surveys { get; set; } = new List<Survey>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    public virtual ICollection<ThirdpartyFinance> ThirdpartyFinances { get; set; } = new List<ThirdpartyFinance>();

    public virtual ICollection<ThpTransactiontype> ThpTransactiontypes { get; set; } = new List<ThpTransactiontype>();

    public virtual ICollection<ThpsInventory> ThpsInventories { get; set; } = new List<ThpsInventory>();

    public virtual ICollection<ThpsInventoryHeader> ThpsInventoryHeaders { get; set; } = new List<ThpsInventoryHeader>();

    public virtual ICollection<ThpsIvhsTransitionBu> ThpsIvhsTransitionBus { get; set; } = new List<ThpsIvhsTransitionBu>();

    public virtual ICollection<ThpsIvsTransitionBu> ThpsIvsTransitionBus { get; set; } = new List<ThpsIvsTransitionBu>();

    public virtual ICollection<TransactionDelivery> TransactionDeliveries { get; set; } = new List<TransactionDelivery>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual ICollection<TransactionstatusTransitionBu> TransactionstatusTransitionBus { get; set; } = new List<TransactionstatusTransitionBu>();

    public virtual ICollection<TransactiontypeTax> TransactiontypeTaxes { get; set; } = new List<TransactiontypeTax>();

    public virtual ICollection<UserBusinessUnit> UserBusinessUnits { get; set; } = new List<UserBusinessUnit>();

    public virtual ICollection<UserPayment> UserPayments { get; set; } = new List<UserPayment>();

    public virtual ICollection<UserThirdparty> UserThirdparties { get; set; } = new List<UserThirdparty>();

    public virtual ICollection<UserThpsTransactiontype> UserThpsTransactiontypes { get; set; } = new List<UserThpsTransactiontype>();

    public virtual ICollection<UserTransactiontype> UserTransactiontypes { get; set; } = new List<UserTransactiontype>();
}
