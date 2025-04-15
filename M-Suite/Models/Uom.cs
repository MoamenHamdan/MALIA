using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Uom
{
    public int UomId { get; set; }

    public string UomCode { get; set; } = null!;

    public string? UomNameLan1 { get; set; }

    public string? UomNameLan2 { get; set; }

    public string? UomNameLan3 { get; set; }

    public short? UomRoundingPrecision { get; set; }

    public short UomIsBase { get; set; }

    public int? UomIsSaleable { get; set; }

    public string? UomOrder { get; set; }

    public virtual ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();

    public virtual ICollection<ItemUom> ItemUoms { get; set; } = new List<ItemUom>();

    public virtual ICollection<ItemWarehouse> ItemWarehouses { get; set; } = new List<ItemWarehouse>();

    public virtual ICollection<ItemcontainerDetail> ItemcontainerDetails { get; set; } = new List<ItemcontainerDetail>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ICollection<ListpriceItem> ListpriceItems { get; set; } = new List<ListpriceItem>();

    public virtual ICollection<MovementItem> MovementItems { get; set; } = new List<MovementItem>();

    public virtual ICollection<OperationBatchItem> OperationBatchItems { get; set; } = new List<OperationBatchItem>();

    public virtual ICollection<OperationItem> OperationItems { get; set; } = new List<OperationItem>();

    public virtual ICollection<PromotionDetail> PromotionDetailPndUomIdBuyNavigations { get; set; } = new List<PromotionDetail>();

    public virtual ICollection<PromotionDetail> PromotionDetailPndUomIdGetNavigations { get; set; } = new List<PromotionDetail>();

    public virtual ICollection<PromotionGive> PromotionGives { get; set; } = new List<PromotionGive>();

    public virtual ICollection<PromotionLine> PromotionLinePnlUomIdBuyNavigations { get; set; } = new List<PromotionLine>();

    public virtual ICollection<PromotionLine> PromotionLinePnlUomIdGetNavigations { get; set; } = new List<PromotionLine>();

    public virtual ICollection<PromotionsliceBuyDetail> PromotionsliceBuyDetailPsbdUomIdBuyNavigations { get; set; } = new List<PromotionsliceBuyDetail>();

    public virtual ICollection<PromotionsliceBuyDetail> PromotionsliceBuyDetailPsbdUomIdGetNavigations { get; set; } = new List<PromotionsliceBuyDetail>();

    public virtual ICollection<PromotionsliceGetDetail> PromotionsliceGetDetails { get; set; } = new List<PromotionsliceGetDetail>();

    public virtual ICollection<TemplateItem> TemplateItems { get; set; } = new List<TemplateItem>();

    public virtual ICollection<ThpsInventoryDetail> ThpsInventoryDetails { get; set; } = new List<ThpsInventoryDetail>();

    public virtual ICollection<TransactionDeliveryItem> TransactionDeliveryItems { get; set; } = new List<TransactionDeliveryItem>();

    public virtual ICollection<TransactionItem> TransactionItems { get; set; } = new List<TransactionItem>();
}
