using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class OriginalTransaction
{
    public string TransactionId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string? OrgTransType { get; set; }

    public decimal? Debt { get; set; }

    public decimal? Have { get; set; }

    public string? TransDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? SyncTime { get; set; }
}
