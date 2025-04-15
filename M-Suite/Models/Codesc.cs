using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Codesc
{
    public int CdId { get; set; }

    public int? CdCdId { get; set; }

    public int CdFcId { get; set; }

    public int? CdMdId { get; set; }

    public int? CdBuId { get; set; }

    public string CdFcCode { get; set; } = null!;

    public string CdCode { get; set; } = null!;

    public string? CdDescriptionLan2 { get; set; }

    public string? CdDescriptionLan1 { get; set; }

    public string? CdDescriptionLan3 { get; set; }

    public int? CdNum1 { get; set; }

    public int? CdNum2 { get; set; }

    public string? CdText1 { get; set; }

    public string? CdText2 { get; set; }

    public DateTime? CdDate1 { get; set; }

    public DateTime? CdDate2 { get; set; }

    public DateTime CdCreateDate { get; set; }

    public DateTime CdModifiedDate { get; set; }

    public short CdLevel { get; set; }

    public short CdHasChildren { get; set; }

    public short? CdActive { get; set; }

    public short? CdIsSystem { get; set; }

    public virtual ICollection<AppImage> AppImages { get; set; } = new List<AppImage>();

    public virtual ICollection<AppMedium> AppMedia { get; set; } = new List<AppMedium>();

    public virtual ICollection<AppliSetting> AppliSettings { get; set; } = new List<AppliSetting>();

    public virtual ICollection<ApprovalConfig> ApprovalConfigs { get; set; } = new List<ApprovalConfig>();

    public virtual ICollection<ApprovalRequest> ApprovalRequestArCdIdArstsNavigations { get; set; } = new List<ApprovalRequest>();

    public virtual ICollection<ApprovalRequest> ApprovalRequestArCdIdArtNavigations { get; set; } = new List<ApprovalRequest>();

    public virtual ICollection<ApprovalRequest> ApprovalRequestArCdIdArtblNavigations { get; set; } = new List<ApprovalRequest>();

    public virtual ICollection<ApprovalRequestDetail> ApprovalRequestDetails { get; set; } = new List<ApprovalRequestDetail>();

    public virtual ICollection<BeginDay> BeginDays { get; set; } = new List<BeginDay>();

    public virtual ICollection<CallCycleDetail> CallCycleDetails { get; set; } = new List<CallCycleDetail>();

    public virtual ICollection<CallCycle> CallCycles { get; set; } = new List<CallCycle>();

    public virtual BusinessUnit? CdBu { get; set; }

    public virtual Codesc? CdCd { get; set; }

    public virtual FamilyCodesc CdFc { get; set; } = null!;

    public virtual Module? CdMd { get; set; }

    public virtual ICollection<ContractTerm> ContractTerms { get; set; } = new List<ContractTerm>();

    public virtual ICollection<Creditdebitnote> CreditdebitnoteCdnCdIdCdnrsnNavigations { get; set; } = new List<Creditdebitnote>();

    public virtual ICollection<Creditdebitnote> CreditdebitnoteCdnCdIdCdtypNavigations { get; set; } = new List<Creditdebitnote>();

    public virtual ICollection<Creditdebitnote> CreditdebitnoteCdnCdIdCurNavigations { get; set; } = new List<Creditdebitnote>();

    public virtual ICollection<Display> DisplayCds { get; set; } = new List<Display>();

    public virtual ICollection<Display> DisplayDspCdIdDsptpNavigations { get; set; } = new List<Display>();

    public virtual ICollection<DueInvoice> DueInvoiceDiCdIdCurNavigations { get; set; } = new List<DueInvoice>();

    public virtual ICollection<DueInvoice> DueInvoiceDiCdIdSrcNavigations { get; set; } = new List<DueInvoice>();

    public virtual ICollection<DynamicQuery> DynamicQueries { get; set; } = new List<DynamicQuery>();

    public virtual ICollection<GeoTag> GeoTags { get; set; } = new List<GeoTag>();

    public virtual ICollection<Inspection> InspectionInCdIdRemarkNavigations { get; set; } = new List<Inspection>();

    public virtual ICollection<Inspection> InspectionInCdIdTypeNavigations { get; set; } = new List<Inspection>();

    public virtual ICollection<InspectionList> InspectionLists { get; set; } = new List<InspectionList>();

    public virtual ICollection<InspectionSurvey> InspectionSurveys { get; set; } = new List<InspectionSurvey>();

    public virtual ICollection<Inventory1> Inventory1s { get; set; } = new List<Inventory1>();

    public virtual ICollection<InventoryHeader> InventoryHeaderIvhCdIdIvsNavigations { get; set; } = new List<InventoryHeader>();

    public virtual ICollection<InventoryHeader> InventoryHeaderIvhCdIdIvtNavigations { get; set; } = new List<InventoryHeader>();

    public virtual ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();

    public virtual ICollection<InventorystatusTransition> InventorystatusTransitionIvstCdIdIvsFromNavigations { get; set; } = new List<InventorystatusTransition>();

    public virtual ICollection<InventorystatusTransition> InventorystatusTransitionIvstCdIdIvsToNavigations { get; set; } = new List<InventorystatusTransition>();

    public virtual ICollection<InventorystatusTransition> InventorystatusTransitionIvstCdIdIvts { get; set; } = new List<InventorystatusTransition>();

    public virtual ICollection<Codesc> InverseCdCd { get; set; } = new List<Codesc>();

    public virtual ICollection<ItemFinance> ItemFinances { get; set; } = new List<ItemFinance>();

    public virtual ICollection<Item> ItemItCdIdIbdNavigations { get; set; } = new List<Item>();

    public virtual ICollection<Item> ItemItCdIdIgpNavigations { get; set; } = new List<Item>();

    public virtual ICollection<Item> ItemItCdIdIsgNavigations { get; set; } = new List<Item>();

    public virtual ICollection<Item> ItemItCdIdItgNavigations { get; set; } = new List<Item>();

    public virtual ICollection<Item> ItemItCdIdItpNavigations { get; set; } = new List<Item>();

    public virtual ICollection<ItemMsl> ItemMsls { get; set; } = new List<ItemMsl>();

    public virtual ICollection<ItemcategoryGroup> ItemcategoryGroups { get; set; } = new List<ItemcategoryGroup>();

    public virtual ICollection<Listprice> Listprices { get; set; } = new List<Listprice>();

    public virtual ICollection<Movement> MovementMvCdIdCmsNavigations { get; set; } = new List<Movement>();

    public virtual ICollection<Movement> MovementMvCdIdSrcNavigations { get; set; } = new List<Movement>();

    public virtual ICollection<Movementtype2> Movementtype2MvtCdIdModNavigations { get; set; } = new List<Movementtype2>();

    public virtual ICollection<Movementtype2> Movementtype2MvtCdIdTptNavigations { get; set; } = new List<Movementtype2>();

    public virtual ICollection<NoVisit> NoVisits { get; set; } = new List<NoVisit>();

    public virtual ICollection<Operation> OperationOpCdIdCmsNavigations { get; set; } = new List<Operation>();

    public virtual ICollection<Operation> OperationOpCdIdCurNavigations { get; set; } = new List<Operation>();

    public virtual ICollection<Operation> OperationOpCdIdSrcNavigations { get; set; } = new List<Operation>();

    public virtual ICollection<PaymentDetail> PaymentDetailPadCdIdBnkNavigations { get; set; } = new List<PaymentDetail>();

    public virtual ICollection<PaymentDetail> PaymentDetailPadCdIdCctNavigations { get; set; } = new List<PaymentDetail>();

    public virtual ICollection<PaymentDetail> PaymentDetailPadCdIdCurNavigations { get; set; } = new List<PaymentDetail>();

    public virtual ICollection<PaymentDetail> PaymentDetailPadCdIdPamNavigations { get; set; } = new List<PaymentDetail>();

    public virtual ICollection<PaymentInvoice> PaymentInvoices { get; set; } = new List<PaymentInvoice>();

    public virtual ICollection<Payment> PaymentPaCdIdCurNavigations { get; set; } = new List<Payment>();

    public virtual ICollection<Payment> PaymentPaCdIdPatNavigations { get; set; } = new List<Payment>();

    public virtual ICollection<Payment> PaymentPaCdIdSrcNavigations { get; set; } = new List<Payment>();

    public virtual ICollection<PhysicalLocation> PhysicalLocations { get; set; } = new List<PhysicalLocation>();

    public virtual ICollection<PromotionDetail> PromotionDetailPndCdIdPecNavigations { get; set; } = new List<PromotionDetail>();

    public virtual ICollection<PromotionDetail> PromotionDetailPndCdIdPilNavigations { get; set; } = new List<PromotionDetail>();

    public virtual ICollection<PromotionDetail> PromotionDetailPndCdIdPrtypeBuyNavigations { get; set; } = new List<PromotionDetail>();

    public virtual ICollection<PromotionDetail> PromotionDetailPndCdIdPrtypeGetNavigations { get; set; } = new List<PromotionDetail>();

    public virtual ICollection<PromotionDetailQualifier> PromotionDetailQualifiers { get; set; } = new List<PromotionDetailQualifier>();

    public virtual ICollection<PromotionMaster> PromotionMasterPnCdIdCqlNavigations { get; set; } = new List<PromotionMaster>();

    public virtual ICollection<PromotionMaster> PromotionMasterPnCdIdPpbNavigations { get; set; } = new List<PromotionMaster>();

    public virtual ICollection<PromotionMaster> PromotionMasterPnCdIdPtpNavigations { get; set; } = new List<PromotionMaster>();

    public virtual ICollection<PromotionMasterQualifier> PromotionMasterQualifiers { get; set; } = new List<PromotionMasterQualifier>();

    public virtual ICollection<ProspectThirdpartysite> ProspectThirdpartysitePthpsCdIdBstNavigations { get; set; } = new List<ProspectThirdpartysite>();

    public virtual ICollection<ProspectThirdpartysite> ProspectThirdpartysitePthpsCdIdPstsNavigations { get; set; } = new List<ProspectThirdpartysite>();

    public virtual ICollection<ProspectThirdpartysite> ProspectThirdpartysitePthpsCdIdTpgNavigations { get; set; } = new List<ProspectThirdpartysite>();

    public virtual ICollection<ReportRequest> ReportRequests { get; set; } = new List<ReportRequest>();

    public virtual ICollection<SalesAsset> SalesAssetAtCdIdAtgNavigations { get; set; } = new List<SalesAsset>();

    public virtual ICollection<SalesAsset> SalesAssetAtCdIdAtnNavigations { get; set; } = new List<SalesAsset>();

    public virtual ICollection<SalesAsset> SalesAssetAtCdIdAtsNavigations { get; set; } = new List<SalesAsset>();

    public virtual ICollection<SalesassetCategoryGroup> SalesassetCategoryGroups { get; set; } = new List<SalesassetCategoryGroup>();

    public virtual ICollection<ServiceTicketDetail> ServiceTicketDetailSvtdCdIdSvtdcondNavigations { get; set; } = new List<ServiceTicketDetail>();

    public virtual ICollection<ServiceTicketDetail> ServiceTicketDetailSvtdCdIdSvtdrsNavigations { get; set; } = new List<ServiceTicketDetail>();

    public virtual ICollection<ServiceTicketStatusHistory> ServiceTicketStatusHistories { get; set; } = new List<ServiceTicketStatusHistory>();

    public virtual ICollection<ServiceTicket> ServiceTicketSvtCdIdStcoiNavigations { get; set; } = new List<ServiceTicket>();

    public virtual ICollection<ServiceTicket> ServiceTicketSvtCdIdStprNavigations { get; set; } = new List<ServiceTicket>();

    public virtual ICollection<ServiceTicket> ServiceTicketSvtCdIdStstsNavigations { get; set; } = new List<ServiceTicket>();

    public virtual ICollection<ServiceTicket> ServiceTicketSvtCdIdSttNavigations { get; set; } = new List<ServiceTicket>();

    public virtual ICollection<Survey2BusinessUnit> Survey2BusinessUnits { get; set; } = new List<Survey2BusinessUnit>();

    public virtual ICollection<Survey2Question> Survey2QuestionSrqCdIdAntNavigations { get; set; } = new List<Survey2Question>();

    public virtual ICollection<Survey2Question> Survey2QuestionSrqCdIdFrqNavigations { get; set; } = new List<Survey2Question>();

    public virtual ICollection<Survey2Question> Survey2QuestionSrqCdIdSgrNavigations { get; set; } = new List<Survey2Question>();

    public virtual ICollection<Survey2Question> Survey2QuestionSrqCdIdSqaNavigations { get; set; } = new List<Survey2Question>();

    public virtual ICollection<Survey2> Survey2SrCdIdSraNavigations { get; set; } = new List<Survey2>();

    public virtual ICollection<Survey2> Survey2SrCdIdSrtNavigations { get; set; } = new List<Survey2>();

    public virtual ICollection<Survey2Status> Survey2Statuses { get; set; } = new List<Survey2Status>();

    public virtual ICollection<Survey2answerDetail> Survey2answerDetails { get; set; } = new List<Survey2answerDetail>();

    public virtual ICollection<Survey2answer> Survey2answers { get; set; } = new List<Survey2answer>();

    public virtual ICollection<Survey2detailPromotionType> Survey2detailPromotionTypes { get; set; } = new List<Survey2detailPromotionType>();

    public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; } = new List<SurveyQuestion>();

    public virtual ICollection<SurveyResult> SurveyResults { get; set; } = new List<SurveyResult>();

    public virtual ICollection<Survey> SurveySrCdIdSraNavigations { get; set; } = new List<Survey>();

    public virtual ICollection<Survey> SurveySrCdIdSrtNavigations { get; set; } = new List<Survey>();

    public virtual ICollection<Surveyanswer> Surveyanswers { get; set; } = new List<Surveyanswer>();

    public virtual ICollection<Target> TargetCodCdId3Navigations { get; set; } = new List<Target>();

    public virtual ICollection<Target> TargetTaCdIdCurNavigations { get; set; } = new List<Target>();

    public virtual ICollection<Target> TargetTaCdIdTrcNavigations { get; set; } = new List<Target>();

    public virtual ICollection<Target> TargetTaCdIdTrs1Navigations { get; set; } = new List<Target>();

    public virtual ICollection<Target> TargetTaCdIdTrs2Navigations { get; set; } = new List<Target>();

    public virtual ICollection<Target> TargetTaCdIdTrs3Navigations { get; set; } = new List<Target>();

    public virtual ICollection<Target> TargetTaCdIdTrs4Navigations { get; set; } = new List<Target>();

    public virtual ICollection<Target> TargetTaCdIdTrs5Navigations { get; set; } = new List<Target>();

    public virtual ICollection<Target> TargetTaCdIdTrtNavigations { get; set; } = new List<Target>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();

    public virtual ICollection<Tax> Taxes { get; set; } = new List<Tax>();

    public virtual ICollection<Template> Templates { get; set; } = new List<Template>();

    public virtual ICollection<ThirdpartyBillShip> ThirdpartyBillShips { get; set; } = new List<ThirdpartyBillShip>();

    public virtual ICollection<ThirdpartyFinance> ThirdpartyFinances { get; set; } = new List<ThirdpartyFinance>();

    public virtual ICollection<ThirdpartyGroupCategory> ThirdpartyGroupCategories { get; set; } = new List<ThirdpartyGroupCategory>();

    public virtual ICollection<ThirdpartyPaymethod> ThirdpartyPaymethods { get; set; } = new List<ThirdpartyPaymethod>();

    public virtual ICollection<ThirdpartySiteVisitSchedule> ThirdpartySiteVisitScheduleThpsvsCdIdTmsNavigations { get; set; } = new List<ThirdpartySiteVisitSchedule>();

    public virtual ICollection<ThirdpartySiteVisitSchedule> ThirdpartySiteVisitScheduleThpsvsCdIdTmsdNavigations { get; set; } = new List<ThirdpartySiteVisitSchedule>();

    public virtual ICollection<ThirdpartySite> ThirdpartySites { get; set; } = new List<ThirdpartySite>();

    public virtual ICollection<Thirdparty> ThirdpartyThpCdIdTpgNavigations { get; set; } = new List<Thirdparty>();

    public virtual ICollection<Thirdparty> ThirdpartyThpCdIdTpsNavigations { get; set; } = new List<Thirdparty>();

    public virtual ICollection<ThpsInventory> ThpsInventories { get; set; } = new List<ThpsInventory>();

    public virtual ICollection<ThpsInventoryheaderstatusTransition> ThpsInventoryheaderstatusTransitionTivhstCdIdTivsFromNavigations { get; set; } = new List<ThpsInventoryheaderstatusTransition>();

    public virtual ICollection<ThpsInventoryheaderstatusTransition> ThpsInventoryheaderstatusTransitionTivhstCdIdTivsToNavigations { get; set; } = new List<ThpsInventoryheaderstatusTransition>();

    public virtual ICollection<ThpsInventoryheaderstatusTransition> ThpsInventoryheaderstatusTransitionTivhstCdIdTivtNavigations { get; set; } = new List<ThpsInventoryheaderstatusTransition>();

    public virtual ICollection<ThpsInventorystatusTransition> ThpsInventorystatusTransitionTivstCdIdTivsFromNavigations { get; set; } = new List<ThpsInventorystatusTransition>();

    public virtual ICollection<ThpsInventorystatusTransition> ThpsInventorystatusTransitionTivstCdIdTivsToNavigations { get; set; } = new List<ThpsInventorystatusTransition>();

    public virtual ICollection<ThpsInventorystatusTransition> ThpsInventorystatusTransitionTivstCdIdTivtNavigations { get; set; } = new List<ThpsInventorystatusTransition>();

    public virtual ICollection<TransactionDelivery> TransactionDeliveryTsdCdIdCmsNavigations { get; set; } = new List<TransactionDelivery>();

    public virtual ICollection<TransactionDelivery> TransactionDeliveryTsdCdIdCurNavigations { get; set; } = new List<TransactionDelivery>();

    public virtual ICollection<TransactionDelivery> TransactionDeliveryTsdCdIdSrcNavigations { get; set; } = new List<TransactionDelivery>();

    public virtual ICollection<TransactionReason> TransactionReasons { get; set; } = new List<TransactionReason>();

    public virtual ICollection<Transaction> TransactionTsCdIdCmsNavigations { get; set; } = new List<Transaction>();

    public virtual ICollection<Transaction> TransactionTsCdIdCurNavigations { get; set; } = new List<Transaction>();

    public virtual ICollection<Transaction> TransactionTsCdIdSrcNavigations { get; set; } = new List<Transaction>();

    public virtual ICollection<Transactiontype1> Transactiontype1s { get; set; } = new List<Transactiontype1>();

    public virtual ICollection<UserFinance> UserFinances { get; set; } = new List<UserFinance>();

    public virtual ICollection<UserPaymentLine> UserPaymentLineUplCdIdBankNavigations { get; set; } = new List<UserPaymentLine>();

    public virtual ICollection<UserPaymentLine> UserPaymentLineUplCdIdCurNavigations { get; set; } = new List<UserPaymentLine>();

    public virtual ICollection<UserPaymentLine> UserPaymentLineUplCdIdPamNavigations { get; set; } = new List<UserPaymentLine>();

    public virtual ICollection<UserPayment> UserPayments { get; set; } = new List<UserPayment>();

    public virtual ICollection<User> UserUsCdIdGenNavigations { get; set; } = new List<User>();

    public virtual ICollection<User> UserUsCdIdTtlNavigations { get; set; } = new List<User>();

    public virtual ICollection<UsersCalendar> UsersCalendars { get; set; } = new List<UsersCalendar>();

    public virtual ICollection<VisitReason> VisitReasons { get; set; } = new List<VisitReason>();

    public virtual ICollection<Visit> Visits { get; set; } = new List<Visit>();
}
