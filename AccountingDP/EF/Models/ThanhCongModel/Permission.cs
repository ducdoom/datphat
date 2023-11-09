﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Permission
{
    public string UserId { get; set; } = null!;

    public string FormId { get; set; } = null!;

    public string ControlId { get; set; } = null!;

    public string ZoneId { get; set; } = null!;

    public string? SyncTime { get; set; }

    public virtual Control Control { get; set; } = null!;

    public virtual Form Form { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual Zone Zone { get; set; } = null!;
}
