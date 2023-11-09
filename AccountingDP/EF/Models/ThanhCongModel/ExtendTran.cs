using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ExtendTran
{
    public string TransactionId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
