using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Item
{
    public int ItId { get; set; }

    public int? ItItId { get; set; }

    public int ItUomId { get; set; }

    public int ItCdIdItg { get; set; }

    public int? ItCdIdIbd { get; set; }

    public int? ItCdIdIgp { get; set; }

    public int? ItCdIdIsg { get; set; }

    public int? ItCdIdItp { get; set; }

    public string ItCode { get; set; } = null!;

    public string ItDescriptionLan1 { get; set; } = null!;

    public string? ItDescriptionLan2 { get; set; }

    public string? ItDescriptionLan3 { get; set; }

    public decimal? ItWeight { get; set; }

    public short ItHasLot { get; set; }

    public short ItHasProductionDate { get; set; }

    public short ItHasExpiryDate { get; set; }

    public short? ItHasMultipleUom { get; set; }

    public short? ItHasSerial { get; set; }

    public short? ItIsDescription { get; set; }

    public short? ItIsSaleable { get; set; }

    public short? ItIsService { get; set; }

    public short? ItIsAsset { get; set; }

    public short ItActive { get; set; }

    public string? ItImpUid { get; set; }

    public int? ItOrder { get; set; }

    public short? ItIsBadReturn { get; set; }

    public virtual ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();

    public virtual ICollection<Item> InverseItIt { get; set; } = new List<Item>();

    public virtual Codesc? ItCdIdIbdNavigation { get; set; }

    public virtual Codesc? ItCdIdIgpNavigation { get; set; }

    public virtual Codesc? ItCdIdIsgNavigation { get; set; }

    public virtual Codesc ItCdIdItgNavigation { get; set; } = null!;

    public virtual Codesc? ItCdIdItpNavigation { get; set; }

    public virtual Item? ItIt { get; set; }

    public virtual Uom ItUom { get; set; } = null!;

    public virtual ICollection<ItemCategoryValue> ItemCategoryValues { get; set; } = new List<ItemCategoryValue>();

    public virtual ICollection<ItemFinance> ItemFinances { get; set; } = new List<ItemFinance>();

    public virtual ICollection<ItemLotDate> ItemLotDates { get; set; } = new List<ItemLotDate>();

    public virtual ICollection<ItemMslDetail> ItemMslDetails { get; set; } = new List<ItemMslDetail>();

    public virtual ICollection<ItemPhoto> ItemPhotos { get; set; } = new List<ItemPhoto>();

    public virtual ICollection<ItemTax> ItemTaxes { get; set; } = new List<ItemTax>();

    public virtual ICollection<ItemUom> ItemUoms { get; set; } = new List<ItemUom>();

    public virtual ICollection<ItemWarehouse> ItemWarehouses { get; set; } = new List<ItemWarehouse>();

    public virtual ICollection<ItemcontainerDetail> ItemcontainerDetails { get; set; } = new List<ItemcontainerDetail>();

    public virtual ICollection<ItmThpTransactiontype> ItmThpTransactiontypes { get; set; } = new List<ItmThpTransactiontype>();

    public virtual ICollection<ItmThpsUomTransactiontypeException> ItmThpsUomTransactiontypeExceptions { get; set; } = new List<ItmThpsUomTransactiontypeException>();

    public virtual ICollection<ItmThpsUomTransactiontype> ItmThpsUomTransactiontypes { get; set; } = new List<ItmThpsUomTransactiontype>();

    public virtual ICollection<ListpriceItem> ListpriceItems { get; set; } = new List<ListpriceItem>();

    public virtual ICollection<MovementItemHistory> MovementItemHistories { get; set; } = new List<MovementItemHistory>();

    public virtual ICollection<MovementItem> MovementItems { get; set; } = new List<MovementItem>();

    public virtual ICollection<OperationBatchItem> OperationBatchItems { get; set; } = new List<OperationBatchItem>();

    public virtual ICollection<OperationItem> OperationItems { get; set; } = new List<OperationItem>();

    public virtual ICollection<ServiceTicket> ServiceTickets { get; set; } = new List<ServiceTicket>();

    public virtual ICollection<TargetDetail> TargetDetails { get; set; } = new List<TargetDetail>();

    public virtual ICollection<TemplateItem> TemplateItems { get; set; } = new List<TemplateItem>();

    public virtual ThirdpartyItem? ThirdpartyItem { get; set; }

    public virtual ICollection<ThpsInventoryDetail> ThpsInventoryDetails { get; set; } = new List<ThpsInventoryDetail>();

    public virtual ICollection<TransactionDeliveryItem> TransactionDeliveryItems { get; set; } = new List<TransactionDeliveryItem>();

    public virtual ICollection<TransactionItem> TransactionItems { get; set; } = new List<TransactionItem>();

    public virtual ICollection<UserItemQuotaDetail> UserItemQuotaDetails { get; set; } = new List<UserItemQuotaDetail>();
}
