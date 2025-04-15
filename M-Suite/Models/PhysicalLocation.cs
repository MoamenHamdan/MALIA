using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class PhysicalLocation
{
    public int PlId { get; set; }

    public int? PlPlId { get; set; }

    public int PlCdIdPlt { get; set; }

    public int PlMdId { get; set; }

    public short? PlLevel { get; set; }

    public string PlCode { get; set; } = null!;

    public string PlDescriptionLan1 { get; set; } = null!;

    public string? PlDescriptionLan2 { get; set; }

    public string? PlDescriptionLan3 { get; set; }

    public int? PlBuId { get; set; }

    public short? PlActive { get; set; }

    public string? PlImpUid { get; set; }

    public virtual ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();

    public virtual ICollection<InventoryLinePhysicallocation> InventoryLinePhysicallocations { get; set; } = new List<InventoryLinePhysicallocation>();

    public virtual ICollection<PhysicalLocation> InversePlPl { get; set; } = new List<PhysicalLocation>();

    public virtual ICollection<ItemWarehouse> ItemWarehouses { get; set; } = new List<ItemWarehouse>();

    public virtual ICollection<Movement> MovementMvPlIdWhsFromNavigations { get; set; } = new List<Movement>();

    public virtual ICollection<Movement> MovementMvPlIdWhsToNavigations { get; set; } = new List<Movement>();

    public virtual ICollection<OperationBatchItemDetail> OperationBatchItemDetailOpbidPlIdLocNavigations { get; set; } = new List<OperationBatchItemDetail>();

    public virtual ICollection<OperationBatchItemDetail> OperationBatchItemDetailOpbidPlIdWhsNavigations { get; set; } = new List<OperationBatchItemDetail>();

    public virtual ICollection<OperationBatchItem> OperationBatchItemOpbiPlIdLocNavigations { get; set; } = new List<OperationBatchItem>();

    public virtual ICollection<OperationBatchItem> OperationBatchItemOpbiPlIdWhsNavigations { get; set; } = new List<OperationBatchItem>();

    public virtual ICollection<OperationBatch> OperationBatchOpbPlIdWhsNavigations { get; set; } = new List<OperationBatch>();

    public virtual ICollection<OperationBatch> OperationBatchOpbPlIdWhsToNavigations { get; set; } = new List<OperationBatch>();

    public virtual ICollection<OperationItemDetail> OperationItemDetailOpidPlIdLocNavigations { get; set; } = new List<OperationItemDetail>();

    public virtual ICollection<OperationItemDetail> OperationItemDetailOpidPlIdWhsNavigations { get; set; } = new List<OperationItemDetail>();

    public virtual ICollection<OperationItem> OperationItemOpiPlIdLocNavigations { get; set; } = new List<OperationItem>();

    public virtual ICollection<OperationItem> OperationItemOpiPlIdWhsNavigations { get; set; } = new List<OperationItem>();

    public virtual ICollection<Operation> OperationOpPlIdWhsNavigations { get; set; } = new List<Operation>();

    public virtual ICollection<Operation> OperationOpPlIdWhsToNavigations { get; set; } = new List<Operation>();

    public virtual ICollection<PhysicalLocationOdometer> PhysicalLocationOdometers { get; set; } = new List<PhysicalLocationOdometer>();

    public virtual BusinessUnit? PlBu { get; set; }

    public virtual Codesc PlCdIdPltNavigation { get; set; } = null!;

    public virtual Module PlMd { get; set; } = null!;

    public virtual PhysicalLocation? PlPl { get; set; }

    public virtual ICollection<ProspectThirdpartysite> ProspectThirdpartysites { get; set; } = new List<ProspectThirdpartysite>();

    public virtual ICollection<RouteWarehouse> RouteWarehouses { get; set; } = new List<RouteWarehouse>();

    public virtual ICollection<ThirdpartySiteListpriceRoute> ThirdpartySiteListpriceRoutes { get; set; } = new List<ThirdpartySiteListpriceRoute>();

    public virtual ICollection<TransactionDeliveryItem> TransactionDeliveryItems { get; set; } = new List<TransactionDeliveryItem>();

    public virtual ICollection<TransactionItem> TransactionItems { get; set; } = new List<TransactionItem>();

    public virtual ICollection<UserWarehouse> UserWarehouses { get; set; } = new List<UserWarehouse>();
}
