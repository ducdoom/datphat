using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class UserRole
{
    public string UserId { get; set; } = null!;

    public string RoleId { get; set; } = null!;

    public string? SyncTime { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
