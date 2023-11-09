using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class StockBranch
{
    public string StockId { get; set; } = null!;

    public string BranchId { get; set; } = null!;

    public string? SyncTime { get; set; }
}
