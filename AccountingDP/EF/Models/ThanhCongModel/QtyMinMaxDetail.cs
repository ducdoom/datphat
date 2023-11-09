using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class QtyMinMaxDetail
{
    public string QtyMinMaxId { get; set; } = null!;

    public string ZoneId { get; set; } = null!;

    public string StockId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public int? QtyMin { get; set; }

    public int? QtyMax { get; set; }

    /// <summary>
    /// 0: CK trước thuế; 1: CK sau thuế
    /// </summary>
    public bool? OrderInGeneral { get; set; }

    /// <summary>
    /// 0: CK trước thuế; 1: CK sau thuế
    /// </summary>
    public bool? RoundBigUnit { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual Good Good { get; set; } = null!;

    public virtual Stock Stock { get; set; } = null!;

    public virtual Zone Zone { get; set; } = null!;
}
