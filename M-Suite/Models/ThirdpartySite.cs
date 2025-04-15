using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class ThirdpartySite
{
    public int ThpsId { get; set; }

    public int? ThpsOrgId { get; set; }

    public int ThpsThpId { get; set; }

    public int ThpsCdIdBst { get; set; }

    public int? ThpsGlId { get; set; }

    public string ThpsCode { get; set; } = null!;

    public string ThpsBarcode { get; set; } = null!;

    public string ThpsNameLan1 { get; set; } = null!;

    public string? ThpsNameLan2 { get; set; }

    public string? ThpsNameLan3 { get; set; }

    public string? ThpsAddress1 { get; set; }

    public string? ThpsAddress2 { get; set; }

    public string? ThpsAddress3 { get; set; }

    public string? ThpsLongitude { get; set; }

    public string? ThpsLatitude { get; set; }

    public string? ThpsPhone { get; set; }

    public string? ThpsMobile { get; set; }

    public string? ThpsEmail { get; set; }

    public string? ThpsWebsite { get; set; }

    public string? ThpsFax { get; set; }

    public string? ThpsContactNameLan1 { get; set; }

    public string? ThpsContactNameLan2 { get; set; }

    public string? ThpsContactNameLan3 { get; set; }

    public DateTime ThpsCreateDate { get; set; }

    public string ThpsImpUid { get; set; } = null!;

    public short ThpsActive { get; set; }

    public string? ThpsRemarks { get; set; }

    public int? ThpsCdIdTpg { get; set; }

    public int? ThpsUsIdCreated { get; set; }

    public string? ThpsNewcode { get; set; }

    public string? ThpsSiteId { get; set; }

    public string? ThpsLangPrint { get; set; }

    public virtual ICollection<CallCycleDetail> CallCycleDetails { get; set; } = new List<CallCycleDetail>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<Creditdebitnote> Creditdebitnotes { get; set; } = new List<Creditdebitnote>();

    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();

    public virtual ICollection<DueInvoice> DueInvoices { get; set; } = new List<DueInvoice>();

    public virtual ICollection<InventoryLineThirdpartySite> InventoryLineThirdpartySites { get; set; } = new List<InventoryLineThirdpartySite>();

    public virtual ICollection<ItemMslThp> ItemMslThps { get; set; } = new List<ItemMslThp>();

    public virtual ICollection<ItmThpTransactiontype> ItmThpTransactiontypes { get; set; } = new List<ItmThpTransactiontype>();

    public virtual ICollection<OperationBatch> OperationBatches { get; set; } = new List<OperationBatch>();

    public virtual ICollection<Operation> Operations { get; set; } = new List<Operation>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<PlanogramThp> PlanogramThps { get; set; } = new List<PlanogramThp>();

    public virtual ICollection<RouteTask> RouteTasks { get; set; } = new List<RouteTask>();

    public virtual ICollection<RouteThirdpartySite> RouteThirdpartySites { get; set; } = new List<RouteThirdpartySite>();

    public virtual ICollection<SalesassetHistory> SalesassetHistories { get; set; } = new List<SalesassetHistory>();

    public virtual ICollection<SalesassetInventory> SalesassetInventories { get; set; } = new List<SalesassetInventory>();

    public virtual ICollection<SurveyThirdparty> SurveyThirdparties { get; set; } = new List<SurveyThirdparty>();

    public virtual ICollection<TargetDetail> TargetDetails { get; set; } = new List<TargetDetail>();

    public virtual ICollection<TemplateThp> TemplateThps { get; set; } = new List<TemplateThp>();

    public virtual ICollection<ThirdpartyBillShip> ThirdpartyBillShipThbsThps { get; set; } = new List<ThirdpartyBillShip>();

    public virtual ICollection<ThirdpartyBillShip> ThirdpartyBillShipThbsThpsIdBstNavigations { get; set; } = new List<ThirdpartyBillShip>();

    public virtual ICollection<ThirdpartyFinance> ThirdpartyFinances { get; set; } = new List<ThirdpartyFinance>();

    public virtual ICollection<ThirdpartyItem> ThirdpartyItems { get; set; } = new List<ThirdpartyItem>();

    public virtual ICollection<ThirdpartySiteOrdering> ThirdpartySiteOrderings { get; set; } = new List<ThirdpartySiteOrdering>();

    public virtual ICollection<ThirdpartySiteVisitSchedule> ThirdpartySiteVisitSchedules { get; set; } = new List<ThirdpartySiteVisitSchedule>();

    public virtual ICollection<ThirdpartysitecategoryValue> ThirdpartysitecategoryValues { get; set; } = new List<ThirdpartysitecategoryValue>();

    public virtual ICollection<ThpTransactiontype> ThpTransactiontypes { get; set; } = new List<ThpTransactiontype>();

    public virtual Codesc ThpsCdIdBstNavigation { get; set; } = null!;

    public virtual GeoLocation? ThpsGl { get; set; }

    public virtual ICollection<ThpsInventory> ThpsInventories { get; set; } = new List<ThpsInventory>();

    public virtual ICollection<ThpsInventoryheaderThp> ThpsInventoryheaderThps { get; set; } = new List<ThpsInventoryheaderThp>();

    public virtual ICollection<ThpsItemcontainer> ThpsItemcontainers { get; set; } = new List<ThpsItemcontainer>();

    public virtual Thirdparty ThpsThp { get; set; } = null!;

    public virtual ICollection<TransactionDelivery> TransactionDeliveryTsdThpsIdBillNavigations { get; set; } = new List<TransactionDelivery>();

    public virtual ICollection<TransactionDelivery> TransactionDeliveryTsdThpsIdShipNavigations { get; set; } = new List<TransactionDelivery>();

    public virtual ICollection<Transaction> TransactionTsThpsIdBillNavigations { get; set; } = new List<Transaction>();

    public virtual ICollection<Transaction> TransactionTsThpsIdShipNavigations { get; set; } = new List<Transaction>();

    public virtual ICollection<UserThirdpartySite> UserThirdpartySites { get; set; } = new List<UserThirdpartySite>();

    public virtual ICollection<Visit> Visits { get; set; } = new List<Visit>();
}
