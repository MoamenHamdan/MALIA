using System;
using System.Collections.Generic;

namespace M_Suite.Models;

public partial class Movementstatus
{
    public int MssId { get; set; }

    public string MssCode { get; set; } = null!;

    public string MssDescriptionLan1 { get; set; } = null!;

    public string MssDescriptionLan2 { get; set; } = null!;

    public string MssDescriptionLan3 { get; set; } = null!;

    public string? MssStyle { get; set; }

    public string? MssConfirmationCode { get; set; }

    public string MssLabelCode { get; set; } = null!;

    public int MssOrder { get; set; }

    public short MssCausesValidation { get; set; }

    public virtual ICollection<MovementStatusHistory> MovementStatusHistories { get; set; } = new List<MovementStatusHistory>();

    public virtual ICollection<Movementitemquotum> Movementitemquota { get; set; } = new List<Movementitemquotum>();

    public virtual ICollection<MovementitemquotaMvt> MovementitemquotaMvts { get; set; } = new List<MovementitemquotaMvt>();

    public virtual ICollection<Movement> Movements { get; set; } = new List<Movement>();

    public virtual ICollection<MovementstatusTransition> MovementstatusTransitionMsstMssIdFromNavigations { get; set; } = new List<MovementstatusTransition>();

    public virtual ICollection<MovementstatusTransition> MovementstatusTransitionMsstMssIdGenerateNavigations { get; set; } = new List<MovementstatusTransition>();

    public virtual ICollection<MovementstatusTransition> MovementstatusTransitionMsstMssIdToNavigations { get; set; } = new List<MovementstatusTransition>();

    public virtual ICollection<UiMovementFunctionNouse> UiMovementFunctionNouses { get; set; } = new List<UiMovementFunctionNouse>();

    public virtual ICollection<UiMovementItem> UiMovementItems { get; set; } = new List<UiMovementItem>();

    public virtual ICollection<UiMovement> UiMovements { get; set; } = new List<UiMovement>();
}
