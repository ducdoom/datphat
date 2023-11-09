using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class RoleZone
{
    public string RoleId { get; set; } = null!;

    public string ZoneId { get; set; } = null!;

    public string? SyncTime { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual Zone Zone { get; set; } = null!;
}
