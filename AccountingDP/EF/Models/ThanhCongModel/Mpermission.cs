﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Mpermission
{
    public string UserId { get; set; } = null!;

    public string MenuId { get; set; } = null!;

    public string ZoneId { get; set; } = null!;

    public string? SyncTime { get; set; }

    public virtual Menu Menu { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual Zone Zone { get; set; } = null!;
}
