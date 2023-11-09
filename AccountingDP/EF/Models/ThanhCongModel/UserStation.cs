using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class UserStation
{
    public string UserId { get; set; } = null!;

    public string StationId { get; set; } = null!;

    public string? SyncTime { get; set; }

    public virtual User User { get; set; } = null!;
}
