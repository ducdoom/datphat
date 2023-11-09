using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class LogDetail
{
    public string LogId { get; set; } = null!;

    public string? LogContent { get; set; }

    public string? SyncTime { get; set; }

    public virtual Log Log { get; set; } = null!;
}
