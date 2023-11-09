using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class AlertDate
{
    public string StockId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public int? NoOfDate { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual Good Good { get; set; } = null!;

    public virtual Stock Stock { get; set; } = null!;
}
