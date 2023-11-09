using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Rmpermission
{
    public string RoleId { get; set; } = null!;

    public string MenuId { get; set; } = null!;

    public string ZoneId { get; set; } = null!;

    public string? SyncTime { get; set; }

    public virtual Menu Menu { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual Zone Zone { get; set; } = null!;
}
