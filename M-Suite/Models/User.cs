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

    public virtual ICollection<ApiSession> ApiSessions { get; set; } = new List<ApiSession>();

    public virtual ICollection<AppImage> AppImages { get; set; } = new List<AppImage>();

    public virtual ICollection<AppMedium> AppMedia { get; set; } = new List<AppMedium>();

    public virtual ICollection<ApprovalConfig> ApprovalConfigAcUs { get; set; } = new List<ApprovalConfig>();

    public virtual ICollection<ApprovalConfig> ApprovalConfigAcUsIdCrNavigations { get; set; } = new List<ApprovalConfig>();

    public virtual ICollection<ApprovalRequest> ApprovalRequestArUsIdAppNavigations { get; set; } = new List<ApprovalRequest>();

    public virtual ICollection<ApprovalRequest> ApprovalRequestArUsIdCrNavigations { get; set; } = new List<ApprovalRequest>();

    public virtual ICollection<ApprovalRequest> ApprovalRequestArUsIdReqNavigations { get; set; } = new List<ApprovalRequest>();

    public virtual ICollection<ApprovalconfigMember> ApprovalconfigMembers { get; set; } = new List<ApprovalconfigMember>();

    public virtual ICollection<BeginDay> BeginDays { get; set; } = new List<BeginDay>();

    public virtual ICollection<CallCycleUserHelper> CallCycleUserHelpers { get; set; } = new List<CallCycleUserHelper>();

    public virtual ICollection<CallCycle> CallCycles { get; set; } = new List<CallCycle>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<DueInvoice> DueInvoices { get; set; } = new List<DueInvoice>();

    public virtual ICollection<GeoTag> GeoTags { get; set; } = new List<GeoTag>();

    public virtual ICollection<Inspection> Inspections { get; set; } = new List<Inspection>();

    public virtual ICollection<Inventory1> Inventory1s { get; set; } = new List<Inventory1>();

    public virtual ICollection<InventoryHeader> InventoryHeaders { get; set; } = new List<InventoryHeader>();

    public virtual ICollection<User> InverseUsUs { get; set; } = new List<User>();

    public virtual ICollection<MovementItemHistory> MovementItemHistoryMvihUsIdAppNavigations { get; set; } = new List<MovementItemHistory>();

    public virtual ICollection<MovementItemHistory> MovementItemHistoryMvihUsIdCrNavigations { get; set; } = new List<MovementItemHistory>();

    public virtual ICollection<MovementSequence> MovementSequences { get; set; } = new List<MovementSequence>();

    public virtual ICollection<MovementStatusHistory> MovementStatusHistories { get; set; } = new List<MovementStatusHistory>();

    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();

    public virtual ICollection<OperationBatch> OperationBatches { get; set; } = new List<OperationBatch>();

    public virtual ICollection<Operation> Operations { get; set; } = new List<Operation>();

    public virtual ICollection<PaymentStatusHistory> PaymentStatusHistories { get; set; } = new List<PaymentStatusHistory>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<PaymenttypeSequence> PaymenttypeSequences { get; set; } = new List<PaymenttypeSequence>();

    public virtual ICollection<PlanogramDetail> PlanogramDetails { get; set; } = new List<PlanogramDetail>();

    public virtual ICollection<PlanogramUser> PlanogramUsers { get; set; } = new List<PlanogramUser>();

    public virtual ICollection<Planogram> Planograms { get; set; } = new List<Planogram>();

    public virtual ICollection<ProspectThirdpartysite> ProspectThirdpartysitePthpsUsIdCrNavigations { get; set; } = new List<ProspectThirdpartysite>();

    public virtual ICollection<ProspectThirdpartysite> ProspectThirdpartysitePthpsUsIdUpNavigations { get; set; } = new List<ProspectThirdpartysite>();

    public virtual ICollection<QlikDashboardUser> QlikDashboardUsers { get; set; } = new List<QlikDashboardUser>();

    public virtual ICollection<ReportRequest> ReportRequests { get; set; } = new List<ReportRequest>();

    public virtual ICollection<Route> Routes { get; set; } = new List<Route>();

    public virtual ICollection<SalesassetInventory> SalesassetInventories { get; set; } = new List<SalesassetInventory>();

    public virtual ICollection<ServiceTicket> ServiceTickets { get; set; } = new List<ServiceTicket>();

    public virtual ICollection<Survey2Detail> Survey2DetailSrdUs { get; set; } = new List<Survey2Detail>();

    public virtual ICollection<Survey2Detail> Survey2DetailSrdUsIdCrNavigations { get; set; } = new List<Survey2Detail>();

    public virtual ICollection<SurveyUser> SurveyUsers { get; set; } = new List<SurveyUser>();

    public virtual ICollection<TargetDetail> TargetDetails { get; set; } = new List<TargetDetail>();

    public virtual ICollection<TaskDetail> TaskDetails { get; set; } = new List<TaskDetail>();

    public virtual ICollection<TemplateUser> TemplateUsers { get; set; } = new List<TemplateUser>();

    public virtual ICollection<Template> Templates { get; set; } = new List<Template>();

    public virtual ICollection<ThirdpartySiteVisitSchedule> ThirdpartySiteVisitSchedules { get; set; } = new List<ThirdpartySiteVisitSchedule>();

    public virtual ICollection<ThpsInventoryheaderUser> ThpsInventoryheaderUsers { get; set; } = new List<ThpsInventoryheaderUser>();

    public virtual ICollection<TransactionDelivery> TransactionDeliveries { get; set; } = new List<TransactionDelivery>();

    public virtual ICollection<TransactionStatusHistory> TransactionStatusHistories { get; set; } = new List<TransactionStatusHistory>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual Codesc? UsCdIdGenNavigation { get; set; }

    public virtual Codesc? UsCdIdTtlNavigation { get; set; }

    public virtual Thirdparty? UsThp { get; set; }

    public virtual User? UsUs { get; set; }

    public virtual ICollection<UserAppliSetting> UserAppliSettings { get; set; } = new List<UserAppliSetting>();

    public virtual ICollection<UserBusinessUnit> UserBusinessUnits { get; set; } = new List<UserBusinessUnit>();

    public virtual ICollection<UserConnectionInfo> UserConnectionInfos { get; set; } = new List<UserConnectionInfo>();

    public virtual ICollection<UserDeviceInfo> UserDeviceInfos { get; set; } = new List<UserDeviceInfo>();

    public virtual ICollection<UserDeviceLock> UserDeviceLocks { get; set; } = new List<UserDeviceLock>();

    public virtual ICollection<UserFinance> UserFinances { get; set; } = new List<UserFinance>();

    public virtual ICollection<UserItemQuotum> UserItemQuota { get; set; } = new List<UserItemQuotum>();

    public virtual ICollection<UserItemQuotaGroup> UserItemQuotaGroups { get; set; } = new List<UserItemQuotaGroup>();

    public virtual ICollection<UserItemcategory> UserItemcategories { get; set; } = new List<UserItemcategory>();

    public virtual ICollection<UserMobileProfile> UserMobileProfiles { get; set; } = new List<UserMobileProfile>();

    public virtual ICollection<UserPayment> UserPaymentUpUs { get; set; } = new List<UserPayment>();

    public virtual ICollection<UserPayment> UserPaymentUpUsIdCashierNavigations { get; set; } = new List<UserPayment>();

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();

    public virtual ICollection<UserQlikInfo> UserQlikInfos { get; set; } = new List<UserQlikInfo>();

    public virtual ICollection<UserThirdparty> UserThirdparties { get; set; } = new List<UserThirdparty>();

    public virtual ICollection<UserThirdpartySite> UserThirdpartySites { get; set; } = new List<UserThirdpartySite>();

    public virtual ICollection<UserThpsTransactiontype> UserThpsTransactiontypes { get; set; } = new List<UserThpsTransactiontype>();

    public virtual ICollection<UserTransactiontype> UserTransactiontypes { get; set; } = new List<UserTransactiontype>();

    public virtual ICollection<UserWarehouse> UserWarehouses { get; set; } = new List<UserWarehouse>();

    public virtual ICollection<UserWebSetting> UserWebSettings { get; set; } = new List<UserWebSetting>();

    public virtual ICollection<UsersCalendar> UsersCalendars { get; set; } = new List<UsersCalendar>();

    public virtual ICollection<Visit> Visits { get; set; } = new List<Visit>();
}
